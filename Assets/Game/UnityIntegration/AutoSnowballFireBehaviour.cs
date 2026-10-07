using System.Collections;
using ChristmasRunner.Gameplay.Run;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class AutoSnowballFireBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private Transform attackOrigin;
        [SerializeField, Min(1)] private int damage = 1;
        [SerializeField, Min(0.1f)] private float range = 12f;
        [SerializeField, Range(-1f, 1f)] private float minimumForwardDot = 0.15f;
        [SerializeField, Min(0.05f)] private float cooldown = 0.6f;
        [SerializeField] private LayerMask targetMask = ~0;
        [SerializeField] private GameObject projectileVisualPrefab;
        [SerializeField, Min(0.1f)] private float projectileVisualSpeed = 18f;
        [SerializeField, Min(0.05f)] private float projectileVisualLifetime = 1.5f;

        private readonly Collider[] targetBuffer = new Collider[32];
        private float nextFireTime;

        private void Update()
        {
            if (Time.time < nextFireTime) return;
            TryFireNow();
        }

        public bool TryFireNow()
        {
            if (Time.time < nextFireTime || session == null || session.IsTerminal) return false;

            Transform origin = attackOrigin != null ? attackOrigin : transform;
            bool fired;
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

                fired = session.SnowballEnemy(enemy.State, damage);
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

                fired = boss != null && session.SnowballBoss(damage);
            }
            else
            {
                return false;
            }

            if (!fired) return false;

            nextFireTime = Time.time + cooldown;
            PresentProjectile(origin.position, targetPoint);
            return true;
        }

        private void PresentProjectile(Vector3 start, Vector3 target)
        {
            if (projectileVisualPrefab == null) return;
            GameObject visual = Instantiate(projectileVisualPrefab, start, Quaternion.identity);
            StartCoroutine(MoveProjectileVisual(visual, target));
        }

        private IEnumerator MoveProjectileVisual(GameObject visual, Vector3 target)
        {
            float elapsed = 0f;
            while (visual != null && elapsed < projectileVisualLifetime)
            {
                visual.transform.position = Vector3.MoveTowards(
                    visual.transform.position,
                    target,
                    projectileVisualSpeed * Time.deltaTime);

                if ((visual.transform.position - target).sqrMagnitude <= 0.0001f) break;
                elapsed += Time.deltaTime;
                yield return null;
            }

            if (visual != null) Destroy(visual);
        }
    }
}
