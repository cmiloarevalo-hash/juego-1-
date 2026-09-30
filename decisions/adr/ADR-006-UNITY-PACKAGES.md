> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-006 Unity/package baseline
STATUS: PROPOSED / BLOCKED ON RESEARCH GATE REFRESH
SUPERVISOR STATUS: PENDING
CONTEXT: exact engine/package APIs are mutable.
REQUIREMENTS: TECH-UNITY-001,ARCH-009.
EVIDENCE: RG-001,UNITY-001..016.
OPTIONS: supported Unity release/package combinations at implementation start.
PROPOSED DECISION: no exact version selected in research artifact; refresh official support matrix immediately before implementation and pin versions then.
RATIONALE: prevents stale invented compatibility.
RISKS: implementation cannot begin responsibly without this gate.
