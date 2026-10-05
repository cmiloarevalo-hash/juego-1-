using ChristmasRunner.Gameplay.Army;
using UnityEngine;

namespace ChristmasRunner.Gameplay.Obstacles
{
    public sealed class ObstacleTrigger : MonoBehaviour
    {
        [SerializeField] private int helperDamage = 1;
        private bool _consumed;
        public ArmyState Army { private get; set; }

        private void OnTriggerEnter(Collider other)
        {
            if (_consumed || Army == null) return;
            if (!other.CompareTag("Player")) return;
            _consumed = true;
            Army.ApplyDamage(Mathf.Max(1, helperDamage));
        }
    }

    public sealed class HammerBreakPresenter : MonoBehaviour
    {
        [SerializeField] private GameObject intactVisual;
        [SerializeField] private GameObject brokenVisual;
        private readonly BreakableObstacle _state = new BreakableObstacle();

        public void UseHammer()
        {
            if (!_state.TryBreakWithHammer()) return;
            if (intactVisual != null) intactVisual.SetActive(false);
            if (brokenVisual != null) brokenVisual.SetActive(true);
        }
    }
}
