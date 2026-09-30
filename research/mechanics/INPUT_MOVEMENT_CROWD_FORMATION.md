> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Input, Movement, Crowd and Formation Research

Work Item: #6

## Evidence baseline
- Top Lords primary storefront evidence: TL-001/TL-002 — simple lateral swipe/path-choice is a publisher-described reference characteristic.
- REP-002 — centralized weighted steering; NavMesh path corners; all-agent avoidance scan + Burst job.
- REP-003 — shared Dijkstra field + spatial pedestrian-cell lists.
- REP-004 — boid and social-force variants.
- REP-005 — virtual formation grid points decoupled from NavMesh/A* movement backend.
- REP-006 — centralized steering with grid pathfinding and predictive agent avoidance.
- REP-007 — Rigidbody/pathfinding educational contrast.

## Input model
**SOURCE CLAIM:** Top Lords storefront copy emphasizes lateral swipes and rapid dodge/charge/path decisions.

**INFERENCE:** an original comparable runner should expose a small normalized horizontal-control contract independent of touch implementation, so desktop/editor simulation and automated tests can drive the same movement intent. This is a candidate requirement, not an approved architecture.

Open choices:
1. drag displacement -> desired lateral position;
2. swipe velocity/delta -> lateral velocity;
3. discrete lane/path-choice command.

No evidence establishes that Top Lords itself uses discrete lanes. That remains **UNKNOWN**.

## Movement/crowd alternatives

### A. NavMeshAgent per unit
Evidence reference: REP-005 integration; REP-002 uses shared NavMesh path calculation but direct transform steering.
- Behavior: individualized navigation/avoidance supplied by navigation system.
- Complexity: lower custom pathfinding logic, higher per-agent subsystem dependency.
- CPU/memory: **UNKNOWN quantitatively** for target scale/device.
- Suitability: useful where units require independent obstacle routing; potentially unnecessary for tightly constrained runner corridors.
- Experiment required: yes.

### B. Leader + fixed/rotated offsets
Evidence reference: REP-005 FormationGridPoint.
- Behavior: leader defines frame; followers pursue assigned virtual offsets.
- Complexity: moderate; formation assignment and transition policy required.
- CPU/memory: target calculations are structurally simple; actual locomotion cost depends on backend.
- Suitability: strong candidate for coherent army silhouettes and deterministic slot ownership.
- Limitation: obstacle avoidance/compression and topology changes need explicit handling.

### C. Slot/grid formation with reassignment
Evidence reference: REP-005 formation grid lists/FormationTypeSO.
- Behavior: finite slots define desired positions; growth/shrink requires assignment/reassignment.
- Complexity: higher than raw offsets when minimizing crossing/reassignment.
- Scalability: depends on assignment algorithm; naive global optimal matching can become expensive.
- Experiment required for reassignment strategy.

### D. Steering/boids
Evidence: REP-002/004/006.
- Behavior: weighted seek/arrive/separation/avoidance creates organic local motion.
- Complexity: tuning interactions and spatial neighbor lookup.
- CPU: all-pairs implementations in evidence can scale poorly structurally; spatial partitioning changes this.
- Determinism: sensitive to update ordering/floating point unless deliberately constrained.
- Suitability: useful as local correction layered under a formation target.

### E. Shared grid/flow-field style guidance
Evidence: REP-003 shared Dijkstra field + cell-density structure.
- Behavior: common global field guides many agents toward shared targets.
- Complexity: grid generation/update and local movement policy.
- Suitability: attractive when many units share destinations or arena exits.
- Limitation: runner formation fidelity and dynamic target changes require additional policy.

### F. Lightweight custom kinematic simulation
Evidence basis: REP-002 direct transform integration and REP-001 activation roster demonstrate that full physics/navigation per member is not mandatory.
- Behavior: target slot + bounded velocity + lightweight local separation/collision approximation.
- Complexity: custom correctness burden.
- CPU/memory: potentially controllable because data/update shape is explicit, but **no target benchmark exists**.
- Suitability: candidate for mobile runner crowds; must be validated rather than assumed.

### G. ECS/DOTS
Current evidence: insufficient to justify a target decision. REP-002 uses Jobs/Burst for avoidance but is GameObject/MonoBehaviour based.
**UNKNOWN:** whether ECS/DOTS materially improves the target workload enough to offset complexity. This requires a RESEARCH_GATE if later architecture depends on current Unity Entities APIs/packages.

## Formation transition concerns
Candidate invariants derived from evidence and runner needs:
- stable member identity should not be required for purely cosmetic soldiers unless gameplay assigns individual state;
- growth/shrink must not create visible uncontrolled crossings;
- leader/path intent and formation layout should be separable;
- formation should define behavior when corridor width is smaller than nominal width;
- dead/despawned members must release slots deterministically;
- gate growth should define where newly activated members enter and how quickly they settle.

These are **INFERENCE/candidate requirements**, to be formalized only after #7/#8 and consolidation.

## Unknowns
No measured target-device comparison exists for NavMesh-per-unit vs slots vs steering vs custom kinematic vs ECS/DOTS. No numeric crowd-size threshold is asserted.
