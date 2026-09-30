# Verification Specification

VER-INPUT-001 Scripted input can reproduce traversal/path choices.
VER-GATE-001 Test +,-,x and any approved percentage semantics at min/max/rounding/overflow boundaries and duplicate trigger.
VER-ARMY-001 Assert logical count, active representation count and slot ownership consistency after mutation/death/reset.
VER-COMBAT-001 Test no target, tie-break, target invalidation, simultaneous lethal damage, multiple attackers, stale pooled reference.
VER-RESULT-001 Assert exactly-once result and reward transaction under retry/interruption.
VER-LEVEL-001 Authoring validator rejects duplicate IDs, missing refs, malformed order/end state.
VER-SAVE-001 Test new/load/save/corrupt/migration/reset/interrupted reward transaction.
VER-PERF-001 Execute #9 experiment matrix on approved devices once budgets exist; preserve raw evidence.
VER-UX-001 Verify gate readability without color-only encoding and camera visibility of upcoming decisions.
VER-LIC-001 Every COPY/ADAPT implementation reference must resolve to #14 provenance/license row.

## Traceability examples
SRS-GATE-001 -> REP-001/#7 -> GAME-GATE-003 -> ARCH-004/Gate Resolver -> VER-GATE-001.
SRS-FORM-001 -> REP-005/#6 -> GAME-FORM-001 -> Formation Solver -> VER-ARMY-001.
SRS-PERF-001 -> UNITY-003/#9 -> PERF-002 -> profiling plan -> VER-PERF-001.
SRS-SAVE-001 -> UNITY-014..016/#11 -> DATA-SAVE-001 -> Save Repository -> VER-SAVE-001.
