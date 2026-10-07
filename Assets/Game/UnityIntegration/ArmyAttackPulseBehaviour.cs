using ChristmasRunner.Gameplay.Run;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class ArmyAttackPulseBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private Transform attackOrigin;
        [SerializeField, Min(1)] private int damagePerHelper = 1;
        [SerializeField, Min(0.1f)] private float range = 8f;
        [SerializeField, Range(-1f, 1f)] private float minimumForwardDot = 0.1f;
        [SerializeField, Min(0.05f)] private float pulseCadence = 0.8f;
        [SerializeField] private LayerMask targetMask = ~0;
        [SerializeField] private GameObject pulseVisualPrefab;
        [SerializeField, Min(0.05f)] private float pulseVisualLifetime = 0.35f;

        private readonly Collider[] targetBuffer = new Collider[32];
        private float nextPulseTime;

        private void Update()
        {
            if (Time.time < nextPulseTime) return;
            TryPulseNow();
        }

        public bool TryPulseNow()
        {
            if (Time.time < nextPulseTime || session == null || session.IsTerminal || session.HelperCount <= 0) return false;

            Transform origin = attackOrigin != null ? attackOrigin : transform;
            bool attacked;
            Vector3 targetPoint;

            if (session.Phase == RunPhase.Traversal)
            {
                EnemyBehaviour enemy;
                if (!ForwardCombatTargetQuery.TryFindEnemy(
                        origin,
                        range,
                        minimumForwardDot,
                        targetMask,
                        targetBuffer,
                        out enemy,
                        out targetPoint))
                    return false;

                attacked = session.ArmyAttackEnemy(enemy.State, damagePerHelper);
            }
            else if (session.Phase == RunPhase.Boss)
            {
                BossEncounterBehaviour boss;
                if (!ForwardCombatTargetQuery.TryFindBoss(
                        origin,
                        range,
                        minimumForwardDot,
                        targetMask,
                        targetBuffer,
                        out boss,
                        out targetPoint))
                    return false;

                attacked = boss != null && session.ArmyAttackBoss(damagePerHelper);
            }
            else
            {
                return false;
            }

            if (!attacked) return false;

            nextPulseTime = Time.time + pulseCadence;
            PresentPulse(targetPoint);
            return true;
        }

        private void PresentPulse(Vector3 targetPoint)
        {
            if (pulseVisualPrefab == null) return;
            GameObject visual = Instantiate(pulseVisualPrefab, targetPoint, Quaternion.identity);
            Destroy(visual, pulseVisualLifetime);
        }
    }
}
