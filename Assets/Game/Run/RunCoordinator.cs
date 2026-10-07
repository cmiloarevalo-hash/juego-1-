using System;
using ChristmasRunner.Gameplay.Army;

namespace ChristmasRunner.Gameplay.Run
{
    public enum RunPhase { Onboarding, Traversal, Boss, Victory, Defeat }

    public sealed class RunCoordinator
    {
        public ArmyState Army { get; }
        public string StageId { get; }
        public string RunId { get; }
        public RunPhase Phase { get; private set; }
        public bool IsTerminal => Phase == RunPhase.Victory || Phase == RunPhase.Defeat;
        public event Action<RunPhase> PhaseChanged;
        public event Action<RunResult> ResultProduced;
        private bool _resultProduced;

        public RunCoordinator(int initialHelpers)
            : this(initialHelpers, "level-1", Guid.NewGuid().ToString("N"))
        {
        }

        public RunCoordinator(
            int initialHelpers,
            string stageId,
            string runId,
            int? technicalArmyCapacity = null)
        {
            if (string.IsNullOrWhiteSpace(stageId))
                throw new ArgumentException("Stage ID is required.", nameof(stageId));
            if (string.IsNullOrWhiteSpace(runId))
                throw new ArgumentException("Run ID is required.", nameof(runId));

            StageId = stageId;
            RunId = runId;
            Army = new ArmyState(initialHelpers, technicalArmyCapacity);
            Phase = RunPhase.Onboarding;
            Army.Depleted += OnArmyDepleted;
        }

        public bool BeginTraversal() => Transition(RunPhase.Onboarding, RunPhase.Traversal);
        public bool BeginBoss() => Transition(RunPhase.Traversal, RunPhase.Boss);
        public bool Victory() => Phase == RunPhase.Boss && Finish(RunPhase.Victory);
        public bool Defeat() => !IsTerminal && Finish(RunPhase.Defeat);

        private void OnArmyDepleted()
        {
            Defeat();
        }

        private bool Transition(RunPhase expectedCurrent, RunPhase next)
        {
            if (IsTerminal || Phase != expectedCurrent) return false;
            Phase = next;
            PhaseChanged?.Invoke(Phase);
            return true;
        }

        private bool Finish(RunPhase terminal)
        {
            if (IsTerminal || _resultProduced) return false;

            Phase = terminal;
            _resultProduced = true;
            Army.Freeze();
            PhaseChanged?.Invoke(Phase);
            ResultProduced?.Invoke(new RunResult(StageId, RunId, terminal, Army.Count));
            return true;
        }
    }

    public readonly struct RunResult
    {
        public string StageId { get; }
        public string RunId { get; }
        public RunPhase Outcome { get; }
        public int HelpersRemaining { get; }

        public RunResult(string stageId, string runId, RunPhase outcome, int helpersRemaining)
        {
            if (string.IsNullOrWhiteSpace(stageId))
                throw new ArgumentException("Stage ID is required.", nameof(stageId));
            if (string.IsNullOrWhiteSpace(runId))
                throw new ArgumentException("Run ID is required.", nameof(runId));
            if (outcome != RunPhase.Victory && outcome != RunPhase.Defeat)
                throw new ArgumentOutOfRangeException(nameof(outcome));

            StageId = stageId;
            RunId = runId;
            Outcome = outcome;
            HelpersRemaining = helpersRemaining;
        }
    }
}
