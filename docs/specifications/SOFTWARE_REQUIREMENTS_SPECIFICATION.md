# Software Requirements Specification

## Product boundary
Original mobile single-player strategy-runner inspired by observable high-level mechanics, not proprietary Top Lords code/assets/balance.

## Functional requirements
SRS-INPUT-001 The runtime SHALL accept one-hand lateral/path-choice intent through an input abstraction. [Evidence: TL-001/002,#6]
SRS-RUN-001 A run SHALL progress through authored ordered level segments. [#10]
SRS-ARMY-001 The runtime SHALL maintain an authoritative logical army count/state independent of presentation object count. [#7,#12]
SRS-GATE-001 A gate SHALL apply an authored deterministic army mutation at most once per gate per run. [REP-001,#7]
SRS-FORM-001 Active visual units SHALL receive formation targets after army mutations. [REP-005,#6/#7]
SRS-COMBAT-001 Combat SHALL expose explicit target, attack, damage, health and death state transitions. [#8]
SRS-RESULT-001 A run SHALL emit one immutable result snapshot used for rewards/progression. [#8/#11]
SRS-LEVEL-001 Levels SHALL use stable IDs and validated authored definitions. [#10]
SRS-SAVE-001 Durable profile data SHALL be versioned and loadable across sessions. [UNITY-014..016,#11]
SRS-PROG-001 Progression/unlock/upgrade data SHALL use stable IDs and validated prerequisites. [#11]
SRS-UX-001 Gate operation and critical decisions SHALL be readable before commitment and not rely only on color. [#7/#10]

## Non-functional requirements
SRS-PERF-001 Performance acceptance SHALL be measured on representative target mobile devices, not inferred from Editor measurements. [UNITY-003/007,#9]
SRS-PERF-002 Runtime SHALL avoid avoidable per-frame managed allocation in crowd/combat hot paths where profiling identifies it as material. [REP-002,#9]
SRS-TEST-001 Deterministic domain logic SHALL be testable without animation being authoritative. [#7/#8]
SRS-LIC-001 No external code/assets SHALL be copied/adapted unless #14 verifies license/provenance. [program rule]

## Pending product constraints
SRS-TBD-001 exact min devices/FPS/memory/crowd capacity: PENDING GAP-002/003.
SRS-TBD-002 exact combat/boss rules: PENDING GAP-004.
SRS-TBD-003 exact metagame depth/economy values: PENDING GAP-005/007.
