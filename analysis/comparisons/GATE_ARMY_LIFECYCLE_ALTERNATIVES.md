> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Comparison — Gate and Army Lifecycle Models

| Dimension | Preallocated roster | Object pool | Instantiate/Destroy | Data-oriented logical army |
|---|---|---|---|---|
| Growth latency | activation/reset | acquire/reset | construction | logical update; representation policy separate |
| Memory | reserves capacity | retains inactive pool | dynamic | implementation-dependent |
| Capacity | explicit fixed/expand policy | configurable/expandable | resource-limited | logical capacity explicit |
| GC/allocation | low during in-capacity mutation | workload-dependent | potentially repeated | implementation-dependent |
| Reset burden | per-object | per-object | constructor/default setup | state-model reset |
| Evidence | REP-001 | UNITY-004/006 | REP-004/006/007 + Unity API | HYPOTHESIS |
| Target suitability | UNKNOWN until #9 | UNKNOWN until #9 | UNKNOWN until #9 | UNKNOWN |

## Proposed experiment EXP-GATE-001
QUESTION: Which representation lifecycle gives stable gate-mutation cost on representative mobile devices?  
ALTERNATIVES: preallocated SetActive; Unity ObjectPool-style acquire/release; Instantiate/Destroy baseline.  
WORKLOAD: scripted repeated +N/xN/-N mutations including worst-case configured growth and reset. Exact counts come from later requirements.  
MEASUREMENTS: CPU spike/frame time, GC alloc, managed/native memory, active/inactive object counts, mutation-to-settle latency.  
PROCEDURE: same scene/assets and deterministic gate script; warm-up; repeated captures on representative devices; preserve raw profiler captures.  
SUCCESS CRITERIA: derived from #13 Performance Specification; until then no winner.  
CONCLUSION: PROPOSED / NOT RUN.

## Proposed experiment EXP-GATE-002
QUESTION: Which gate detection ownership prevents duplicate application under dense formations?  
ALTERNATIVES: leader collider; army proxy; per-member triggers with idempotency guard.  
MEASUREMENTS: duplicate/missed applications, physics callback cost, behavior under overlapping gates and high-speed crossing.  
CONCLUSION: PROPOSED / NOT RUN.
