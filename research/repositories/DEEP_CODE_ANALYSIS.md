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
