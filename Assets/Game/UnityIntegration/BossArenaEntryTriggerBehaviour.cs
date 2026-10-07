using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class BossArenaEntryTriggerBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        private bool started;

        private void OnTriggerEnter(Collider other)
        {
            if (started || session == null || !other.CompareTag("Player")) return;
            started = session.StartBoss();
        }
    }
}
