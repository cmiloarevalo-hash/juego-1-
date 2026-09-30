# Deep Code Analysis — Comparable Repositories

Work Item: #5  
Analysis date: 2026-09-30

## REP-001 RunControl/RunControlMain
REF: `77ca6cf373e64754b0d74361626ec664316e1525`  
LICENSE: UNKNOWN_LICENSE — code is analyzed as reference only; do not copy/adapt.

### Project evidence
**CODE OBSERVATION:** repository contains a Unity project under `RunControl/`. Build artifacts include paths identifying Unity 6000.1.2f1 in generated Android metadata; this demonstrates the environment used for those artifacts, not necessarily a durable project-version requirement.

### Army mutation
PATH: `RunControl/Assets/Script/Kütüphane.cs`  
CLASS: `Batu.Hesaplama`  
METHODS: `AdamYönetimi`, `Degistir`

**CODE OBSERVATION:** `AdamYönetimi` parses a string whose first character is an operation and remaining characters a positive integer. Implemented operators are:
- `x`: requests activation of `(n-1)*currentCount`, producing multiplication when enough inactive pooled objects exist;
- `+`: activates `n`;
- `%`: requests deactivation of `currentCount/n`;
- `-`: deactivates `n`.

**CODE OBSERVATION:** `Degistir` iterates an existing `List<GameObject>`; it toggles `SetActive(true/false)` rather than instantiating/destroying crowd members, places changed members at a supplied Transform position, updates the count, and refuses to reduce the count below one.

**INFERENCE:** this is a preallocated/pool-like army representation. Capacity is bounded by list size; requested growth beyond inactive capacity silently stops when the list ends. This behavior and edge case should be tested in #7 rather than copied.

### Persistence/meta utility
PATH: same file  
CLASS: `BellekYonetim`  
**CODE OBSERVATION:** integer/float/string values are persisted through Unity `PlayerPrefs`; initialization seeds level, points, cosmetic indices, audio/language and ad-transition keys.

### Flow reconstruction status
`Input -> Player Controller -> Movement -> Crowd -> Gate -> Army Mutation -> ...`
Only **Army Mutation** and part of persistence are code-verified in this pass. README claims the surrounding runner/gate/battle flow, but code search did not yet establish those controller paths. They remain SOURCE CLAIM/UNKNOWN rather than fabricated links.

## REP-005 Flameshot/Unity-Formation-Movement
REF: `963b14f5d19dc8101a66bacbd89d00bf06058003`  
LICENSE: GPL-3.0 — analyze/reference; no reuse decision here.

### Core abstractions
PATHS:
- `Assets/FormationMovement/Core/Scripts/FormationAI.cs`
- `.../IFormationLeader.cs`
- `.../IFormationUnit.cs`
- `.../FormationGridPoint.cs`
- `Assets/FormationMovement/Integrations/NavMesh/Scripts/FormationLeader.cs`
- `.../FormationFollower.cs`

**CODE OBSERVATION:** `FormationAI` is an abstract movement adapter. `IFormationLeader` extends `IFormationUnit` and exposes velocity/history data plus interpolation. `FormationGridPoint` stores a leader reference and computes target position from leader position plus a rotated offset.

**CODE OBSERVATION:** the NavMesh integration requires `NavMeshAgent`; follower implements `FormationAI, IFormationUnit`. The leader requires both `Formation` and `NavMeshAgent`. Search evidence also shows parallel A* integration classes.

**CODE OBSERVATION:** `Formation` maintains a list of followers and `FormationGridPoint` instances. `FormationTypeSO` stores a simulation type and follower prefab.

**INFERENCE:** the architecture cleanly separates formation geometry/target assignment from concrete movement backend, making it useful as a design reference for comparing slot/offset formations versus per-agent navigation. GPL-3.0 means proprietary-product COPY/ADAPT implications require #14 review.

## Repository analysis still required
REP-002/003/004/006/007 require method-level reading. #5 is therefore **IN_PROGRESS**, not READY_FOR_REVIEW.

## Cross-repository preliminary finding
**CODE OBSERVATION + INFERENCE:** two relevant patterns are already evidenced:
1. fixed GameObject roster with activation/deactivation for runner army mutation (REP-001);
2. virtual formation targets with movement-backend adapters (REP-005).

They solve different concerns and must not be conflated into one architecture before #6/#7 comparisons and #12 consolidation.

## REP-002 ALI-P48/CrowdSimulation
REF: `4f81451d7b77f058d75a5cb0233d69162e8c6ddc`  
LICENSE: UNKNOWN_LICENSE — reference analysis only.

PATH/CLASS/METHOD:
- `Assets/Scripts/CrowdManager.cs` — `CrowdManager.Start/Update/SpawnNPCs`
- `Assets/Scripts/SteeringBehavior/SteeringAgent.cs` — `SteeringAgent.Steer/SetTarget`
- `.../AvoidanceBehavior.cs` — `CalculateSteering`
- `.../AvoidanceJob.cs` — `AvoidanceJob.Execute`
- `.../FollowPathBehavior.cs` — `SetTarget/CalculateSteering/CalculatePath`
- `Packages/manifest.json`

