# Official Documentation Sources

Access date for Issue #20 sources: 2026-09-30.

## GH-001 — Triggering a workflow
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/how-tos/write-workflows/choose-when-workflows-run/trigger-a-workflow  
RELEVANT CLAIMS: `GITHUB_TOKEN`-generated events normally do not recursively trigger workflows; `workflow_dispatch` and `repository_dispatch` are documented exceptions.  
NOTES: Primary source used for dispatch-loop design.

## GH-002 — Events that trigger workflows
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/reference/workflows-and-actions/events-that-trigger-workflows  
RELEVANT CLAIMS: `repository_dispatch` and `schedule` require workflow presence on the default branch; schedules run on default branch, may be delayed/dropped under load, minimum interval five minutes, and scheduled workflows in public repositories can be disabled after 60 days inactivity.  
NOTES: Primary source used for activation/watchdog constraints.

## GH-003 — Control workflow/job concurrency
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/how-tos/write-workflows/choose-when-workflows-run/control-workflow-concurrency  
RELEVANT CLAIMS: concurrency groups serialize matching workflow/jobs; pending/running behavior is configurable.  
NOTES: Primary source for dispatcher serialization.

## GH-004 — REST API endpoints for labels
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/issues/labels  
RELEVANT CLAIMS: issue labels can be read and mutated; mutation requires Issues or Pull Requests write permission depending on endpoint/token.  
NOTES: Primary source for namespaced state labels.

## GH-005 — Use GITHUB_TOKEN for authentication
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/tutorials/authenticate-with-github_token  
RELEVANT CLAIMS: workflows can authenticate API requests using `GITHUB_TOKEN`; permissions should be explicitly scoped.  
NOTES: Primary source for workflow authentication.

## GH-006 — REST API workflow dispatch
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/actions/workflows  
RELEVANT CLAIMS: REST can create `workflow_dispatch` events for workflows configured for that trigger; fine-grained tokens require Actions write permission.  
NOTES: Primary source for external/manual re-dispatch capability.

## GH-007 — Create repository dispatch event
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/repos/repos#create-a-repository-dispatch-event  
RELEVANT CLAIMS: external systems can emit `repository_dispatch`; fine-grained token requires Contents write; endpoint accepts event type and client payload.  
NOTES: This is a generic GitHub trigger, not evidence of a concrete ChatGPT worker launcher.

## Integration evidence gap
**UNKNOWN:** no repository artifact or verified official project-specific integration currently identifies an API/GitHub App/credential capable of launching the concrete research agent. No such integration is inferred from GitHub's generic dispatch APIs.
