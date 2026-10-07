using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class OnboardingExitTriggerBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        private bool completed;

        private void OnTriggerEnter(Collider other)
        {
            if (completed || session == null || !other.CompareTag("Player")) return;
            completed = session.CompleteOnboarding();
        }
    }
}
