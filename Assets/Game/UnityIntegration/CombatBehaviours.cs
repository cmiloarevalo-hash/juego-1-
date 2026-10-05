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

    public sealed class SnowballAttackBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField, Min(1)] private int damage = 1;

        public bool Attack(EnemyBehaviour enemy)
        {
            return session != null && enemy != null && session.SnowballEnemy(enemy.State, damage);
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
}
