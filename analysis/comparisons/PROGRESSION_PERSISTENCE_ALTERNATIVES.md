# Comparison — Progression Persistence Alternatives

| Alternative | Appropriate data | Structure | Security | Migration | Evidence |
|---|---|---|---|---|---|
| PlayerPrefs | preferences/small primitives | key-value | unencrypted | manual keys/version | UNITY-014, REP-001 |
| versioned JSON/local file | structured profile | explicit schema | local/tamperable unless additional measures | explicit migrators | UNITY-015/016 |
| backend/cloud | cross-device/authoritative possibilities | service-defined | architecture-dependent | service-defined | UNKNOWN / requires scope |

No backend is proposed without product authorization and external integration requirements.
