# PROJECT WORKFLOW AUTHORITY

Transition authority: Issue #87  
Finalization PR: #89  
Finalization base: workflow/issue-85-adoption-readiness@3a4cca27dc049889b19878b6a20bb58c5f15b448

## 1. Operational-state resolution

Do not infer the current canonical workflow from this file's branch location, PR review status, or a static transition label.

Reconstruct the operational state from GitHub using:
1. PR #89 durable integration state;
2. the latest applicable Supervisor checkpoint in Issue #87;
3. the exact repository content and imported blob identities below.

Resolution rule:

### Before durable integration + successful post-integration verification

If PR #89 is not durably integrated, OR Issue #87 does not yet contain a later applicable Supervisor checkpoint confirming successful post-integration canonical-pointer verification:

- former G_INF_01 workflow = CURRENT_CANONICAL_REFERENCE;
- workflow/adopted/ANDROID_WORKFLOW.md = NOT_YET_CANONICAL;
- workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md = NOT_YET_CANONICAL;
- workflow/PROJECT_WORKFLOW_OVERLAY.md remains the preserved project-specific operational overlay.

SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.
SEMANTIC_ACCEPTED != CANONICAL_ADOPTION.

### After durable integration + successful post-integration verification

If PR #89 is durably integrated AND the latest applicable Supervisor checkpoint in Issue #87 confirms successful post-integration canonical-pointer verification with no material blocker:

ANDROID_WORKFLOW:
CURRENT_CANONICAL_WORKFLOW

ANDROID_UNITY_GAME_PROFILE:
CURRENT_SUBORDINATE_PROFILE

Former G_INF_01 workflow:
SUPERSEDED / HISTORICAL_PROVENANCE

The Unity/Game profile remains conditional and applies only when materially relevant to an authorized Unity/Game Work Item.

This condition-based rule prevents both two CURRENT_CANONICAL workflows and zero CURRENT_CANONICAL workflows.

## 2. Exact workflow identities

Canonical Android workflow snapshot when the State C condition above is satisfied:
- project path: workflow/adopted/ANDROID_WORKFLOW.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_WORKFLOW.md
- blob: 44eef0edb75781885879e8c2ae8d09114d27bb99

Unity/Game subordinate profile when the State C condition above is satisfied:
- project path: workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_UNITY_GAME_PROFILE.md
- blob: 3c3d846e1a3c1d90598e9e64cedff06e27a83269

Former workflow provenance:
- repository: cmiloarevalo-hash/G_INF_01
- ref: 3138299c54e590a38b1a3fd51263abcff32afe53
- path: WORKFLOW_CANONICO_SUPERVISOR_GITHUB_IMPLEMENTADOR_AI_STUDIO.md
- blob: 83406e15c3462f4acb8e94eb28de85f6b3850692

The imported source files remain byte-identical. Their upstream PROPOSAL / NON-CANONICAL wording is source provenance and does not determine this project's canonical state.

## 3. Project layering

When the State C condition is satisfied, operational interpretation is layered as:

1. Human / Supervisor authority + active Work Item.
2. workflow/adopted/ANDROID_WORKFLOW.md.
3. CURRENT PROJECT/GAME SPECIFICATIONS.
4. workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md where materially applicable.
5. accepted/fresh evidence when triggered.

Concrete game behavior continues to come from current project/game specifications.

## 4. Required invariants

- ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW.
- ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW.
- ANDROID_UNITY_GAME_PROFILE DOES NOT OVERRIDE AUTHORITY.
- PROFILE ACTIVATION != NEW WORKFLOW AUTHORITY.
- TECHNICAL CAPABILITY != WORKFLOW AUTHORITY.
- LOCAL CAPABILITY != WORKFLOW AUTHORITY.
- PATH PERMISSION != SEMANTIC PERMISSION.
- CI/TEST PASS != SEMANTIC_ACCEPTED.
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.
- PUBLISH = HUMAN ACTION.
- GITHUB STATE > SESSION MEMORY.

Project-specific preserved rules remain in workflow/PROJECT_WORKFLOW_OVERLAY.md.

## 5. Transition history

STATE A:
- former workflow CURRENT_CANONICAL_REFERENCE;
- Android workflow PROPOSED_ADOPTION_SOURCE;
- Unity profile PROPOSED_EXTENSION.

STATE B:
- former workflow CURRENT_CANONICAL_REFERENCE;
- adoption HEAD SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL.

STATE C:
- ANDROID_WORKFLOW CURRENT_CANONICAL_WORKFLOW;
- ANDROID_UNITY_GAME_PROFILE CURRENT_SUBORDINATE_PROFILE where applicable;
- former workflow SUPERSEDED / HISTORICAL_PROVENANCE.

The current state is resolved only by the rule in section 1 and the latest applicable Issue #87 Supervisor checkpoint.

## 6. Local execution agent

Astra = EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT.

Astra is not a new authority class.

Default:
REPOSITORY_WRITE = NO.

Future local/runtime activities use, when material:
- EXTERNAL_ACTOR_ACTIVITY;
- LOCAL_TEST_PACKET;
- LOCAL_RESULT.

PASS / FAIL / BLOCKED / NOT_RUN / STALE_RESULT / DUPLICATE_RESULT are evidence/execution states, not Supervisor semantic decisions.

If repository correction is required:

REPOSITORY_CHANGE_REQUIRED: YES
→ return to Supervisor/Implementer.

## 7. Evidence continuity

Existing exact-SHA evidence and Supervisor decisions for #73–#87 and PRs #78–#89 remain preserved according to their original identities.

Do not rerun valid evidence solely because workflow vocabulary changes.

## 8. Prototype anti-bottleneck

Do not make full device matrices, profiler suites, performance suites, formal playtests, Vertical Slice, AAB/release signing, full regression, exhaustive traceability, full repository audits, or research "just in case" automatic for every change.

They activate only through Acceptance Criteria, risk, evidence need, project specification, maturity, or material unknown.

## 9. Execution boundary

Stage 2 remains PAUSED until Supervisor separately authorizes resumption, regardless of whether the workflow transition resolves to State B or State C.

Issue #87 does not authorize Unity, Astra/local execution, Android build, APK/AAB, device/performance work, X46, asset import, gameplay/product implementation, or Stage 3.
