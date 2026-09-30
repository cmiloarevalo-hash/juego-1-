# IMPLEMENTATION_INVENTORY
Status: CURRENT_SUPPORTING responsibility map, repaired by Issue #83. **No product code is authorized by this inventory.**
All game-specific entries are NEW unless later provenance approval explicitly changes a reuse row.

## NC-001 Input Intent
Normalize touch/editor/test input to lateral/path-choice intent. REQ: SRS-INPUT-001, GAME-INPUT-001. TEST: VER-INPUT-001.

## NC-002 Run Coordinator
Own run phase, deterministic same-frame ordering, terminal Victory/Defeat and exactly-once Result. REQ: GAME-RUN-001, SRS-RESULT-001, TECH-TIME-001. TEST: VER-VICTORY/DEFEAT.

## NC-003 Stage Definition / Validator
Represent exactly one current village/workshop stage with stable IDs and the frozen content sequence. Extra stages are DEFERRED. REQ: DATA-STAGE-001, GAME-STAGE-001, TECH-ID-001.

## NC-004 Army State
Authoritative non-negative helper count independent of presentation. Helpers protect Santa; zero is immediate defeat. REQ: SRS-ARMY/HEALTH, GAME-ARMY/HEALTH/DEFEAT. TEST: VER-ARMY/ZERO.

## NC-005 Formation Solver
Generate formation targets independently of movement representation. Backend and numeric capacity are MEASUREMENT_DERIVED. REQ: SRS-FORM-001, ARCH-003. TEST: VER-CAP/X46 when authorized.

## NC-006 Movement Backend
Move representation toward formation targets. Exact GameObject/central/Jobs/Burst/ECS choice is not selected before accepted X46 evidence.

## NC-007 Gate Resolver
Apply stable-ID gate transaction at most once. Operations are only +N or ×N with positive integer N; no rounding path exists. REQ: SRS-GATE, GAME-GATE. TEST: VER-GATE-*.

## NC-008 Representation Lifecycle
Acquire/release/reset visual representations without owning logical army state. Exact pooling/preallocation strategy is measurement-derived. REQ: ARCH-004, TECH-LIFE-001. TEST: X46 lifecycle correctness when authorized.

## NC-009 Obstacle / Tool Domain
Own avoidable obstacle and hammer interaction. Destruction is authored state/mesh/pre-broken swap; runtime fracture OUT_OF_SCOPE. REQ: SRS-OBS/TOOL, GAME-HAMMER. TEST: VER-HAMMER.

## NC-010 Combat / Target / Damage / Death
Authoritative original targeting/attack/damage/death contracts. Presentation/animation cannot create gameplay damage. Snowball feeds this domain. REQ: SRS-COMBAT, GAME-COMBAT/DEATH/SNOW. TEST: VER-SNOW/COMBAT.

## NC-011 Boss Encounter
Mandatory final one-phase boss; readable telegraphs; army participates; no adds/multiphase. REQ: SRS-BOSS, GAME-BOSS. TEST: VER-BOSS/VICTORY.

## NC-012 Result
Immutable exactly-once terminal snapshot sufficient for UI/verification. No strategic reward transaction. REQ: SRS-RESULT, DATA-RESULT. TEST: VER-VICTORY/DEFEAT.

## NC-013 Presentation / HUD / Camera
Observe domain state only. Gate semantics must be color-independent and mobile-readable; detailed camera/HUD/art requirements remain blocked by VUX-GAP-* until Supervisor resolution. REQ: ARCH-008, SRS-UX/ART/ORIG.

## NC-014 Localization
Provide ES/EN critical strings with Spanish glyph/overflow validation; avoid baked language-critical art. REQ: SRS-LOC, DATA-LOC, ARCH-009. TEST: VER-LOC-ES/EN.

## NC-015 Instrumentation
Expose counters/profiler markers for Stage 2 evidence without becoming gameplay authority. REQ: TECH-LOG, ARCH-010.

## NC-016 Optional Minimal Settings
Only if exposed: language/audio/control preferences. No progression/economy/profile/cloud save. REQ: ARCH-011, DATA-SETTINGS, TECH-PERSIST.

## Completeness/scope rule
A future component must map to current SRS/GAME/ARCH/TECH/DATA requirements and verification or trigger an explicit scope/traceability decision. Historical NC IDs/requirements for progression/economy/save are superseded for this prototype.
