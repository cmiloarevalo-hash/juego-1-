> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-003 Combat model
STATUS: PROPOSED
SUPERVISOR STATUS: PENDING
CONTEXT: proprietary Top Lords combat internals are UNKNOWN; original combat required.
REQUIREMENTS: SRS-COMBAT-001,GAME-COMBAT/DEATH/RESULT.
EVIDENCE: #8,#12.
OPTIONS: radius nearest-target; front-contact pairing; lane/slot pairing; aggregate attrition.
PROPOSED DECISION: explicit individual combat domain contracts with replaceable candidate-query strategy; start from deterministic front/local candidate policy for runner encounters, retaining ability to aggregate if profiling/product scale requires.
RATIONALE: testable original rules without claiming proprietary algorithms.
RISKS: exact boss/role/damage rules remain product PENDING.
