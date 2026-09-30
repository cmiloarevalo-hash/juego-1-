> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Comparison — Progression Persistence Alternatives

| Alternative | Appropriate data | Structure | Security | Migration | Evidence |
|---|---|---|---|---|---|
| PlayerPrefs | preferences/small primitives | key-value | unencrypted | manual keys/version | UNITY-014, REP-001 |
| versioned JSON/local file | structured profile | explicit schema | local/tamperable unless additional measures | explicit migrators | UNITY-015/016 |
| backend/cloud | cross-device/authoritative possibilities | service-defined | architecture-dependent | service-defined | UNKNOWN / requires scope |

No backend is proposed without product authorization and external integration requirements.