**CODE OBSERVATION:** `CrowdManager` instantiates a configured NPC count at startup, retains `SteeringAgent` references, and calls every agent's `Steer()` from one manager `Update`. `SteeringAgent` sums active weighted `ISteeringBehavior` outputs, clamps to max speed, then directly advances `transform.position`.

**CODE OBSERVATION:** `FollowPathBehavior.CalculatePath` uses `NavMesh.CalculatePath` and follows returned corners; reaching the last waypoint chooses another manager spawn point.

**CODE OBSERVATION:** avoidance maintains a static list of all agent transforms. Each `CalculateSteering` creates a managed `List<Vector3>`, scans all agents by distance, copies neighbors into persistent NativeArrays, schedules a Burst `IJobParallelFor`, immediately calls `Complete()`, then sums results. NativeArrays are allocated per component in `Awake` with fixed capacity 200 and disposed in `OnDestroy`.

**INFERENCE/PERFORMANCE LIMITATION:** the broad-phase neighbor scan is all-agents-per-agent and allocates a managed list per calculation. Immediate `Complete()` limits overlap. The fixed NativeArray capacity creates an explicit scaling bound if nearby count exceeds 200. No benchmark result is claimed.

DEPENDENCIES: Unity AI Navigation 2.0.6; Input System 1.13.1; URP 17.0.4; Unity Jobs/Burst namespaces used by avoidance code.

## REP-003 TUM-MLCMS/Crowd-Simulation-and-Visualization-in-Unity
REF: `ac11e2a578304ef4a09e7e69d48f3252ceb3e301`  
LICENSE: MIT.

PATH/CLASS/METHOD:
- `Assets/Scripts/Simulation.cs` — `Awake/Start/SetupPedestrianDensityField/FixedUpdate`
- `Assets/Scripts/Pathfinding.cs` — `CreateDijkstraField/GetAllNeighbors/GetSmallestDistanceCell`
- `Assets/Scripts/Pedestrian.cs` — position/cell/history data.

**CODE OBSERVATION:** `Simulation.Start` computes one Dijkstra distance field over the grid, then builds a 2D array of pedestrian lists keyed by cell. `FixedUpdate` centrally iterates pedestrians, updates cell membership, obtains neighboring cells, evaluates a cost for candidate cells, derives movement direction, considers nearby pedestrians through the density field, and records position history.

**CODE OBSERVATION:** `Pathfinding.CreateDijkstraField` initializes targets to zero and other cells to infinity, repeatedly selects the smallest unvisited distance by scanning the full field, and relaxes non-obstacle neighbors.

**INFERENCE/PERFORMANCE LIMITATION:** spatial cell lists constrain local pedestrian-neighbor work versus global all-pairs scanning, but the shown Dijkstra construction uses repeated full-grid minimum scans rather than a priority queue. It is created at startup in this implementation, not each pedestrian frame. No runtime benchmark is inferred.

## REP-004 trinhthanhtrung/unity-pedestrian-sim
REF: `18d4d19bd5dd406073573380b14bdda0580e96db`  
LICENSE: MIT.

PATH/CLASS/METHOD:
- `CrowdGen/PedestrianCrowdGen.cs` — `FixedUpdate/SetPedestrianTargets`
- `CrowdGen/PedestrianCrowdPath.cs`
- `SocialForceModel/SFCharacter.cs` — `FixedUpdate/DrivingForce/AgentInteractForce/WallInteractForce`.

**CODE OBSERVATION:** crowd generation clones path GameObjects and spawns pedestrians, optionally randomizes route nodes, rebuilds the active pedestrian list, and can compute boid-like target adjustments. `SetPedestrianTargets` loops each pedestrian over all pedestrians within a squared-distance threshold, applies separation and speed matching, and also considers the player.

**CODE OBSERVATION:** `SFCharacter.FixedUpdate` sums driving, agent-interaction and wall-interaction forces, integrates velocity, clamps desired speed, and either updates `AICharacterControl` target or moves the transform. Agent interaction loops the configured `agents` array and wall interaction loops configured walls.

**INFERENCE/PERFORMANCE LIMITATION:** boid and social-force variants shown use all-agent scans; generator code uses `Instantiate` and `Destroy` rather than pooling. This is useful contrast to REP-001's activation/deactivation roster. No comparative benchmark exists.

## REP-006 AlexandraSicobean/Crowd-Simulation-System
REF: `7db2ff4f5438d327e18cdf289a396a463edd64c5`  
LICENSE: UNKNOWN_LICENSE — reference analysis only.

