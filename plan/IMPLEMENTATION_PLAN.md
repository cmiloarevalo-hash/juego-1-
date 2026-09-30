# IMPLEMENTATION_PLAN
Status: CURRENT_SUPPORTING planning aid only. **NOT AUTHORIZATION.**
Issue #83 global hold overrides every sequence below until `DOCUMENTATION_GATE_ACCEPTED`.

## Preconditions before any product implementation
P0. Documentation gate #83 accepted by Supervisor.
P1. Canonical product spec remains PR #71 HEAD `09061b4ba372de41fb142ab4c43f1b4302f58083` unless a later explicit decision supersedes it.
P2. Bounded Stage 2 technical readiness is completed/accepted as applicable: bootstrap/build evidence and X46 measurements. No benchmark value may be inferred.
P3. Required VUX gaps for the product surface being implemented are explicitly resolved; see `VISUAL_UX_CONTENT_SPECIFICATION.md`.
P4. Any external asset/code item has exact provenance/license approval before import.
P5. Separate implementation Work Item authorization exists.

## Future product sequence after the gates
### IMP-01 Domain foundations
Run phases, stable IDs, deterministic terminal ordering, exactly-once result contracts. Requirements: ARCH-001/006/007, TECH-TIME/ID.

### IMP-02 Input intent
Normalized touch/test input feeding run/movement intent. Requirements: SRS-INPUT-001, GAME-INPUT-001.

### IMP-03 Single-stage definition and validation
Exactly one village/workshop vertical-slice definition with stable IDs and ordered onboarding → army growth → +/× choice → obstacle → hammer → snowball/combat → boss → result. No additional stages or metagame.

### IMP-04 Army domain
Authoritative non-negative helper count; army protects Santa; zero immediately defeats. No independent Santa HP baseline.

### IMP-05 Formation/movement backend
Preserve frozen domain contract. Exact runtime backend/capacity follows accepted X46 evidence; do not choose ECS/Jobs/GameObject strategy without measurements.

### IMP-06 Gate resolver
Only positive-integer +N and ×N; stable gate ID; exactly-once mutation; no fractional/percentage/subtractive/conditional gate families.

### IMP-07 Representation lifecycle
Acquire/release/reset boundary. Exact pooling/preallocation strategy follows X46 evidence; SST remains REFERENCE_ONLY unless separately approved.

### IMP-08 Obstacle/tool domain
Avoidable obstacle; toy-maker hammer uses authored state/mesh/pre-broken transition. Runtime mesh fracture is OUT_OF_SCOPE.

### IMP-09 Combat and snowball
Original authoritative target/attack/damage/death domain; snowball is ranged/combat verb. Presentation is not damage authority.

### IMP-10 Mandatory final boss
One phase, readable/telegraphed, army participates, no adds/multiphase. Boss defeat produces Victory/result exactly once.

### IMP-11 Presentation/localization
Only after relevant VUX blocking decisions are resolved. Must satisfy originality, mobile readability, gate multi-cue semantics, ES+EN and accepted camera/HUD/animation/VFX/audio quality requirements.

### IMP-12 Verification and acceptance
Execute current VER-* suite, traceability, provenance/originality and device/performance gates. Product cannot be accepted by functional correctness alone while a VUX blocking decision remains unresolved.

## Explicitly absent from this prototype plan
- iOS;
- kingdom/metagame/economy/upgrades/roster/cloud progression;
- optional boss;
- extra stages/forest/ice fortress;
- extra gate families or tools;
- runtime mesh fracture;
- Play Store/commercial release work.

## Tuning and measurement
Army capacity, backend, CPU/GPU/memory/thermal values derive from executed evidence. Damage/range/cooldown/count/spacing and stage duration/pacing numbers are tunable/playtest-derived inside frozen semantics.

## Provenance
Game-specific runner/army/gate/combat/boss/level logic is NEW. External assets/code require exact snapshot/license/provenance and explicit permitted classification before import.
