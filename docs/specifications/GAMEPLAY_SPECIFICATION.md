# Gameplay Specification

GAME-INPUT-001 Player lateral intent SHALL be continuously interpretable during traversal except explicit locked transitions.
GAME-RUN-001 Run state sequence: Initialize -> Traversal -> optional Gate/Obstacle/Combat segments -> End/Result -> Reward transition.
GAME-GATE-001 Gate definition SHALL include operation type/value, stable ID, presentation label and consumed state.
GAME-GATE-002 Gate arithmetic SHALL define integer rounding, min/max and overflow behavior before implementation; current values PENDING Supervisor/product decision.
GAME-GATE-003 Gate application SHALL be idempotent.
GAME-ARMY-001 Logical army count SHALL never diverge silently from representation; lifecycle failures SHALL be detectable.
GAME-FORM-001 Formation SHALL recompute slot topology after growth/shrink/death.
GAME-FORM-002 Corridor compression/turning SHALL have explicit behavior; exact layout algorithm remains ADR PENDING.
GAME-COMBAT-001 Target acquisition SHALL define candidates, priority, deterministic tie-break, stickiness/invalidation.
GAME-COMBAT-002 Damage SHALL be applied by authoritative gameplay state, not animation timing alone.
GAME-DEATH-001 Death SHALL be idempotent and release target/formation/representation ownership once.
GAME-BOSS-001 Boss encounters are OPTIONAL/PENDING product decision; if present, explicit phases/telegraphs/damageability/victory rules are required.
GAME-RESULT-001 Result SHALL snapshot outcome once and stop post-result gameplay mutation.
GAME-REWARD-001 Reward transaction SHALL be idempotent.

Evidence: #3,#6,#7,#8,#10,#11. Proprietary Top Lords formulas/algorithms remain UNKNOWN.
