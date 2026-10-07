using ChristmasRunner.Gameplay.Combat;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class EnemyBehaviour : MonoBehaviour
    {
        [SerializeField, Min(1)] private int health = 3;
        [SerializeField] private GameObject aliveVisual;
        private EnemyState state;

        public EnemyState State => state;

        private void Awake()
        {
            state = new EnemyState(health);
            state.Defeated += PresentDefeat;
        }

        private void OnDestroy()
        {
            if (state != null) state.Defeated -= PresentDefeat;
        }

        private void PresentDefeat()
        {
            if (aliveVisual != null) aliveVisual.SetActive(false);
        }
    }
}
