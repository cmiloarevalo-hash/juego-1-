using System;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
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
