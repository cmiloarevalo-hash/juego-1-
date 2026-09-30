> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# Research Gates / Strategic Rationales

All statuses: DRAFT. Supervisor status: PENDING.

## RG-001 — Unity/editor and package baseline
DECISION POINT: exact supported Unity release and versions for URP, Input System, AI Navigation, Cinemachine, Burst/Jobs/Entities (if used), profiling packages.
WHY CURRENT RESEARCH: mutable APIs/package compatibility affect architecture.
CONSTRAINTS: mobile iOS/Android; no product code yet.
EVIDENCE: UNITY-001..016; package manifests from REP-002 and other comparables.
OPTIONS: current supported Unity release family with conservative packages; omit optional packages unless requirements justify them.
PROPOSED APPROACH: refresh official support/package compatibility immediately before ADR #16; pin exact versions and links.
RISKS: API migration, package incompatibility, unsupported device/backend.
SUPERVISOR VERIFICATION: PENDING.
RATIONALE STATUS: DRAFT.

## RG-002 — crowd simulation architecture
DECISION POINT: GameObject central loop vs Jobs/Burst vs ECS/DOTS; movement backend/neighbor partition.
EVIDENCE: REP-002..007; EXP-CROWD/PERF proposed experiments.
OPTIONS: central GameObject/data loop; Jobs/Burst acceleration; ECS/DOTS.
PROPOSED APPROACH: specify behavior independent of backend; implement benchmark spike before committing to ECS/DOTS. Prefer minimum-complexity architecture that meets measured requirements.
UNCERTAINTY: no target-device results.
STATUS: DRAFT / PENDING.

## RG-003 — rendering/animation representation
DECISION POINT: ordinary renderers/Animator vs instanced/GPU animation/LOD variants.
EVIDENCE: UNITY-008/009; EXP-PERF-004/005.
PROPOSED APPROACH: preserve rendering abstraction in specification; benchmark actual representative art before material ADR.
STATUS: DRAFT / PENDING.

## RG-004 — navigation
DECISION POINT: NavMesh per unit/shared paths vs custom kinematic/slots/grid.
EVIDENCE: REP-002/003/005/006/007; #6.
PROPOSED APPROACH: runner traversal should not require independent global pathfinding unless level/combat requirements demonstrate it; benchmark local movement alternatives.
STATUS: DRAFT / PENDING.

## RG-005 — persistence/backend
DECISION POINT: local versioned persistence only vs cloud/backend.
EVIDENCE: UNITY-014..016; #11.
PROPOSED APPROACH: specify local persistence baseline; cloud/backend is not authorized/inferred and requires explicit product scope/integration/security requirements.
STATUS: DRAFT / PENDING.

## RG-006 — content loading/Addressables
DECISION POINT: direct references/scenes vs Addressables.
EVIDENCE: UNITY-013.
PROPOSED APPROACH: do not add Addressables dependency absent remote/dynamic content or build-size/content-management requirement.
STATUS: DRAFT / PENDING.

## RG-007 — camera package
DECISION POINT: simple custom follow vs Cinemachine.
EVIDENCE: UNITY-012; #10.
PROPOSED APPROACH: specify framing behavior, not package; choose package during ADR after exact Unity baseline.
STATUS: DRAFT / PENDING.
