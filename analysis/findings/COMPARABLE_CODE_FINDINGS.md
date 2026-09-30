> **DOCUMENTATION CLASSIFICATION: REFERENCE_ONLY / HISTORICAL_EVIDENCE.**
> This material is evidence, not target-product requirements or reuse permission. Current product authority is `docs/DOCUMENTATION_AUTHORITY_MAP.md`; Issue #83 global hold applies.

# Findings — Comparable Code Analysis

Work Item: #5

## CA-F-001 — crowd update topology is an independent design dimension
**CODE OBSERVATION:** REP-002 and REP-006 centralize iteration in manager/simulator updates. REP-003 also centrally iterates pedestrians. REP-004/REP-007 contain per-object FixedUpdate paths.

**INFERENCE:** later architecture comparison should evaluate update topology separately from movement algorithm; steering vs NavMesh vs grid does not itself dictate MonoBehaviour-per-agent updates.

## CA-F-002 — spatial acceleration materially changes neighbor-query structure
**CODE OBSERVATION:** REP-003 maintains per-grid-cell pedestrian lists and queries neighboring cells. REP-002 avoidance and REP-004 boid/social-force paths scan broad/all agent collections; REP-006 agent avoidance also scans all agents while obstacle avoidance uses a bounded grid region.

**INFERENCE:** #6/#9 should compare spatial partitioning against all-pairs neighbor checks. No performance winner is asserted without experiments.

## CA-F-003 — spawn lifecycle alternatives are evidenced
**CODE OBSERVATION:** REP-001 mutates an existing GameObject roster through SetActive. REP-002/004/006/007 instantiate agents in their demonstrated generators; REP-004 also destroys expired cloned paths.

**INFERENCE:** pooling/preallocation is directly relevant to gate-driven army mutation and mobile allocation pressure, but capacity policy and memory tradeoffs require #7/#9.

## CA-F-004 — formation geometry can be decoupled from locomotion
**CODE OBSERVATION:** REP-005 defines FormationGridPoint targets and abstract FormationAI/IFormationUnit interfaces with concrete NavMesh and A* integrations.

**INFERENCE:** #6 can compare slot/grid formation logic independently from the locomotion backend.

## CA-F-005 — pathfinding alternatives carry distinct scaling structures
**CODE OBSERVATION:** REP-002 delegates global route calculation to Unity NavMesh. REP-003 builds a shared Dijkstra field. REP-006 supports A*/bidirectional A* requests. REP-007 implements per-query grid A* with linear-list operations.

**INFERENCE:** a shared flow/distance field may amortize common-goal routing, whereas per-agent path queries offer individualized routes; suitability for the target must be measured under target crowd sizes rather than assumed.

## CA-F-006 — complete runner flow remains only partially evidenced
**UNKNOWN:** none of the deeply inspected fixed refs provides a fully code-verified Input→Crowd→Gate→Combat→Result chain. REP-001 is closest functionally but method-level evidence currently verifies gate arithmetic/army mutation and persistence only. This gap is explicit and downstream mechanics research must not invent the missing ownership.
