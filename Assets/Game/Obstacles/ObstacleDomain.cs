using System;

namespace ChristmasRunner.Gameplay.Obstacles
{
    public sealed class BreakableObstacle
    {
        public bool IsBroken { get; private set; }
        public event Action Broken;

        public bool TryBreakWithHammer()
        {
            if (IsBroken) return false;
            IsBroken = true;
            Broken?.Invoke();
            return true;
        }
    }

    public sealed class AvoidableObstacle
    {
        public int HelperDamage { get; }
        public AvoidableObstacle(int helperDamage)
        {
            if (helperDamage <= 0) throw new ArgumentOutOfRangeException(nameof(helperDamage));
            HelperDamage = helperDamage;
        }
    }
}