PATH/CLASS/METHOD:
- `Assets/Scripts/Simulator.cs` — `Update/UpdateCollisionAvoidance/UpdatePathFollowing/UpdateSteering/Arrive/AvoidObstacles/AvoidAgents`
- `Assets/Scripts/Agent.cs` — `RequestNewPath/GetDirection/UpdateCellOccupation/GetCurrentWaypointWorld`
- `Assets/Scripts/CrowdGenerator.cs` — `GenerateCrowd`.

**CODE OBSERVATION:** a singleton-like central `Simulator` owns an agent list and dispatches one of three modes each `Update`: collision avoidance, path following, or steering. Steering combines obstacle avoidance, agent avoidance and arrive forces.

**CODE OBSERVATION:** `AvoidAgents` loops the complete simulator agent list for each agent and predicts closest approach over a fixed horizon. `AvoidObstacles` searches a bounded local grid neighborhood. `Agent.RequestNewPath` selects A* or bidirectional A* on the grid. `CrowdGenerator` instantiates agents and registers them with the simulator.

**INFERENCE/PERFORMANCE LIMITATION:** centralized update avoids per-agent `Update` methods for these calculations, but `AvoidAgents` is still all-pairs in the shown form. Grid obstacle lookup demonstrates a separate bounded spatial-query pattern.

## REP-007 eavraam/Crowd-Simulator
REF: `33fe42fc85bc8d529d68052dabc157a521853daf`  
LICENSE: UNKNOWN_LICENSE — reference analysis only.

PATH/CLASS/METHOD:
- `Assets/Scripts/Exercise 2 - Collision/Agent.cs` — `FixedUpdate`
- `.../CrowdGenerator.cs` — `Start/GenerateRandomPosition/IsPositionTooClose`
- `Assets/Scripts/Exercise 3 - Pathfinding Astar/Pathfinding.cs` — `FindPath/GetNeighborList/GetLowestFCostNode`
- `.../Agent_Astar.cs` — `FixedUpdate`
- `Assets/Scripts/Exercise 1 - Locomotion/Locomotion.cs` — `LateUpdate` and velocity helpers.

**CODE OBSERVATION:** collision/pathfinding agents derive velocity from a path manager and mutate Rigidbody position in `FixedUpdate`. Crowd generation instantiates a requested number of agents and tests candidate spawn positions against previously selected positions.

**CODE OBSERVATION:** `Pathfinding.FindPath` implements grid A* using managed `List<PathNode>` open/closed sets; lowest f-cost is selected by linear scan, neighbors are expanded, and the path is reconstructed through `cameFromNode`.

**CODE OBSERVATION:** locomotion reads input state, accelerates/decelerates planar velocity, directly changes transform position, and uses precomputed Animator parameter hashes.

**INFERENCE/PERFORMANCE LIMITATION:** linear open-list minimum selection and `Contains` operations are simple educational A* choices rather than evidence of a mobile-scale optimized pathfinder. No benchmark result is claimed.

## Reconstructed flows supported by code

### REP-001 runner-relevant partial flow
`Gate operation string -> Hesaplama.AdamYönetimi -> Degistir -> activate/deactivate existing crowd GameObjects -> current army count`.
Input, gate trigger ownership, combat and result remain **UNKNOWN** at method level from the inspected evidence.

### REP-002 crowd navigation flow
`CrowdManager.SpawnNPCs -> SteeringAgent.SetTarget -> FollowPathBehavior.CalculatePath(NavMesh) -> CrowdManager.Update -> SteeringAgent.Steer -> weighted behaviors + avoidance job -> transform movement -> new random destination`.

### REP-003 simulation flow
`grid/targets -> CreateDijkstraField -> cell-density registration -> Simulation.FixedUpdate -> neighbor cells -> cost selection -> local pedestrian proximity -> movement/history`.

### REP-004 crowd alternatives
`path clone/spawn -> per-pedestrian route target -> optional boid neighbor scan -> AI/path target`; independently, `destination -> driving + agent + wall forces -> velocity -> character/transform movement`.

### REP-005 formation flow
`Formation leader/history -> FormationGridPoint offsets -> follower target -> concrete NavMesh/A* movement adapter`.

### REP-006 centralized steering flow
`CrowdGenerator -> Agent path request -> A*/bidirectional A* -> Simulator.Update -> steering/path mode -> arrive + obstacle/agent avoidance -> position/cell update`.

### REP-007 educational path flow
`spawn -> path manager/A* -> direction -> Agent(_Astar).FixedUpdate -> Rigidbody position`.

## #5 verification conclusion
The prioritized catalog has now been inspected at code level sufficiently to document concrete paths/classes/methods, dependencies, execution patterns and limitations. The requested generic `Input -> Crowd -> Gate -> Combat -> Result` chain can only be reconstructed **where applicable**: REP-001 supplies code-level gate/army mutation but the inspected fixed ref does not establish combat/result ownership; the other repositories are crowd/formation/pathfinding comparables rather than complete crowd-runner games. Missing links are explicitly **UNKNOWN**, not inferred.

#5 does not select the target architecture and does not authorize code reuse. Those decisions remain downstream.
