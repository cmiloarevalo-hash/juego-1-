using System;
using ChristmasRunner.Gameplay.Boss;
using ChristmasRunner.Gameplay.Combat;
using ChristmasRunner.Gameplay.Gates;
using ChristmasRunner.Gameplay.Integration;
using ChristmasRunner.Gameplay.Localization;
using ChristmasRunner.Gameplay.Obstacles;
using ChristmasRunner.Gameplay.Run;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    /// <summary>Unity-facing composition root. Domain authority remains in GameSession.</summary>
    public sealed class GameSessionBehaviour : MonoBehaviour
    {
        [SerializeField, Min(1)] private int initialHelpers = 5;
        [SerializeField, Min(1)] private int bossHealth = 20;
        [SerializeField] private Language language = Language.ES;

        public GameSession Session { get; private set; }
        public event Action<RunResult> ResultReady;

        private void Awake()
        {
            Session = new GameSession(initialHelpers, bossHealth);
            Session.Localization.SetLanguage(language);
            Session.ResultReady += ForwardResult;
        }

        private void OnDestroy()
        {
            if (Session != null) Session.ResultReady -= ForwardResult;
        }

        public void CompleteOnboarding() => Session.CompleteOnboarding();
        public bool ApplyAddGate(string stableId, int operand) => Session.ChooseGate(stableId, GateOperation.Add, operand);
        public bool ApplyMultiplyGate(string stableId, int operand) => Session.ChooseGate(stableId, GateOperation.Multiply, operand);
        public void HitObstacle(int helperDamage) => Session.HitAvoidableObstacle(helperDamage);
        public bool UseHammer(BreakableObstacle obstacle) => Session.UseHammer(obstacle);
        public bool SnowballEnemy(EnemyState enemy, int damage) => Session.SnowballEnemy(enemy, damage);
        public void StartBoss() => Session.StartBoss();
        public bool ArmyAttackBoss(int damagePerHelper) => Session.Boss.ArmyAttack(damagePerHelper);
        public bool SnowballBoss(int damage) => Session.Boss.SnowballAttack(damage);
        public void ApplyBossAttack(int helperDamage) => Session.Boss.ApplyTelegraphedAttack(helperDamage);
        public string Localize(string key) => Session.Localization.Get(key);
        public int HelperCount => Session.Run.Army.Count;
        public RunPhase Phase => Session.Run.Phase;

        private void ForwardResult(RunResult result) => ResultReady?.Invoke(result);
    }
}
