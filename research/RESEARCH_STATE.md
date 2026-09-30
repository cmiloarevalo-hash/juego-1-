# RESEARCH_STATE

PROGRAM ISSUE: #20 (operational controller); #1 remains master requirements/history source
CURRENT DATE: 2026-09-30
BASE: `research/issue-2-bootstrap@d02ba00ca28a1ee23c41e62276edff313dfeb5f2`
CURRENT HEAD: Issue #20 branch; PR #21 handoff records reviewed orchestration HEAD
ACTIVE WORK ITEM: #3 — Research: Referencia observable — Top Lords
ACTIVE PROGRAM CONTROLLER: #20
ACTIVE PRS: #19 bootstrap; #21 orchestration

## Supervisor decision — 2026-09-30
PROGRAM EXECUTION AUTHORIZED. #3–#18 UNPAUSED. The #20 control plane is sufficient for current-session operation subject to later review.
WORKER_AUTO_REINVOCATION: BLOCKED / UNKNOWN — partial limitation only; MUST NOT block current research execution.
READY_FOR_REVIEW is not a global stop condition.

## Work item states
- #2 — READY_FOR_REVIEW, PR #19, HEAD `d02ba00ca28a1ee23c41e62276edff313dfeb5f2`.
- #20 — READY_FOR_REVIEW for implemented control plane, PR #21; worker auto-reinvocation remains partial BLOCKED/UNKNOWN.
- #3 — IN_PROGRESS.
- #4 — READY (bootstrap execution dependency satisfied).
- #9 — READY (bootstrap execution dependency satisfied).
- #5 — waits for #4 catalog artifact.
- #6–#8 — wait for #3 plus sufficient repository analysis.
- #10–#11 — wait for #3 plus comparable repository/reference evidence.
- #12–#18 — dependency-gated as stated in their Issues.

## Dependency semantics
EXECUTION_DEPENDENCY: satisfied by required usable GitHub artifact; upstream review alone does not block.
ACCEPTANCE_DEPENDENCY: explicit Supervisor acceptance required. Never infer it.

## Orchestration status
STATE MACHINE: specified.
QUEUE/DISPATCHER: implemented in PR #21, dry-run by default.
DOUBLE-CLAIM PREVENTION: serialized dispatcher + state recheck; manual/external writers must obey protocol.
WATCHDOG: implemented as observational workflow.
WORKER_AUTO_REINVOCATION: BLOCKED / UNKNOWN; accepted partial limitation.
DEFAULT-BRANCH ACTIONS ACTIVATION: pending ordinary review/merge; not a blocker to current-session research.

## Ready for review
- #2 — PR #19.
- #20 control plane — PR #21.

## Active
- #3.

## Ready
- #4.
- #9.

## Blocked
No globally blocking condition. Only worker auto-reinvocation integration is partial BLOCKED/UNKNOWN.

## Sources reviewed
GH-001..GH-007 in `sources/official-documentation.md`.

## Next exact action
Execute #3 within `research/games/top-lords/**, sources/**, analysis/findings/**`; persist evidence, verify acceptance criteria, open its PR/handoff, then recalculate queue without waiting for ordinary PR review.
