> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Comparison — Combat and Targeting Alternatives

| Model | Query/algorithm shape | Determinism | Crowd scalability evidence | Presentation | Key risk |
|---|---|---|---|---|---|
| nearest/radius per unit | spatial candidate query + priority | medium with tie-break | UNKNOWN; depends query | organic | target churn/query cost |
| front-contact pairing | local front/envelope | high | plausible structural bound; unbenchmarked | runner-readable | congestion/front definition |
| lane/slot pairing | indexed opponent candidates | high | structurally bounded | ordered | restrictive behavior |
| aggregate attrition | army-level calculation | high | potentially low per-logical-unit work; HYPOTHESIS | needs visual proxy | disconnect from individual abilities |

No winner is declared. #9 profiling and #12 consolidation are required before material architecture choice.
