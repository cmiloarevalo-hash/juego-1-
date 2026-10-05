using System;
using ChristmasRunner.Gameplay.Army;

namespace ChristmasRunner.Gameplay.Run
{
    public enum RunPhase { Onboarding, Traversal, Boss, Victory, Defeat }

    public sealed class RunCoordinator
    {
        public ArmyState Army { get; }
        public RunPhase Phase { get; private set; }
        public bool IsTerminal => Phase == RunPhase.Victory || Phase == RunPhase.Defeat;
        public event Action<RunPhase> PhaseChanged;
        public event Action<RunResult> ResultProduced;
        private bool _resultProduced;

        public RunCoordinator(int initialHelpers)
        {
            Army = new ArmyState(initialHelpers);
            Phase = RunPhase.Onboarding;
            Army.Depleted += Defeat;
        }

        public void BeginTraversal() => TransitionNonTerminal(RunPhase.Traversal);
        public void BeginBoss() => TransitionNonTerminal(RunPhase.Boss);
        public void Victory() => Finish(RunPhase.Victory);
        public void Defeat() => Finish(RunPhase.Defeat);

        private void TransitionNonTerminal(RunPhase next)
        {
            if (IsTerminal || Phase == next) return;
            Phase = next;
            PhaseChanged?.Invoke(Phase);
        }

        private void Finish(RunPhase terminal)
        {
            if (IsTerminal || _resultProduced) return;
            Phase = terminal;
            _resultProduced = true;
            PhaseChanged?.Invoke(Phase);
            ResultProduced?.Invoke(new RunResult(terminal, Army.Count));
        }
    }

    public readonly struct RunResult
    {
        public RunPhase Outcome { get; }
        public int HelpersRemaining { get; }
        public RunResult(RunPhase outcome, int helpersRemaining)
        {
            Outcome = outcome;
            HelpersRemaining = helpersRemaining;
        }
    }
}
