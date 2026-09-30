> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Performance Experiment Matrix

All experiments below are **PROPOSED / NOT RUN**. No raw results exist yet.

## EXP-PERF-001 — crowd update topology
ALTERNATIVES: per-agent MonoBehaviour; central loop; Jobs/Burst batched variant. ECS only after RG-PERF-001.  
SCENE: identical movement/formation workload.  
MEASURE: CPU frame/main/worker, GC alloc, memory, correctness.  
COUNTS: parameter sweep derived from requirements; no invented values.

## EXP-PERF-002 — neighbor lookup
ALTERNATIVES: all-pairs; uniform grid/spatial hash; Physics overlap filtered by layer.  
MEASURE: CPU, allocations, candidates, missed/incorrect separation events.

## EXP-PERF-003 — army lifecycle
ALTERNATIVES: preallocated SetActive; ObjectPool; Instantiate/Destroy.  
MEASURE: mutation spike, GC, retained memory, settle latency, correctness.

## EXP-PERF-004 — rendering identical soldiers
ALTERNATIVES: ordinary SkinnedMeshRenderer/Renderer baseline; SRP Batcher-compatible materials; GPU/direct instancing-compatible representation where animation technique permits.  
MEASURE: CPU render cost, draw/batch/set-pass, GPU time, memory, visual equivalence.  
CONTROL: same camera/lights/material fidelity.

## EXP-PERF-005 — animation representation
ALTERNATIVES: Animator each; visibility culling; animation LOD/update throttling; alternative GPU/vertex technique if RG permits.  
MEASURE: Animator/animation CPU, skinning/GPU, memory, visible correctness.

## EXP-PERF-006 — physics participation
ALTERNATIVES: per-unit colliders/rigidbodies; trigger/proxy-only army interactions; custom spatial contacts.  
MEASURE: Physics CPU, broad/narrow pairs, contacts, gameplay correctness.

## EXP-PERF-007 — sustained mobile thermal run
ENVIRONMENT: selected low/mid representative Android/iOS devices, development/non-development comparison as appropriate.  
PROCEDURE: sustained representative gameplay loop long enough to observe thermal/frequency behavior; exact duration defined with device/test plan.  
MEASURE: frame-time distributions over time, CPU/GPU bottleneck, memory growth, thermal indicators available from platform tooling.

## Raw-results convention
When executed: `analysis/experiments/<EXP-ID>/` stores environment.md, procedure.md, raw profiler captures/export references, summary.md and hashes/version metadata. A result cannot be cited without raw artifact/provenance.
