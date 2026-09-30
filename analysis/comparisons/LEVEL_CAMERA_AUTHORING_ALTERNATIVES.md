> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Comparison — Level and Camera Authoring

| Alternative | Authoring speed | Validation | Runtime coupling | Reuse/modularity | Risk |
|---|---|---|---|---|---|
| scene-only | direct visual | manual/custom | high | low-medium | hidden configuration drift |
| scene + data asset | visual + structured | strong candidate | medium | high | synchronization |
| modular segment prefabs + data | high repeatability | strong | medium | high | tooling complexity |
| procedural | high runtime variability | complex | high algorithmic | high | outside evidenced need |

Camera: custom fixed/centroid follow is lower dependency; Cinemachine offers packaged camera tooling but exact current API/package must pass RG-PERF-001/current package gate. No winner declared before #12.
