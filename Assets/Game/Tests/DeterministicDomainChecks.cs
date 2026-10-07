#if CHRISTMAS_RUNNER_DETERMINISTIC_TESTS
using System;
using ChristmasRunner.Gameplay.Army;
using ChristmasRunner.Gameplay.Combat;
using ChristmasRunner.Gameplay.Gates;
using ChristmasRunner.Gameplay.Integration;
using ChristmasRunner.Gameplay.Obstacles;
using ChristmasRunner.Gameplay.Run;

namespace ChristmasRunner.Tests
{
    internal static class DeterministicDomainChecks
    {
        private static int _assertions;

        public static int Main()
        {
            VerifyLegalPhaseFsm();
            VerifyGateOverflowCapacityAndConsumption();
            VerifyTerminalImmutabilityAndExactlyOnceResult();
            VerifyRunResultIdentity();
            VerifyHammerSessionAuthority();

            Console.WriteLine("DETERMINISTIC_DOMAIN_CHECKS=PASS");
            Console.WriteLine("ASSERTIONS=" + _assertions);
            return 0;
        }

        private static void VerifyLegalPhaseFsm()
        {
            var run = new RunCoordinator(5, "level-1", "run-fsm");
            int results = 0;
            run.ResultProduced += _ => results++;

            Expect(!run.BeginBoss(), "Boss cannot start from onboarding.");
            Expect(!run.Victory(), "Victory cannot occur before boss.");
            Expect(run.Phase == RunPhase.Onboarding, "Invalid transitions preserve onboarding.");
            Expect(run.BeginTraversal(), "Onboarding transitions to traversal.");
            Expect(!run.BeginTraversal(), "Traversal cannot be re-entered.");
            Expect(run.BeginBoss(), "Traversal transitions to boss.");
            Expect(!run.BeginTraversal(), "Boss cannot transition back to traversal.");
            Expect(run.Victory(), "Boss transitions to victory.");
            Expect(run.IsTerminal, "Victory is terminal.");
            Expect(run.Army.IsFrozen, "Army freezes at terminal result.");
            Expect(!run.Defeat(), "Terminal outcome cannot be replaced.");
            Expect(results == 1, "Result is produced exactly once.");
        }

        private static void VerifyGateOverflowCapacityAndConsumption()
        {
            var resolver = new GateResolver();
            var overflowArmy = new ArmyState(int.MaxValue);

            Expect(overflowArmy.TechnicalCapacity == null, "No unmeasured production capacity is implied.");
            Expect(!resolver.TryApply("overflow-add", GateOperation.Add, 1, overflowArmy), "Overflowing add fails safely.");
            Expect(overflowArmy.Count == int.MaxValue, "Overflowing add leaves army unchanged.");

            overflowArmy.ApplyDamage(10);
            Expect(resolver.TryApply("overflow-add", GateOperation.Add, 5, overflowArmy), "Failed gate was not consumed and can succeed later.");
            Expect(overflowArmy.Count == int.MaxValue - 5, "Successful retry applies exact add semantics.");

            var multiplyArmy = new ArmyState(1500000000);
            Expect(!resolver.TryApply("overflow-multiply", GateOperation.Multiply, 2, multiplyArmy), "Overflowing multiply fails safely.");
            multiplyArmy.ApplyDamage(1000000000);
            Expect(resolver.TryApply("overflow-multiply", GateOperation.Multiply, 2, multiplyArmy), "Failed multiply gate was not consumed.");
            Expect(multiplyArmy.Count == 1000000000, "Successful retry applies exact multiply semantics.");

            var cappedArmy = new ArmyState(8, 10);
            Expect(cappedArmy.TechnicalCapacity == 10, "Technical capacity is configurable when evidence supplies a value.");
            Expect(resolver.TryApply("capacity-add", GateOperation.Add, 5, cappedArmy), "Gate succeeds under configured capacity policy.");
            Expect(cappedArmy.Count == 10, "Configured technical capacity bounds authoritative growth.");
            Expect(!resolver.TryApply("capacity-add", GateOperation.Add, 5, cappedArmy), "Successful gate is consumed exactly once.");
        }

        private static void VerifyTerminalImmutabilityAndExactlyOnceResult()
        {
            var session = new GameSession(5, 10, "level-1", "run-terminal");
            int results = 0;
            session.ResultReady += _ => results++;

            Expect(session.CompleteOnboarding(), "Session enters traversal.");
            Expect(session.StartBoss(), "Boss starts only from traversal.");
            session.ApplyBossAttack(5);

            Expect(session.Run.Phase == RunPhase.Defeat, "Zero helpers immediately produce defeat.");
            Expect(session.Run.Army.Count == 0, "Defeat preserves zero-helper state.");
            Expect(results == 1, "Defeat result is emitted exactly once.");

            int bossHealth = session.Boss.Boss.Health;
            var obstacle = new BreakableObstacle();
            var enemy = new EnemyState(3);

            Expect(!session.ChooseGate("post-terminal-gate", GateOperation.Add, 10), "Gate mutation is blocked after terminal.");
            session.HitAvoidableObstacle(1);
            Expect(!session.UseHammer(obstacle), "Hammer mutation is blocked after terminal.");
            Expect(!session.SnowballEnemy(enemy, 1), "Enemy mutation is blocked after terminal.");
            Expect(!session.ArmyAttackBoss(1), "Army boss attack is blocked after terminal.");
            Expect(!session.SnowballBoss(1), "Snowball boss attack is blocked after terminal.");
            session.ApplyBossAttack(1);
            Expect(!session.Run.Army.Add(10), "Direct army growth is frozen after terminal.");
            session.Run.Army.ApplyDamage(1);

            Expect(session.Run.Army.Count == 0, "Army remains immutable after terminal.");
            Expect(session.Boss.Boss.Health == bossHealth, "Boss health remains unchanged through session after terminal.");
            Expect(!obstacle.IsBroken, "Obstacle remains unchanged after terminal.");
            Expect(enemy.Health == 3, "Enemy remains unchanged after terminal.");
            Expect(results == 1, "Post-terminal calls do not emit another result.");
        }

        private static void VerifyRunResultIdentity()
        {
            var session = new GameSession(3, 3, "level-1", "run-identity");
            Expect(session.CompleteOnboarding(), "Identity run enters traversal.");
            Expect(session.StartBoss(), "Identity run enters boss.");
            Expect(session.SnowballBoss(3), "Boss can be defeated by authorized snowball path.");
            Expect(session.FinalResult.HasValue, "Victory produces final result.");

            RunResult result = session.FinalResult.Value;
            Expect(result.StageId == "level-1", "Result carries stable stage identity.");
            Expect(result.RunId == "run-identity", "Result carries per-run identity.");
            Expect(result.Outcome == RunPhase.Victory, "Result carries terminal victory outcome.");
            Expect(result.HelpersRemaining == 3, "Result snapshots helpers remaining.");
        }

        private static void VerifyHammerSessionAuthority()
        {
            var session = new GameSession(2, 3, "level-1", "run-hammer");
            var obstacle = new BreakableObstacle();

            Expect(session.CompleteOnboarding(), "Hammer run enters traversal.");
            Expect(session.UseHammer(obstacle), "GameSession authorizes first hammer break.");
            Expect(obstacle.IsBroken, "Authorized hammer break mutates authored obstacle state.");
            Expect(!session.UseHammer(obstacle), "Hammer break remains idempotent.");
        }

        private static void Expect(bool condition, string message)
        {
            _assertions++;
            if (!condition) throw new InvalidOperationException(message);
        }
    }
}
#endif
