using System;
using ChristmasRunner.Gameplay.Boss;
using ChristmasRunner.Gameplay.Combat;
using ChristmasRunner.Gameplay.Gates;
using ChristmasRunner.Gameplay.Localization;
using ChristmasRunner.Gameplay.Obstacles;
using ChristmasRunner.Gameplay.Run;

namespace ChristmasRunner.Gameplay.Integration
{
    public sealed class GameSession
    {
        public RunCoordinator Run { get; }
        public GateResolver Gates { get; } = new GateResolver();
        public CombatResolver Combat { get; } = new CombatResolver();
        public Localizer Localization { get; } = new Localizer();
        public BossEncounter Boss { get; }
        public RunResult? FinalResult { get; private set; }
        public event Action<RunResult> ResultReady;

        public GameSession(int initialHelpers, int bossHealth)
        {
            if (initialHelpers <= 0) throw new ArgumentOutOfRangeException(nameof(initialHelpers));
            Run = new RunCoordinator(initialHelpers);
            Boss = new BossEncounter(Run, Combat, bossHealth);
            Run.ResultProduced += CaptureResult;
        }

        public void CompleteOnboarding() => Run.BeginTraversal();

        public bool ChooseGate(string gateId, GateOperation operation, int positiveOperand)
        {
            if (Run.IsTerminal) return false;
            return Gates.TryApply(gateId, operation, positiveOperand, Run.Army);
        }

        public void HitAvoidableObstacle(int helperDamage)
        {
            if (Run.IsTerminal) return;
            Run.Army.ApplyDamage(helperDamage);
        }

        public bool UseHammer(BreakableObstacle obstacle)
        {
            if (Run.IsTerminal || obstacle == null) return false;
            return obstacle.TryBreakWithHammer();
        }

        public bool SnowballEnemy(EnemyState enemy, int damage)
        {
            if (Run.IsTerminal) return false;
            return Combat.TrySnowballAttack(enemy, damage);
        }

        public void StartBoss()
        {
            if (!Run.IsTerminal) Boss.Start();
        }

        private void CaptureResult(RunResult result)
        {
            if (FinalResult.HasValue) return;
            FinalResult = result;
            ResultReady?.Invoke(result);
        }
    }
}
