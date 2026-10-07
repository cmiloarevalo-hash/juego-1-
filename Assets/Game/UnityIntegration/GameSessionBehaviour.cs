using System;
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

        public bool CompleteOnboarding() => Session != null && Session.CompleteOnboarding();
        public bool RecruitHelpers(int helperCount) => Session != null && Session.RecruitHelpers(helperCount);
        public bool ApplyAddGate(string stableId, int operand) => Session != null && Session.ChooseGate(stableId, GateOperation.Add, operand);
        public bool ApplyMultiplyGate(string stableId, int operand) => Session != null && Session.ChooseGate(stableId, GateOperation.Multiply, operand);
        public void HitObstacle(int helperDamage) { if (Session != null) Session.HitAvoidableObstacle(helperDamage); }
        public bool UseHammer(BreakableObstacle obstacle) => Session != null && Session.UseHammer(obstacle);
        public bool SnowballEnemy(EnemyState enemy, int damage) => Session != null && Session.SnowballEnemy(enemy, damage);
        public bool ArmyAttackEnemy(EnemyState enemy, int damagePerHelper) => Session != null && Session.ArmyAttackEnemy(enemy, damagePerHelper);
        public bool StartBoss() => Session != null && Session.StartBoss();
        public bool ArmyAttackBoss(int damagePerHelper) => Session != null && Session.ArmyAttackBoss(damagePerHelper);
        public bool SnowballBoss(int damage) => Session != null && Session.SnowballBoss(damage);
        public void ApplyBossAttack(int helperDamage) { if (Session != null) Session.ApplyBossAttack(helperDamage); }
        public string Localize(string key) => Session != null ? Session.Localization.Get(key) : key;
        public int HelperCount => Session != null ? Session.Run.Army.Count : 0;
        public RunPhase Phase => Session != null ? Session.Run.Phase : RunPhase.Onboarding;
        public bool IsTerminal => Session != null && Session.Run.IsTerminal;
        public RunResult? FinalResult => Session == null ? (RunResult?)null : Session.FinalResult;

        private void ForwardResult(RunResult result) => ResultReady?.Invoke(result);
    }
}
