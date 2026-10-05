using System;
using ChristmasRunner.Gameplay.Army;
using ChristmasRunner.Gameplay.Combat;
using ChristmasRunner.Gameplay.Run;

namespace ChristmasRunner.Gameplay.Boss
{
    public sealed class BossEncounter
    {
        private readonly RunCoordinator _run;
        private readonly CombatResolver _combat;
        public EnemyState Boss { get; }
        public bool Started { get; private set; }
        public bool Completed { get; private set; }

        public BossEncounter(RunCoordinator run, CombatResolver combat, int bossHealth)
        {
            _run = run ?? throw new ArgumentNullException(nameof(run));
            _combat = combat ?? throw new ArgumentNullException(nameof(combat));
            Boss = new EnemyState(bossHealth);
            Boss.Defeated += Complete;
        }

        public void Start()
        {
            if (Started || _run.IsTerminal) return;
            Started = true;
            _run.BeginBoss();
        }

        public bool ArmyAttack(int damagePerHelper)
        {
            if (!Started || Completed) return false;
            return _combat.TryArmyAttack(_run.Army, Boss, damagePerHelper);
        }

        public bool SnowballAttack(int damage)
        {
            if (!Started || Completed) return false;
            return _combat.TrySnowballAttack(Boss, damage);
        }

        public void ApplyTelegraphedAttack(int helperDamage)
        {
            if (!Started || Completed || helperDamage <= 0) return;
            _combat.ApplyEnemyDamageToArmy(_run.Army, helperDamage);
        }

        private void Complete()
        {
            if (Completed) return;
            Completed = true;
            _run.Victory();
        }
    }
}
