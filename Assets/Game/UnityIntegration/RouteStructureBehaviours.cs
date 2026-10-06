using System;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public enum RouteSectionKind
    {
        OnboardingDeparture,
        Growth,
        PositiveGates,
        ObstacleHammer,
        SnowballCombat,
        BossApproach,
        BossArena,
        Result
    }

    /// <summary>Authored marker for one ordered portion of the single continuous Level 1 route.</summary>
    public sealed class RouteSectionBehaviour : MonoBehaviour
    {
        [SerializeField] private RouteSectionKind kind;
        [SerializeField, Min(0)] private int order;
        [SerializeField] private Transform entry;
        [SerializeField] private Transform exit;

        public RouteSectionKind Kind => kind;
        public int Order => order;
        public Transform Entry => entry != null ? entry : transform;
        public Transform Exit => exit != null ? exit : transform;
    }

    /// <summary>Static route contract. It validates authored ordering only; it owns no gameplay state.</summary>
    public sealed class ContinuousRouteBehaviour : MonoBehaviour
    {
        [SerializeField] private RouteSectionBehaviour[] sections = Array.Empty<RouteSectionBehaviour>();

        public RouteSectionBehaviour[] Sections => sections;

        public bool HasExpectedLevelOneOrder()
        {
            if (sections == null || sections.Length != 8) return false;
            RouteSectionKind[] expected =
            {
                RouteSectionKind.OnboardingDeparture,
                RouteSectionKind.Growth,
                RouteSectionKind.PositiveGates,
                RouteSectionKind.ObstacleHammer,
                RouteSectionKind.SnowballCombat,
                RouteSectionKind.BossApproach,
                RouteSectionKind.BossArena,
                RouteSectionKind.Result
            };

            for (int i = 0; i < expected.Length; i++)
            {
                if (sections[i] == null || sections[i].Kind != expected[i] || sections[i].Order != i)
                    return false;
            }
            return true;
        }
    }
}
