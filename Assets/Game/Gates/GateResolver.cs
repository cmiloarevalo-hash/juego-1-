using System;
using System.Collections.Generic;
using ChristmasRunner.Gameplay.Army;

namespace ChristmasRunner.Gameplay.Gates
{
    public enum GateOperation { Add, Multiply }

    public sealed class GateResolver
    {
        private readonly HashSet<string> _consumedGateIds = new HashSet<string>();

        public bool TryApply(string stableGateId, GateOperation operation, int operand, ArmyState army)
        {
            if (string.IsNullOrWhiteSpace(stableGateId)) throw new ArgumentException("Stable gate ID is required.", nameof(stableGateId));
            if (operand <= 0) throw new ArgumentOutOfRangeException(nameof(operand));
            if (army == null) throw new ArgumentNullException(nameof(army));
            if (_consumedGateIds.Contains(stableGateId)) return false;

            bool applied;
            switch (operation)
            {
                case GateOperation.Add:
                    applied = army.Add(operand);
                    break;
                case GateOperation.Multiply:
                    applied = army.Multiply(operand);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }

            if (!applied) return false;
            _consumedGateIds.Add(stableGateId);
            return true;
        }

        public void ResetForNewRun() => _consumedGateIds.Clear();
    }
}
