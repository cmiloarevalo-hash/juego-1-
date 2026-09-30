# Persistent Research Orchestration

Work Item: #20  
Status: IMPLEMENTED CONTROL PLANE / WORKER LAUNCHER BLOCKED  
Date: 2026-09-30

## Evidence classification

### VERIFIED FACT
- GitHub Actions supports explicit `workflow_dispatch`; its REST dispatch endpoint requires Actions write permission for fine-grained tokens.
- `repository_dispatch` can trigger workflows for external activity and requires the workflow file to exist on the default branch.
- Scheduled workflows execute from the default branch; schedules may be delayed/dropped under high load and public-repository schedules can be disabled after 60 days without repository activity.
- Workflow/job `concurrency` can serialize runs sharing a concurrency group.
- Issue labels can be created/updated with Issues write permission.
- Events caused by a workflow's `GITHUB_TOKEN` generally do not recursively create workflow runs; `workflow_dispatch` and `repository_dispatch` are documented exceptions.

Sources: GH-001 through GH-006 in `sources/official-documentation.md`.

### UNKNOWN
No verified GitHub/OpenAI integration, API endpoint, GitHub App, credential, or webhook is available in this repository that can launch/reinvoke the concrete ChatGPT research worker represented by the current session. The workflows therefore MUST NOT claim that they launch an AI worker.

## State machine

Exactly one `research:state:*` label is authoritative per research Issue:

`PAUSED -> READY -> CLAIMED -> IN_PROGRESS -> READY_FOR_REVIEW -> DONE`

Exceptional transition: any non-DONE state may become `BLOCKED`; recovery returns it only to the state justified by persisted evidence.

Definitions:
- **PAUSED**: authorized but dispatch forbidden by program control or unsatisfied execution dependency.
- **READY**: authorized and all EXECUTION_DEPENDENCY artifacts exist.
- **CLAIMED**: dispatcher has reserved the Issue for one worker invocation.
- **IN_PROGRESS**: worker invocation has positively acknowledged ownership.
- **READY_FOR_REVIEW**: execution artifacts/PR/handoff exist; Supervisor semantic review can proceed in parallel.
- **BLOCKED**: a specific missing decision/integration/evidence prevents this Work Item.
- **DONE**: Supervisor-controlled completion/acceptance where required.

## Dependency semantics

**EXECUTION_DEPENDENCY** is satisfied by existence of the required usable artifact in GitHub. It does not require the upstream PR to be accepted unless the dependent Issue explicitly says so.

**ACCEPTANCE_DEPENDENCY** requires an explicit Supervisor decision. No such dependency is inferred from ordinary review state.

Issue #20 currently imposes a program-level PAUSE on #3–#18 until orchestration is reviewed. That explicit control overrides otherwise-satisfied execution dependencies.

## Queue

Queue membership is Issues #3–#18 under program #20. Ordering follows dependency readiness, then Issue number unless the Supervisor persists a different priority.

The dispatcher never treats `READY_FOR_REVIEW` as a global stop. Once #20's pause is lifted, independent READY work may dispatch while reviews are pending.

## Claim/idempotency policy

1. All dispatcher runs use repository-wide concurrency group `research-dispatch` with `cancel-in-progress: false`.
2. Dispatcher reads current labels immediately before mutation.
3. Only an Issue with exactly `research:state:READY` and no CLAIMED/IN_PROGRESS label is eligible.
4. State mutation replaces the state label set rather than adding a second state.
5. A `research:claim:<run_id>` comment is written as provenance when a real claim is enabled.
6. Re-running a dispatcher cannot claim a CLAIMED/IN_PROGRESS Issue.
7. Because GitHub issue labels do not provide a compare-and-swap primitive, the exact-once guarantee applies to this serialized dispatcher. Manual/external writers must obey the same protocol. This limitation is explicit, not hidden.

## Worker invocation boundary

The control plane exposes the plug-in boundary after a successful claim. A concrete launcher must provide:
- verified endpoint/integration identity;
- authentication mechanism and secret names;
- required GitHub/API permissions;
- request schema carrying repository, Issue number, claim/run ID and branch/base;
- positive acknowledgement semantics used to move CLAIMED -> IN_PROGRESS;
- retry/idempotency semantics;
- timeout/failure handling.

Until those are verified, `research-dispatch.yml` defaults to dry-run and refuses real claim/launch unless manually requested. It never fabricates worker execution.

## Recovery/watchdog

`research-watchdog.yml` supports manual execution and a scheduled scan after it reaches the default branch. It reports stale CLAIMED/IN_PROGRESS tasks based on persisted claim comments/labels and does not silently reassign them. Recovery requires either a verified worker retry mechanism or an authorized state reset. This prevents duplicate workers.

## Context reconstruction contract

Every worker invocation must read, in order: #20; #1; active Issue; relevant predecessor Issues; open PRs/branches/HEAD; root/research indexes; RESEARCH_STATE; RESEARCH_PROTOCOL; SESSION_HANDOFF; relevant source indexes; recent commits. It must derive objective, scopes, dependencies, evidence gaps and outputs before writing.

## Default-branch activation constraint

GitHub documents that `schedule` and `repository_dispatch` workflows require the workflow file on the default branch. Therefore PR review/merge by the Supervisor is an activation dependency for unattended Actions behavior, even though creating and reviewing the workflow files is not blocked.
