using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class DamagingObstacleBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int helperDamage = 1;
        private bool applied;

        private void OnTriggerEnter(Collider other)
        {
            if (applied || session == null || !other.CompareTag("Player")) return;
            applied = true;
            session.HitObstacle(helperDamage);
        }
    }
}
