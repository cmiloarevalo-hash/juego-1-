> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / PROPOSAL, NOT ACCEPTED ADR AUTHORITY.**
> The proposal below is preserved for rationale. Accepted #64 architecture boundaries and product semantics supersede conflicts. Backend/render/lifecycle choices remain measurement-driven unless later explicitly accepted. Issue #83 global hold forbids execution.

# ADR-007 Rendering and animation strategy
STATUS: PROPOSED
SUPERVISOR STATUS: PENDING
CONTEXT: many similar animated units on mobile.
REQUIREMENTS: PERF-006,TECH-RENDER/ANIM.
EVIDENCE: #9,UNITY-008/009,RG-003.
OPTIONS: ordinary renderer/Animator; culling/LOD; instanced representation; GPU/vertex animation.
PROPOSED DECISION: establish ordinary+culling baseline and benchmark representative art; adopt instancing/GPU animation only when EXP-PERF-004/005 demonstrates need/benefit on target devices.
RISKS: art not yet representative; no raw results.
