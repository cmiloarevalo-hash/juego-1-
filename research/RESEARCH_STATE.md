# RESEARCH_STATE

PROGRAM ISSUE: #20 (operational controller); #1 remains master requirements/history source  
CURRENT DATE: 2026-09-30  
BASE: `research/issue-2-bootstrap@d02ba00ca28a1ee23c41e62276edff313dfeb5f2`  
CURRENT HEAD: Issue #20 branch; exact PR HEAD recorded at handoff  
ACTIVE WORK ITEM: #20 — P0 persistent GitHub research orchestration  
ACTIVE BRANCH: `infra/issue-20-research-orchestration`  
ACTIVE PR: PENDING

## Work item states
- #2 — READY_FOR_REVIEW, PR #19, HEAD `d02ba00ca28a1ee23c41e62276edff313dfeb5f2`.
- #20 — IN_PROGRESS.
- #3–#18 — PAUSED by explicit Issue #20 program control until orchestration is reviewed.

## Dependency semantics
EXECUTION_DEPENDENCY: satisfied by required usable GitHub artifact; upstream review alone does not block.  
ACCEPTANCE_DEPENDENCY: explicit Supervisor acceptance required. Never infer it.

## Orchestration status
STATE MACHINE: specified.  
QUEUE/DISPATCHER: implemented as GitHub Actions workflow, dry-run by default.  
DOUBLE-CLAIM PREVENTION: serialized dispatcher + state recheck; manual/external writers must obey protocol.  
WATCHDOG: implemented as observational workflow.  
WORKER INVOCATION: BLOCKED — no verified concrete agent API/App/credential/endpoint.  
DEFAULT-BRANCH ACTIVATION: pending Supervisor review/merge; GitHub requires default-branch presence for schedule/repository_dispatch triggers.

## Completed work items
None declared DONE by Supervisor.

## Ready for review
- #2 via PR #19.

## Active
- #20.

## Paused
- #3–#18 by explicit #20 instruction.

## Blocked
Only the concrete worker-launch integration portion of #20 is BLOCKED. The generic control plane is not blocked.

## Sources reviewed
Seven GitHub official documentation records: GH-001..GH-007 in `sources/official-documentation.md`.

## Research artifacts
- `workflow/research/ORCHESTRATION.md`
- `workflow/research/ORCHESTRATION_VERIFICATION.md`
- `.github/workflows/research-dispatch.yml`
- `.github/workflows/research-watchdog.yml`

## Specification/reuse/new-code/plan status
Product specifications: not started.  
REUSE MATRIX: not started.  
NEW CODE INVENTORY: not started.  
ADR: not started.  
IMPLEMENTATION PLAN: not started.

## Open questions
- Which concrete supported worker integration can launch/reinvoke the research agent from GitHub?
- What authentication/secret and acknowledgement contract does that integration require?

## Next exact action
Complete static verification, open Issue #20 PR, record real PR HEAD. Research #3–#18 remains PAUSED until #20's persisted review condition is satisfied.
