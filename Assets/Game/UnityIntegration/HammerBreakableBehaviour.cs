using ChristmasRunner.Gameplay.Obstacles;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    [RequireComponent(typeof(Collider))]
    public sealed class HammerBreakableBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private GameObject intactVisual;
        [SerializeField] private GameObject brokenVisual;
        private readonly BreakableObstacle obstacle = new BreakableObstacle();

        private void Awake()
        {
            obstacle.Broken += PresentBroken;
            PresentState(false);
        }

        private void OnDestroy() => obstacle.Broken -= PresentBroken;

        private void OnTriggerEnter(Collider other)
        {
            if (session == null || !other.CompareTag("Player")) return;
            TryUseHammer();
        }

        public bool TryUseHammer()
        {
            return session != null && session.UseHammer(obstacle);
        }

        private void PresentBroken() => PresentState(true);

        private void PresentState(bool broken)
        {
            if (intactVisual != null) intactVisual.SetActive(!broken);
            if (brokenVisual != null) brokenVisual.SetActive(broken);
        }
    }
}
