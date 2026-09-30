# IMPLEMENTATION_INVENTORY

All entries: REUSE STATUS = NEW / original implementation. Reason: #14 selects no external COPY/ADAPT material.

## NC-001 Input Intent
PURPOSE/RESPONSIBILITY: normalize touch/editor/test input into lateral/path-choice intent. REQUIREMENTS: SRS-INPUT-001,GAME-INPUT-001. INPUTS: device/test events. OUTPUTS: normalized intent. INTERFACES: consumer Run/Movement. DEPENDENCIES: Unity input adapter PENDING RG-001. DATA OWNERSHIP: transient input. PERFORMANCE: allocation-free hot path target, measured. TEST: scripted gestures/deadzone/cancel. RESEARCH: #6,TL-001/002. ADR: RG-001. RISKS: package/API/version, gesture ambiguity.

## NC-002 Run/Level Orchestrator
RESPONSIBILITY: deterministic segment/run state transitions. REQ: SRS-RUN-001,SRS-LEVEL-001,GAME-RUN-001. INPUT: level definition/result events. OUTPUT: active segment/run phase. INTERFACES: army/gate/combat/result/camera. DATA: run-local. TEST: segment order/retry/end. RESEARCH: #10. RISKS: same-frame ordering.

## NC-003 Level Definition + Validation
RESPONSIBILITY: structured immutable authored levels and validation. REQ: LEVEL-CAND/SRS-LEVEL-001,VER-LEVEL-001. INPUT: authored data. OUTPUT: validated runtime definition. DEP: ScriptableObject candidate. TEST: duplicate/missing/malformed. RESEARCH #10. RISKS: scene/data drift.

## NC-004 Army Domain
RESPONSIBILITY: authoritative logical army membership/count/state. REQ: SRS-ARMY-001,GAME-ARMY-001. INPUT: gate/death/reset. OUTPUT: mutation events/snapshot. INTERFACES: formation/representation/combat/result. TEST: arithmetic/count invariants. RESEARCH #7/#8. RISKS: divergence from presentation.

## NC-005 Formation Solver
RESPONSIBILITY: generate stable target slots/topology independent of movement backend. REQ: SRS-FORM-001,GAME-FORM-001/002. INPUT: army members, leader frame, corridor constraints. OUTPUT: target slots/assignments. DEP: movement backend. PERF: EXP-CROWD. TEST: growth/shrink/compression/stability. RESEARCH REP-005/#6. RISKS: reassignment crossing/cost.

## NC-006 Movement Backend
RESPONSIBILITY: move representations toward formation targets with bounded local correction. REQ: ARCH-003,PERF-004. INPUT: target/constraints. OUTPUT: transforms/positions. DEP: backend decision RG-002/004. TEST: deterministic path/collision cases + perf. RISKS: unmeasured scale.

## NC-007 Gate Resolver
RESPONSIBILITY: detect/validate/apply exactly-once authored army mutation. REQ: SRS-GATE-001,GAME-GATE-001..003. INPUT: gate crossing + army state. OUTPUT: mutation transaction. DEP: detection adapter. TEST: arithmetic/idempotency/overlap. RESEARCH REP-001/#7. RISKS: duplicate triggers/rounding TBD.

## NC-008 Representation Lifecycle
RESPONSIBILITY: acquire/release/reset visual unit instances independently of logical state. REQ: ARCH-004,TECH-POOL-001. INPUT: logical membership changes. OUTPUT: active presenters. DEP: pooling/preallocation decision. PERF: EXP-PERF-003. TEST: stale state/capacity/reset. RISKS: retained memory/pool exhaustion.

## NC-009 Combat World / Target Query
RESPONSIBILITY: maintain combat candidates and deterministic target policy. REQ: SRS-COMBAT-001,GAME-COMBAT-001. INPUT: combatants/spatial state. OUTPUT: target IDs. DEP: spatial query implementation. PERF: EXP-COMBAT/PERF-002. TEST: tie/no target/stickiness/death. RISKS: scaling/churn.

## NC-010 Health/Damage/Attack Domain
RESPONSIBILITY: authoritative attack timing state, damage, health, death transition. REQ: GAME-COMBAT-002,GAME-DEATH-001. INPUT: attack/damage events. OUTPUT: health/death events. TEST: simultaneous lethal/multiple attackers/cancel. RISKS: ordering.

## NC-011 Boss/Encounter Domain
RESPONSIBILITY: only if approved product scope requires boss/phases; otherwise encounter composition. REQ: GAME-BOSS-001 PENDING. INPUT/OUTPUT: encounter state/events. TEST: phase/victory. RISKS: product decision pending.

## NC-012 Result Builder
RESPONSIBILITY: exactly-once immutable run outcome snapshot. REQ: SRS-RESULT-001,GAME-RESULT-001. INPUT: run/combat/army outcome. OUTPUT: ResultSnapshot. TEST: double emission/simultaneous final death. RISKS: ordering.

## NC-013 Progression/Economy Domain
RESPONSIBILITY: validate/apply rewards, upgrades, unlocks, balances. REQ: SRS-PROG-001,GAME-REWARD-001,DATA-UPGRADE. INPUT: result + definitions. OUTPUT: profile transaction. TEST: insufficient funds/caps/prereq/idempotency. RESEARCH #11. RISKS: product balance TBD.

## NC-014 Save Repository + Migration
RESPONSIBILITY: versioned durable profile load/save/migrate/recovery. REQ: SRS-SAVE-001,DATA-SAVE-001. INPUT: profile snapshot. OUTPUT: loaded profile/status. DEP: local persistence baseline. TEST: corrupt/interrupted/migration/reset. RESEARCH UNITY-014..016/#11. RISKS: atomic write/platform behavior.

## NC-015 Presentation: Unit/Combat/Gate/HUD
RESPONSIBILITY: render domain state/feedback without becoming authority. REQ: ARCH-008,SRS-UX-001. INPUT: domain events/state. OUTPUT: visuals/audio/haptics/UI. DEP: art/animation decisions. TEST: state synchronization/readability. RISKS: animation event coupling.

## NC-016 Camera Presenter
RESPONSIBILITY: frame army/upcoming decisions/combat and apply authored overrides. REQ: CAM-CAND-001. INPUT: leader/centroid/segment. OUTPUT: camera pose. DEP: RG-007. TEST: framing/extents/transitions. RESEARCH #10.

## NC-017 Performance Instrumentation
RESPONSIBILITY: development counters/markers and reproducible experiment harness hooks. REQ: TECH-LOG-001,PERF-002..009. INPUT: runtime metrics. OUTPUT: profiler markers/counters/log metadata. TEST: capture provenance. RESEARCH #9.

## NC-018 Editor Authoring/Validation Tools
RESPONSIBILITY: create/inspect/validate level/data definitions efficiently. REQ: AUTHOR-CAND-001,VER-LEVEL-001. INPUT: assets/scenes. OUTPUT: validation diagnostics. DEP: Unity editor API exact version. TEST: malformed fixtures. RESEARCH #10.

## Inventory completeness rule
Any future implementation component must map to one or more NC IDs or trigger a traceability/scope update. Class names and package-specific structures are intentionally deferred until ADR/implementation planning.
