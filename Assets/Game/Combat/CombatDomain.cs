using System;
using ChristmasRunner.Gameplay.Army;

namespace ChristmasRunner.Gameplay.Combat
{
    public interface IDamageable
    {
        bool IsDefeated { get; }
        void ApplyDamage(int amount);
    }

    public class EnemyState : IDamageable
    {
        public int Health { get; private set; }
        public bool IsDefeated { get; private set; }
        public event Action Defeated;

        public EnemyState(int health)
        {
            if (health <= 0) throw new ArgumentOutOfRangeException(nameof(health));
            Health = health;
        }

        public void ApplyDamage(int amount)
        {
            if (amount <= 0 || IsDefeated) return;
            Health = Math.Max(0, Health - amount);
            if (Health != 0) return;
            IsDefeated = true;
            Defeated?.Invoke();
        }
    }

    public sealed class CombatResolver
    {
        public bool TrySnowballAttack(IDamageable target, int snowballDamage)
        {
            if (target == null || target.IsDefeated || snowballDamage <= 0) return false;
            target.ApplyDamage(snowballDamage);
            return true;
        }

        public bool TryArmyAttack(ArmyState army, IDamageable target, int damagePerHelper)
        {
            if (army == null || target == null || target.IsDefeated || army.Count <= 0 || damagePerHelper <= 0) return false;
            target.ApplyDamage(checked(army.Count * damagePerHelper));
            return true;
        }

        public void ApplyEnemyDamageToArmy(ArmyState army, int helperDamage)
        {
            if (army == null) throw new ArgumentNullException(nameof(army));
            army.ApplyDamage(helperDamage);
        }
    }
}
