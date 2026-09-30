> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-005 Persistence baseline
STATUS: PROPOSED
SUPERVISOR STATUS: PENDING
CONTEXT: durable progression requires migration/idempotent rewards.
REQUIREMENTS: SRS-SAVE-001,DATA-SAVE-001.
EVIDENCE: #11,UNITY-014..016,RG-005.
OPTIONS: PlayerPrefs; versioned local file; cloud/backend.
PROPOSED DECISION: versioned structured local save repository under persistent storage; PlayerPrefs limited to preferences/small non-sensitive values; backend/cloud excluded until explicitly scoped.
CONSEQUENCES: migrations/recovery/transaction tests required.
RISKS: local tampering, platform file semantics.
