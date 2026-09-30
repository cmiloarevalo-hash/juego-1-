# Orchestration Verification — Issue #20

Date: 2026-09-30

## Static scenarios

| ID | Scenario | Expected result | Status |
|---|---|---|---|
| ORCH-V-001 | queue globally paused by #20 | #3–#18 are not claimed | PASS by workflow guard/design |
| ORCH-V-002 | READY Issue, dry-run | candidate reported; labels unchanged | PASS by workflow logic |
| ORCH-V-003 | READY Issue, real claim manually enabled | state labels replaced by CLAIMED; claim comment contains run ID | IMPLEMENTED, runtime test pending default-branch activation |
| ORCH-V-004 | CLAIMED/IN_PROGRESS Issue encountered again | not eligible | PASS by selection predicate |
| ORCH-V-005 | concurrent dispatch runs | serialized by `research-dispatch` concurrency group | PASS by configuration; runtime test pending |
| ORCH-V-006 | stale claim | watchdog reports candidate; no automatic duplicate reassignment | PASS by design; runtime test pending |
| ORCH-V-007 | worker launch | concrete integration required | BLOCKED — integration unknown |
| ORCH-V-008 | completion unlocks next execution dependency | dispatcher model permits READY independent work without waiting for review | PASS by dependency semantics; #20 pause currently overrides |
| ORCH-V-009 | unattended schedule before merge | must not be claimed active | PASS — GitHub requires workflow on default branch |

## Safety properties
- No product/game code.
- No autonomous merge or approval.
- No invented worker endpoint.
- State labels are namespaced `research:state:*`.
- Real state mutation requires explicit workflow input while worker launcher is unavailable.
- Watchdog is observational; it does not create a second claim.

## Runtime activation test
After Supervisor review places workflows on the default branch:
1. run dispatcher with `dry_run=true`; confirm no label mutation;
2. create/identify a disposable authorized test Issue or explicitly authorize mutation of a READY research Issue;
3. run with real claim enabled and verify one CLAIMED state plus provenance comment;
4. rerun and verify no second claim;
5. run watchdog and inspect report;
6. do not enable unattended worker launch until the concrete integration is verified.
