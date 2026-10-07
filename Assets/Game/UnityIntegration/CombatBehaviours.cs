using System.Collections;
using ChristmasRunner.Gameplay.Combat;
using ChristmasRunner.Gameplay.Run;
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

    public sealed class SnowballAttackBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int damage = 1;

        public bool Attack(EnemyBehaviour enemy)
        {
            return session != null && enemy != null && session.SnowballEnemy(enemy.State, damage);
        }
    }

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

    public sealed class BossEncounterBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int armyDamagePerHelper = 1;
        [SerializeField, Min(1)] private int snowballDamage = 1;
        [SerializeField, Min(1)] private int telegraphedHelperDamage = 1;

        public void StartEncounter() { if (session != null) session.StartBoss(); }
        public bool ArmyAttack() => session != null && session.ArmyAttackBoss(armyDamagePerHelper);
        public bool SnowballAttack() => session != null && session.SnowballBoss(snowballDamage);
        public void ResolveTelegraphedAttack() { if (session != null) session.ApplyBossAttack(telegraphedHelperDamage); }
    }

    internal static class ForwardCombatTargetQuery
    {
        public static bool TryFindEnemy(
            Transform origin,
            float range,
            float minimumForwardDot,
            LayerMask targetMask,
            Collider[] buffer,
            out EnemyBehaviour enemy,
            out Vector3 targetPoint)
        {
            enemy = null;
            targetPoint = default;
            float bestDistance = float.PositiveInfinity;
            int count = Physics.OverlapSphereNonAlloc(
                origin.position,
                range,
                buffer,
                targetMask,
                QueryTriggerInteraction.Collide);

            for (int i = 0; i < count; i++)
            {
                Collider candidateCollider = buffer[i];
                if (candidateCollider == null) continue;

                EnemyBehaviour candidate = candidateCollider.GetComponentInParent<EnemyBehaviour>();
                if (candidate == null || candidate.State == null || candidate.State.IsDefeated) continue;

                Vector3 point = candidateCollider.bounds.center;
                float sqrDistance;
                if (!IsForwardCandidate(origin, point, minimumForwardDot, out sqrDistance)) continue;
                if (sqrDistance >= bestDistance) continue;

                bestDistance = sqrDistance;
                enemy = candidate;
                targetPoint = point;
            }

            return enemy != null;
        }

        public static bool TryFindBoss(
            Transform origin,
            float range,
            float minimumForwardDot,
            LayerMask targetMask,
            Collider[] buffer,
            out BossEncounterBehaviour boss,
            out Vector3 targetPoint)
        {
            boss = null;
            targetPoint = default;
            float bestDistance = float.PositiveInfinity;
            int count = Physics.OverlapSphereNonAlloc(
                origin.position,
                range,
                buffer,
                targetMask,
                QueryTriggerInteraction.Collide);

            for (int i = 0; i < count; i++)
            {
                Collider candidateCollider = buffer[i];
                if (candidateCollider == null) continue;

                BossEncounterBehaviour candidate = candidateCollider.GetComponentInParent<BossEncounterBehaviour>();
                if (candidate == null) continue;

                Vector3 point = candidateCollider.bounds.center;
                float sqrDistance;
                if (!IsForwardCandidate(origin, point, minimumForwardDot, out sqrDistance)) continue;
                if (sqrDistance >= bestDistance) continue;

                bestDistance = sqrDistance;
                boss = candidate;
                targetPoint = point;
            }

            return boss != null;
        }

        private static bool IsForwardCandidate(
            Transform origin,
            Vector3 point,
            float minimumForwardDot,
            out float sqrDistance)
        {
            Vector3 toTarget = point - origin.position;
            sqrDistance = toTarget.sqrMagnitude;
            if (sqrDistance <= Mathf.Epsilon) return true;

            float dot = Vector3.Dot(origin.forward, toTarget.normalized);
            return dot >= minimumForwardDot;
        }
    }
}
