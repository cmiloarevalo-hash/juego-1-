using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class SnowballAttackBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int damage = 1;

        public bool Attack(EnemyBehaviour enemy)
        {
            return session != null && enemy != null && session.SnowballEnemy(enemy.State, damage);
        }
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
