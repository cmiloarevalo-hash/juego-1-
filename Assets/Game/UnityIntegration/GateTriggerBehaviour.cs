using ChristmasRunner.Gameplay.Gates;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class GateTriggerBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private string stableGateId = "gate-01";
        [SerializeField] private GateOperation operation = GateOperation.Add;
        [SerializeField, Min(1)] private int operand = 1;
        private bool consumed;

        private void OnTriggerEnter(Collider other)
        {
            if (consumed || session == null || !other.CompareTag("Player")) return;
            consumed = session.Session.ChooseGate(stableGateId, operation, operand);
            if (consumed) gameObject.SetActive(false);
        }
    }
}
