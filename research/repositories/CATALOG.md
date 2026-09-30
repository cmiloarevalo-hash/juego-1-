> **DOCUMENTATION CLASSIFICATION: REFERENCE_ONLY / HISTORICAL_EVIDENCE.**
> This material is evidence, not target-product requirements or reuse permission. Current product authority is `docs/DOCUMENTATION_AUTHORITY_MAP.md`; Issue #83 global hold applies.

# Comparable Repository Catalog

Work Item: #4  
Access date: 2026-09-30

This is discovery/catalog only. A repository is not marked deeply analyzed merely because its README was inspected.

| ID | Repository | Fixed ref | Engine/technical relevance | License verified | Analysis priority |
|---|---|---|---|---|---|
| REP-001 | RunControl/RunControlMain | `77ca6cf373e64754b0d74361626ec664316e1525` | Unity crowd runner; swipe, +/x gates, obstacles, end army battle | **UNKNOWN_LICENSE** | P0 gameplay-flow |
| REP-002 | ALI-P48/CrowdSimulation | `4f81451d7b77f058d75a5cb0233d69162e8c6ddc` | Unity 6 steering; Seek/Arrive/PathFollow/avoidance; Jobs/Burst claims | **UNKNOWN_LICENSE** | P1 movement/performance |
| REP-003 | TUM-MLCMS/Crowd-Simulation-and-Visualization-in-Unity | `ac11e2a578304ef4a09e7e69d48f3252ceb3e301` | Unity crowd simulation; distance field/Dijkstra/Optimal Steps simplification | **MIT** | P1 algorithms |
| REP-004 | trinhthanhtrung/unity-pedestrian-sim | `18d4d19bd5dd406073573380b14bdda0580e96db` | Unity NavMesh, boid-like crowd generation, Social Force Model | **MIT** | P1 crowd alternatives |
| REP-005 | Flameshot/Unity-Formation-Movement | `963b14f5d19dc8101a66bacbd89d00bf06058003` | Unity formation slots/grid points, historical/live following, NavMesh/A* integration | **GPL-3.0** | P1 formation reference; reuse constraints |
| REP-006 | AlexandraSicobean/Crowd-Simulation-System | `7db2ff4f5438d327e18cdf289a396a463edd64c5` | Unity A*/bidirectional A*, steering, collision avoidance, centralized simulator | **UNKNOWN_LICENSE** | P1 architecture |
| REP-007 | eavraam/Crowd-Simulator | `33fe42fc85bc8d529d68052dabc157a521853daf` | Unity 2022.3; locomotion, colliders/rigidbodies, A* crowd examples | **UNKNOWN_LICENSE** | P2 physics/pathfinding comparison |

## Verification notes
- **VERIFIED FACT:** all seven repositories exist publicly on GitHub and the SHAs above were returned by GitHub as their latest commit at catalog time.
- **VERIFIED FACT:** REP-003 and REP-004 contain MIT LICENSE files at the fixed refs.
- **VERIFIED FACT:** REP-005 contains GPL version 3 license text at the fixed ref.
- **UNKNOWN:** no root LICENSE/LICENSE.md/LICENSE.txt was found through the available GitHub file interface at the fixed refs for REP-001, REP-002, REP-006, REP-007. This is not proof that no licensing statement exists elsewhere; classification remains UNKNOWN_LICENSE until verified.
- **SOURCE CLAIM:** engine/features listed above are repository-authored README claims and require code-level verification in #5 before becoming CODE OBSERVATION.

## Prioritization rationale
REP-001 is the closest gameplay analogue because its repository description explicitly covers the target chain swipe -> crowd growth through additive/multiplicative gates -> obstacles -> end battle. REP-002/003/004/005/006 provide distinct technical alternatives for crowd movement/formation/avoidance. REP-007 provides a physics/pathfinding contrast.

## #5 deep-analysis queue
1. REP-001 — reconstruct runner flow and locate input/gate/crowd/combat/result scripts.
2. REP-002 — inspect steering interfaces, manager/update strategy, avoidance Jobs/Burst and allocations.
3. REP-005 — inspect formation leader/grid-point/follower abstractions; treat GPL as a reuse constraint.
4. REP-003 — inspect Simulation/Pedestrian/Grid/Pathfinding.
5. REP-004 — inspect path/crowd/social-force scripts.
6. REP-006 — inspect centralized Simulator, Agent and pathfinding/steering.
7. REP-007 — inspect collision/rigidbody/A* architecture as comparison.
