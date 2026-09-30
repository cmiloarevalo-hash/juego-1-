# IMPLEMENTATION_PLAN

## Pre-implementation gates
P0. Supervisor reviews semantic product TBDs (combat/boss/metagame scope and performance/device targets). Refresh RG-001 and pin supported Unity/package versions. Decide/accept or revise ADRs. Execute required benchmark spikes when thresholds/devices exist. No product coding before authorization.

## Proposed future Work Items
### IMP-01 Project/toolchain baseline
OBJECTIVE: create Unity project baseline only after RG-001/ADR-006 resolution. SCOPE: engine/package/build settings. REQ: TECH-UNITY-001. AC: exact versions reproducible; Android/iOS dev build pipeline verified. VERIFICATION: clean checkout/build. RISKS: package compatibility. DEP: P0.

### IMP-02 Domain foundations + deterministic update ordering
OBJECTIVE: implement stable IDs, run phases, event/order contracts. COMPONENTS: NC-002 foundation. REQ: GAME-RUN,TECH-TIME/ID. AC: unit tests for phase/order. DEP: IMP-01.

### IMP-03 Input intent
NC-001. REQ SRS-INPUT/GAME-INPUT. AC touch/editor scripted parity; no product UI beyond test harness. DEP IMP-01/02.

### IMP-04 Level data + validator
NC-003/018. REQ SRS-LEVEL,VER-LEVEL. AC malformed fixture coverage; sample authored test level. DEP IMP-02, ADR-004.

### IMP-05 Army domain
NC-004. REQ SRS-ARMY/GAME-ARMY. AC deterministic count/membership mutation tests. DEP IMP-02.

### IMP-06 Formation solver
NC-005. REQ SRS-FORM/GAME-FORM. AC stable slots/growth/shrink/compression tests. DEP IMP-05, ADR-001 provisional behavior.

### IMP-07 Movement backend benchmark spike
NC-006/017. Implement only minimal alternatives needed for EXP-CROWD/PERF-001/002. AC raw profiler artifacts on approved devices; decision evidence returned to ADR-001/RG-002/004. DEP IMP-01/05/06 + performance targets.

### IMP-08 Representation lifecycle
NC-008. REQ ARCH-004/TECH-POOL. AC reset/capacity/stale-state tests. Strategy finalized using EXP-PERF-003. DEP IMP-05 + performance targets/ADR-002.

### IMP-09 Gates
NC-007. REQ SRS-GATE/GAME-GATE. AC arithmetic/idempotency/overlap boundary tests. DEP IMP-04/05/08; Supervisor resolves rounding/min/max/formula set.

### IMP-10 Combat target/damage/death
NC-009/010. REQ SRS-COMBAT/GAME-COMBAT/DEATH. AC targeting tie/no-target/invalidation and lethal-order tests. DEP IMP-05/06/08 + Supervisor combat semantics/ADR-003.

### IMP-11 Boss/encounter specialization
NC-011. CONDITIONAL: only if GAME-BOSS-001 approved. AC phase/victory tests. DEP IMP-10 + product decision.

### IMP-12 Result + progression transaction
NC-012/013. REQ SRS-RESULT/PROG,DATA-RESULT. AC exactly-once reward, balances/prerequisites tests. DEP IMP-10/11 as applicable + economy rules.

### IMP-13 Persistence/migration
NC-014. REQ SRS-SAVE/DATA-SAVE. AC corrupt/interruption/migration/reset tests. DEP IMP-12, ADR-005.

### IMP-14 Presentation/HUD/camera
NC-015/016. REQ UX/CAM/ARCH-008. AC gate readability, state sync, framing tests. DEP gameplay domains + RG-007/package decision.

### IMP-15 Rendering/animation performance spike
NC-015/017. Execute EXP-PERF-004/005 with representative art. AC raw captures and ADR-007 update. DEP IMP-01/08/14 + target devices/art.

### IMP-16 Physics/performance integration
Execute EXP-PERF-006 plus sustained EXP-PERF-007. AC budgets from PERFORMANCE_SPECIFICATION pass or documented remediation. DEP integrated representative build + approved budgets.

### IMP-17 Content authoring + progression content
OBJECTIVE: author original levels/economy tables/content under approved scope. AC validators pass; no proprietary Top Lords assets/balance copied. DEP systems + Supervisor content/economy scope.

### IMP-18 Full verification/release-readiness
Execute VER-* suite, device matrix, save migration, traceability and license audit. AC all approved requirements pass or exceptions explicitly accepted by Supervisor. DEP all authorized implementation WIs.

## Dependency chain
P0 -> IMP-01 -> IMP-02 -> {03,04,05}; 05 -> 06 -> 07/08 -> 09/10 -> optional 11 -> 12 -> 13; presentation 14 integrates domains; 15/16 gate performance; 17 authors content; 18 final verification.

## Provenance policy
No external COPY/ADAPT currently planned. Any change must update #14 matrix before implementation. Every implementation PR must cite requirement IDs, NC IDs, ADR status, verification evidence and source/reuse provenance.
