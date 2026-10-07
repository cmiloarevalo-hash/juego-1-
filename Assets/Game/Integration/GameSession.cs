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
        public const string DefaultStageId = "level-1";

        public RunCoordinator Run { get; }
        public GateResolver Gates { get; } = new GateResolver();
        public CombatResolver Combat { get; } = new CombatResolver();
        public Localizer Localization { get; } = new Localizer();
        public BossEncounter Boss { get; }
        public RunResult? FinalResult { get; private set; }
        public event Action<RunResult> ResultReady;

        public GameSession(int initialHelpers, int bossHealth)
            : this(
                initialHelpers,
                bossHealth,
                DefaultStageId,
                Guid.NewGuid().ToString("N"))
        {
        }

        public GameSession(
            int initialHelpers,
            int bossHealth,
            string stageId,
            string runId,
            int? technicalArmyCapacity = null)
        {
            if (initialHelpers <= 0) throw new ArgumentOutOfRangeException(nameof(initialHelpers));
            Run = new RunCoordinator(initialHelpers, stageId, runId, technicalArmyCapacity);
            Boss = new BossEncounter(Run, Combat, bossHealth);
            Run.ResultProduced += CaptureResult;
        }

        public bool CompleteOnboarding() => Run.BeginTraversal();

        public bool RecruitHelpers(int helperCount)
        {
            if (Run.IsTerminal || Run.Phase != RunPhase.Traversal || helperCount <= 0) return false;

            int before = Run.Army.Count;
            if (!Run.Army.Add(helperCount)) return false;
            return Run.Army.Count > before;
        }

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

        public bool ArmyAttackEnemy(EnemyState enemy, int damagePerHelper)
        {
            if (Run.IsTerminal || Run.Phase != RunPhase.Traversal) return false;
            return Combat.TryArmyAttack(Run.Army, enemy, damagePerHelper);
        }

        public bool StartBoss()
        {
            if (Run.IsTerminal) return false;
            return Boss.Start();
        }

        public bool ArmyAttackBoss(int damagePerHelper)
        {
            if (Run.IsTerminal) return false;
            return Boss.ArmyAttack(damagePerHelper);
        }

        public bool SnowballBoss(int damage)
        {
            if (Run.IsTerminal) return false;
            return Boss.SnowballAttack(damage);
        }

        public void ApplyBossAttack(int helperDamage)
        {
            if (Run.IsTerminal) return;
            Boss.ApplyTelegraphedAttack(helperDamage);
        }

        private void CaptureResult(RunResult result)
        {
            if (FinalResult.HasValue) return;
            FinalResult = result;
            ResultReady?.Invoke(result);
        }
    }
}
