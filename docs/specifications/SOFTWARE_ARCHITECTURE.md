# Software Architecture

Status: PROPOSED DRAFT; RG-001..007 PENDING.

ARCH-001 Separate layers: Input Adapter -> Run/Level Orchestrator -> Army Domain -> Formation/Movement -> Gate Domain -> Combat Domain -> Result Domain -> Progression/Persistence; presentation observes domain state.
ARCH-002 Logical army/domain state SHALL not depend on GameObject identity.
ARCH-003 Formation target generation SHALL be separable from movement backend. [REP-005]
ARCH-004 Representation lifecycle SHALL be behind acquire/release/reset contract so preallocation/pooling strategy can change after profiling.
ARCH-005 Target query SHALL be behind a combat candidate-query contract so spatial implementation can change.
ARCH-006 Immutable authored definitions SHALL be separated from runtime mutable state.
ARCH-007 Persistence SHALL serialize explicit versioned DTO/domain snapshots, not scene object references.
ARCH-008 Camera and animation SHALL be presentation systems, not gameplay authority.
ARCH-009 External Unity packages SHALL be pinned only after RG-001 refresh.

Candidate component boundaries, not premature classes: Input Intent Provider; Run Coordinator; Level Definition Provider; Army State; Formation Solver; Movement Backend; Gate Resolver; Representation Pool; Combat World/Target Query; Damage/Health; Result Builder; Progression Service; Save Repository; Camera Presenter; Unit Presenter.
