using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class HelperRescueTriggerBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int helperCount = 1;
        private bool consumed;

        private void OnTriggerEnter(Collider other)
        {
            if (consumed || session == null || !other.CompareTag("Player")) return;
            consumed = session.RecruitHelpers(helperCount);
            if (consumed) gameObject.SetActive(false);
        }
    }
}
