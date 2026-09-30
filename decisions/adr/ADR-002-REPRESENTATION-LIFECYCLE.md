> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-002 Unit representation lifecycle
STATUS: PROPOSED
SUPERVISOR STATUS: PENDING
CONTEXT: gate growth/shrink/death creates high churn.
REQUIREMENTS: ARCH-004,TECH-POOL-001,PERF-005.
EVIDENCE: REP-001 preactivation; REP-004/006/007 Instantiate; UNITY-004/006; #7/#9.
OPTIONS: fixed preallocation; expandable object pool; Instantiate/Destroy.
PROPOSED DECISION: lifecycle abstraction with pool/preallocation-capable implementation; exact capacity/strategy chosen by EXP-PERF-003 after unit-count/memory budgets.
CONSEQUENCES: strict reset contract; logical army independent of pool.
RISKS: retained memory, exhaustion, stale state.
