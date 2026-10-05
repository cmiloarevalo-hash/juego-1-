using System;

namespace ChristmasRunner.Gameplay.Army
{
    public sealed class ArmyState
    {
        public int Count { get; private set; }
        public event Action<int> CountChanged;
        public event Action Depleted;

        public ArmyState(int initialCount)
        {
            Count = Math.Max(0, initialCount);
        }

        public void Add(int amount)
        {
            if (amount <= 0 || Count == 0) return;
            SetCount(checked(Count + amount));
        }

        public void Multiply(int factor)
        {
            if (factor <= 0) throw new ArgumentOutOfRangeException(nameof(factor));
            if (Count == 0) return;
            SetCount(checked(Count * factor));
        }

        public void ApplyDamage(int amount)
        {
            if (amount <= 0 || Count == 0) return;
            SetCount(Math.Max(0, Count - amount));
        }

        private void SetCount(int value)
        {
            if (value == Count) return;
            Count = value;
            CountChanged?.Invoke(Count);
            if (Count == 0) Depleted?.Invoke();
        }
    }
}
