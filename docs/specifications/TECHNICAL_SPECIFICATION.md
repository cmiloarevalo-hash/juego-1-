# Technical Specification

TECH-UNITY-001 Engine: Unity/C# family required by program; exact supported Unity release PENDING RG-001.
TECH-INPUT-001 Input implementation SHALL map touch/editor test input to normalized domain intent; exact Input System version PENDING.
TECH-TIME-001 Domain updates SHALL define ordering for gate/combat/death/result same-frame conflicts.
TECH-ID-001 Levels, gates, upgrades, durable entities SHALL use stable serialized IDs.
TECH-POOL-001 Reused unit representations SHALL implement complete reset of target/health/animation/slot/transient state before reacquire.
TECH-PHYS-001 Physics layers/queries SHALL include only gameplay-required interactions and be profiled. [UNITY-010]
TECH-RENDER-001 Rendering path SHALL preserve ability to compare SRP batching/instancing representations under RG-003.
TECH-ANIM-001 Animation culling/LOD behavior SHALL not suppress authoritative gameplay events. [UNITY-009]
TECH-SAVE-001 Save writes SHALL use a versioned format and defined interruption/corruption recovery; exact file/atomic replace mechanism decided during implementation planning.
TECH-LOG-001 Development builds SHALL expose diagnostic counters for logical units, active representations, pool counts, target-query candidates and result transaction identity where applicable.
