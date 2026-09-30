# Gameplay Specification — Christmas Prototype Freeze
Status: FROZEN / SEMANTIC_ACCEPTED at PR #71 HEAD `09061b4ba372de41fb142ab4c43f1b4302f58083`. Authority: Issue #57 comment 5914691381.

## Run and input
GAME-RUN-001 [FROZEN] Initialize → onboarding/traversal → army/gate/obstacle/combat interactions → final boss → terminal result.
GAME-INPUT-001 [FROZEN] Player supplies continuous lateral/path-choice intent during traversal except explicit authored locks. Concrete touch sensitivity/curves are TUNABLE DATA, not semantic requirements.

## Santa / army
GAME-ARMY-001 [FROZEN] Authoritative army count is a non-negative integer. Presentation count must reconcile with it.
GAME-HEALTH-001 [FROZEN] Helpers are Santa's protection. Ordinary damaging interactions decrement helpers according to authored integer damage. No independent HP/hearts baseline.
GAME-DEFEAT-001 [FROZEN] Transition to Defeat immediately when authoritative helper count reaches 0; Santa-alone continuation is forbidden baseline.
GAME-FORM-001 [FROZEN] Growth/shrink/death triggers formation target recomputation. Exact topology/movement backend is spike-selected, not gameplay semantics.
GAME-CAP-001 [MEASUREMENT_DERIVED] Technical max army is configurable; numeric value comes from profiling.

## Gates
GAME-GATE-001 [FROZEN] Baseline operations: +N and ×N, N positive integer.
GAME-GATE-002 [FROZEN] +N: newCount = oldCount + N. ×N: newCount = oldCount × N, subject only to the measurement-derived technical capacity policy.
GAME-GATE-003 [FROZEN] Domain remains non-negative integer; fractional rounding is not applicable baseline.
GAME-GATE-004 [FROZEN] Each stable gate ID may mutate army at most once per run; duplicate/collider re-entry is no-op after consumption.
GAME-GATE-005 [OUT_OF_SCOPE] subtraction, percentage, conditional gates, fractional operands.

## Obstacles/tools
GAME-OBS-001 [FROZEN] At least one avoidable obstacle is present in the vertical slice.
GAME-HAMMER-001 [FROZEN] Toy-maker hammer is the obstacle-destruction verb. Successful interaction performs authored state/mesh swap/pre-broken representation; no runtime fracture.
GAME-SNOW-001 [FROZEN] Snowball is the ranged/combat verb. Exact damage/cooldown/range/projectile speed are TUNABLE DATA, not frozen numbers.
GAME-TOOLS-002 [OUT_OF_SCOPE] candy-cane melee, axe, sleigh/ram, additional tools.

## Combat
GAME-COMBAT-001 [FROZEN] Combat authority owns valid target, attack request, damage application and death; presentation events cannot create authoritative damage.
GAME-DEATH-001 [FROZEN] Death is idempotent and releases targeting/formation/representation ownership once.
GAME-TUNING-001 [TUNABLE DATA] enemy/helper damage values, timings, ranges, counts and encounter spacing require implementation/playtest; they cannot change frozen damage routing, zero-army defeat or boss structure.

## Boss
GAME-BOSS-001 [FROZEN] Boss is mandatory final encounter of the single stage.
GAME-BOSS-002 [FROZEN] One phase; readable telegraphed attacks; army participates; no adds and no multiple phases baseline.
GAME-BOSS-003 [FROZEN] Boss damage follows the frozen army-protection model unless an attack is explicitly non-damaging/control-only; no separate Santa HP.
GAME-VICTORY-001 [FROZEN] Boss authoritative defeated state transitions once to Victory and emits result once.
GAME-RESULT-001 [FROZEN] Victory/Defeat are mutually terminal; result snapshot/event is exactly-once; gameplay mutation stops afterward.

## Content acceptance sequence
GAME-STAGE-001 [FROZEN] One original Christmas village/workshop stage SHALL cover, in order sufficient for comprehension: onboarding/control; army growth; +/× choice; avoidable obstacle; hammer break; combat/snowball; final boss; result. Exact duration is MEASUREMENT_DERIVED by pacing/playtest.


## Onboarding / pacing acceptance resolved by Supervisor review 5370716635
GAME-PACE-001 [SUPERVISOR_ACCEPTED] Teach mandatory concepts in frozen order, initially one concept at a time: movement → army growth → +/× gate decision → avoidable obstacle → hammer break → snowball/combat → boss.
GAME-PACE-002 [SUPERVISOR_ACCEPTED] Demonstrate a mechanic in a lower-risk context before requiring it under boss pressure.
GAME-PACE-003 [SUPERVISOR_ACCEPTED] Escalate difficulty by combining already taught mechanics/tightening decisions; do not introduce unexplained rules or a new core mechanic for the first time during boss.
GAME-PACE-004 [SUPERVISOR_ACCEPTED] First-time-user evidence is required; a critical concept requiring developer verbal explanation, repeatedly misread, or preventing explanation of Victory/Defeat cause is a blocking UX defect.
GAME-PACE-005 [MEASUREMENT/PLAYTEST_DERIVED] Exact duration, spacing, damage, cooldown, counts and difficulty values remain playtest-derived.
