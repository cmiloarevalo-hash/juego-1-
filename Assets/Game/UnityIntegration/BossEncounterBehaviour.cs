using ChristmasRunner.Gameplay.Run;
using ChristmasRunner.Gameplay.Combat;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class BossEncounterBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int armyDamagePerHelper = 1;
        [SerializeField, Min(1)] private int snowballDamage = 1;
        [SerializeField, Min(1)] private int telegraphedHelperDamage = 1;
        [SerializeField, Min(0.1f)] private float attackCadence = 2.5f;
        [SerializeField, Min(0.05f)] private float telegraphDuration = 0.75f;
        [SerializeField] private GameObject telegraphVisual;

        private bool telegraphing;
        private float resolveAt;
        private float nextAttackAt;
        private EnemyState observedBoss;
        private bool defeatedPresented;

        public bool IsTelegraphing => telegraphing;

        private void Awake()
        {
            PresentTelegraph(false);
        }

        private void Start() => ObserveAuthoritativeBoss();

        private void OnEnable() => ObserveAuthoritativeBoss();

        private void OnDisable() => StopObservingBoss();

        private void OnDestroy() => StopObservingBoss();

        private void ObserveAuthoritativeBoss()
        {
            // GameSessionBehaviour.Awake can run after our OnEnable; Start retries safely.
            if (session == null || session.Session == null) return;
            EnemyState boss = session.Session.Boss.Boss;
            if (observedBoss != boss)
            {
                StopObservingBoss();
                observedBoss = boss;
                observedBoss.Defeated += PresentDefeat;
            }
            if (boss.IsDefeated) PresentDefeat();
        }

        private void StopObservingBoss()
        {
            if (observedBoss == null) return;
            observedBoss.Defeated -= PresentDefeat;
            observedBoss = null;
        }

        private void PresentDefeat()
        {
            if (defeatedPresented) return;
            defeatedPresented = true;
            CancelTelegraph();
            // Presentation only: retain boss root, collision, health and result authority.
            foreach (Renderer visual in GetComponentsInChildren<Renderer>(true))
            {
                if (telegraphVisual != null &&
                    visual.transform.IsChildOf(telegraphVisual.transform)) continue;
                visual.enabled = false;
            }
        }

        private void Update()
        {
            if (session == null || session.IsTerminal || session.Phase != RunPhase.Boss)
            {
                CancelTelegraph();
                return;
            }

            if (telegraphing)
            {
                if (Time.time < resolveAt) return;

                telegraphing = false;
                PresentTelegraph(false);
                ResolveTelegraphedAttack();
                nextAttackAt = Time.time + attackCadence;
                return;
            }

            if (Time.time < nextAttackAt) return;

            telegraphing = true;
            resolveAt = Time.time + telegraphDuration;
            PresentTelegraph(true);
        }

        public void StartEncounter()
        {
            if (session != null) session.StartBoss();
        }

        public bool ArmyAttack()
        {
            return session != null && session.ArmyAttackBoss(armyDamagePerHelper);
        }

        public bool SnowballAttack()
        {
            return session != null && session.SnowballBoss(snowballDamage);
        }

        public void ResolveTelegraphedAttack()
        {
            if (session != null) session.ApplyBossAttack(telegraphedHelperDamage);
        }

        private void CancelTelegraph()
        {
            if (!telegraphing) return;
            telegraphing = false;
            PresentTelegraph(false);
        }

        private void PresentTelegraph(bool visible)
        {
            if (telegraphVisual != null && telegraphVisual.activeSelf != visible)
                telegraphVisual.SetActive(visible);
        }
    }
}
