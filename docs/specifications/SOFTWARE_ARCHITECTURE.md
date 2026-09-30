# Software Architecture — Christmas Prototype Freeze
Status: FROZEN boundaries; backend choices intentionally measurement-driven.

ARCH-001 [FROZEN] Layers/boundaries: Input → Run → Army Domain → Formation/Movement → Gate → Obstacle/Tool → Combat → Boss → Result; Presentation/Localization observe domain state; Instrumentation crosses boundaries without becoming authority.
ARCH-002 [FROZEN] Logical army count/domain state does not depend on GameObject identity.
ARCH-003 [FROZEN] Formation target generation is separable from movement/representation backend.
ARCH-004 [FROZEN] Representation lifecycle behind acquire/release/reset contract; pooling implementation replaceable.
ARCH-005 [FROZEN] Combat candidate query/targeting behind replaceable contract; damage/death domain remains backend-independent.
ARCH-006 [FROZEN] Authored immutable definitions separated from runtime mutable state.
ARCH-007 [FROZEN] Run coordinator owns terminal transition ordering and exactly-once Result.
ARCH-008 [FROZEN] Camera, animation, VFX, audio and presenters are not gameplay authority.
ARCH-009 [FROZEN] Localization boundary supplies ES/EN player-facing strings; art SHALL NOT require baked language-specific critical text.
ARCH-010 [FROZEN] Instrumentation seams expose army count, representation count, lifecycle/query metrics and timing markers required by X46.
ARCH-011 [FROZEN] Minimal persistence, if used, is limited to prototype settings/localization and non-metagame convenience; gameplay run state is transient. Kingdom/economy/progression persistence OUT_OF_SCOPE.

## Components
Input Intent Provider; Run Coordinator; Army State; Formation Solver; Movement Backend; Gate Resolver; Obstacle/Tool Domain; Combat World/Target Query; Damage/Death; Boss Encounter; Result Builder; Presentation; Localization; optional minimal Settings Repository; Instrumentation.

## Intentionally not frozen before X46
[MEASUREMENT_DERIVED] ECS vs Jobs/Burst vs central data manager vs GameObject-per-unit; exact movement backend; spatial query; pooling/preallocation strategy; rendering/animation representation. Spike may choose these without changing frozen domain contracts.

Historical ADR-001..007 remain evidence/proposals unless a later Supervisor decision explicitly accepts them; this freeze accepts only boundaries stated above.
