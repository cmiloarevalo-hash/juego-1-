using System;

namespace ChristmasRunner.Gameplay.Army
{
    public sealed class ArmyState
    {
        public int Count { get; private set; }
        public int? TechnicalCapacity { get; }
        public bool IsFrozen { get; private set; }
        public event Action<int> CountChanged;
        public event Action Depleted;

        public ArmyState(int initialCount, int? technicalCapacity = null)
        {
            if (technicalCapacity.HasValue && technicalCapacity.Value <= 0)
                throw new ArgumentOutOfRangeException(nameof(technicalCapacity));

            TechnicalCapacity = technicalCapacity;
            int normalized = Math.Max(0, initialCount);
            Count = TechnicalCapacity.HasValue ? Math.Min(normalized, TechnicalCapacity.Value) : normalized;
        }

        public bool Add(int amount)
        {
            if (amount <= 0 || Count == 0 || IsFrozen) return false;
            return TrySetGrowthCount((long)Count + amount);
        }

        public bool Multiply(int factor)
        {
            if (factor <= 0) throw new ArgumentOutOfRangeException(nameof(factor));
            if (Count == 0 || IsFrozen) return false;
            return TrySetGrowthCount((long)Count * factor);
        }

        public void ApplyDamage(int amount)
        {
            if (amount <= 0 || Count == 0 || IsFrozen) return;
            SetCount(Math.Max(0, Count - amount));
        }

        internal void Freeze()
        {
            IsFrozen = true;
        }

        private bool TrySetGrowthCount(long requestedCount)
        {
            long bounded = TechnicalCapacity.HasValue
                ? Math.Min(requestedCount, (long)TechnicalCapacity.Value)
                : requestedCount;

            if (bounded > int.MaxValue) return false;
            SetCount((int)bounded);
            return true;
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
