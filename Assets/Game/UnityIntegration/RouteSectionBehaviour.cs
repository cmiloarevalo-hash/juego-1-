using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
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
}
