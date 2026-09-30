> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-001 Army movement and formation
STATUS: PROPOSED
SUPERVISOR STATUS: PENDING
CONTEXT: mobile runner crowd requires coherent formation with gate mutation.
REQUIREMENTS: SRS-ARMY-001,SRS-FORM-001,GAME-FORM-001/002,PERF-004.
EVIDENCE: REP-002..006,#6,#9,RG-002/004.
OPTIONS: NavMesh per unit; slots+custom kinematic; slots+steering; shared grid/field; ECS/DOTS.
PROPOSED DECISION: authoritative logical army + deterministic slot targets; movement backend abstract; begin with minimum-complexity central/data-oriented GameObject implementation and benchmark before ECS/DOTS or per-unit NavMesh commitment.
RATIONALE: preserves behavior while deferring unmeasured backend choice.
CONSEQUENCES: formation solver/new movement backend required; benchmark gate remains.
RISKS: custom collision/settling complexity; no target-device result.
REFERENCES: NC-004/005/006, EXP-CROWD/PERF.
