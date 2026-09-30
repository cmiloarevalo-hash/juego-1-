> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Mobile Performance Research

Work Item: #9

## Principle
**VERIFIED FACT (Unity documentation):** profiling must distinguish CPU/GPU/memory/physics/rendering costs and should be performed on target devices. Therefore this program defines no arbitrary frame, memory or crowd-count budget before #13.

## Evidence from comparable code
- REP-002: central update but managed neighbor list allocation per avoidance calculation, all-agent scan, per-agent NativeArrays and immediate job completion.
- REP-003: spatial cell lists constrain local pedestrian lookup; shared Dijkstra field built at startup.
- REP-004: all-pairs boid/social-force loops; Instantiate/Destroy lifecycle.
- REP-005: formation target abstraction can separate layout from movement backend.
- REP-006: all-agent avoidance plus bounded grid obstacle query.
- REP-007: managed-list A* and Rigidbody movement.
These are CODE OBSERVATIONS, not benchmark results.

## CPU/update architecture
Compare: MonoBehaviour Update per unit; central manager iteration; batched jobs/Burst; data-oriented/ECS only after current-package Research Gate.
Measurements: main thread, worker time, scheduling/sync, script calls, GC allocations, cache-visible behavior where profiler supports it.

## Neighbor queries
All-pairs is structurally O(n²) candidate comparison. Uniform grid/spatial hash can constrain candidates by locality but correctness depends cell size/query radius. Physics overlap delegates broad/narrow-phase work to engine. Benchmark all under identical behavior.

## Pooling/GC
UNITY-004/006 establish pooling as a lifecycle tool, not a universal winner. Measure pool capacity, inactive memory, reset cost, allocation spikes and GC. Preallocated REP-001 roster is a concrete reference pattern.

## Physics
**VERIFIED FACT:** Unity fixed timestep frequency affects physics CPU load; collision-layer filtering can reduce unnecessary overlap/collision work.
Candidate policy: avoid full physical interaction between every friendly crowd member unless behavior requires it; use layer matrix/query filters and profile.
Do not change fixed timestep solely for performance without gameplay correctness testing.

## Animation
**VERIFIED FACT:** Animator culling modes can skip offscreen transform/animation work; Unity recommends culling/visibility-aware animation optimization.
Alternatives:
- Animator per visible unit;
- reduced animation update rate/LOD;
- shared/simple animation state;
- GPU/vertex animation for large homogeneous crowds (requires rendering Research Gate/experiment).
No winner asserted.

## Rendering
Compare SRP Batcher, GPU instancing/direct instanced rendering, static/dynamic batching where applicable. Unity documentation notes compatibility/priority interactions between SRP Batcher and GPU instancing in documented versions; profile the actual target Unity/URP version.

Metrics: CPU render thread/main thread, batches/set-pass/draw calls, triangles/vertices, overdraw/fill, GPU frame time, skinning cost, visible unit count, material variants.

## Culling/LOD
Frustum culling is baseline engine behavior; evaluate distance/visibility LOD for meshes, shadows, animation and VFX. Runner camera may keep many units visible, so occlusion benefit is scene-dependent.

## Memory
Capture managed allocations/heap, native/engine memory, texture/mesh/animation footprint and pool retention. Memory Profiler package/version must be fixed by Research Gate before toolchain commitment.

## Thermal/device variability
Mobile results must identify device model/OS/build/API/graphics backend, thermal state/test duration and power mode where observable. Short editor-only captures are insufficient for acceptance.

## Research Gate RG-PERF-001 — DRAFT
DECISION POINT: target Unity editor/LTS line, URP/rendering package, Input System, AI Navigation, Burst/Jobs/Entities and profiling package versions.
WHY CURRENT RESEARCH: APIs/performance characteristics are mutable and downstream ADRs depend on them.
CONSTRAINTS: mobile iOS/Android target; no product implementation yet; current repository evidence spans different Unity generations.
EVIDENCE: UNITY-001..UNITY-010 plus comparable package manifests.
OPTIONS: select a currently supported Unity release/package set after checking official release/support/package compatibility documentation; defer ECS unless experiments justify it.
PROPOSED APPROACH: before #16, refresh official compatibility/release evidence and pin exact versions in STRATEGIC_RATIONALE.
RATIONALE STATUS: DRAFT.
SUPERVISOR VERIFICATION: PENDING.

## No invented budgets
UNKNOWN: target min device, target FPS, memory ceiling, maximum simultaneous units, acceptable thermal behavior. These become requirements in #13 after evidence/product constraints.
