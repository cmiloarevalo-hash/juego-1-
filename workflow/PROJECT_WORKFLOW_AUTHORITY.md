# PROJECT WORKFLOW AUTHORITY

Status: STATE C FINALIZATION CANDIDATE  
Active Work Item: Issue #87  
Finalization base: workflow/issue-85-adoption-readiness@3a4cca27dc049889b19878b6a20bb58c5f15b448

## 1. Current transition status

PR #88 has been durably integrated at merge commit 3a4cca27dc049889b19878b6a20bb58c5f15b448. Supervisor post-merge checkpoint 5924268175 classifies the project as:

STATE B / INTEGRATED_BUT_CANONICAL_POINTER_NOT_FINALIZED

This finalization change prepares the durable State C pointer.

While this finalization exists only on its review branch/PR, the project remains State B and the old workflow remains CURRENT_CANONICAL_REFERENCE.

State C becomes established only after this exact finalization HEAD:
1. receives Supervisor SEMANTIC_ACCEPTED;
2. passes separate MERGE_ELIGIBLE checks;
3. is durably integrated through authorized project authority;
4. is verified post-integration as the project authority/navigation pointer;
5. has no material blocker.

SEMANTIC_ACCEPTED != CANONICAL_ADOPTION.

## 2. State C canonical pointer

When the conditions above are satisfied and this finalization is durably present on the target branch:

ANDROID_WORKFLOW:
CURRENT_CANONICAL_WORKFLOW

Canonical project snapshot:
- path: workflow/adopted/ANDROID_WORKFLOW.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_WORKFLOW.md
- blob: 44eef0edb75781885879e8c2ae8d09114d27bb99

ANDROID_UNITY_GAME_PROFILE:
CURRENT_SUBORDINATE_PROFILE

Subordinate project snapshot:
- path: workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_UNITY_GAME_PROFILE.md
- blob: 3c3d846e1a3c1d90598e9e64cedff06e27a83269

The Unity/Game profile is active only when materially applicable to an authorized Unity/Game Work Item.

Old workflow:
SUPERSEDED / HISTORICAL_PROVENANCE

Historical source:
- repository: cmiloarevalo-hash/G_INF_01
- ref: 3138299c54e590a38b1a3fd51263abcff32afe53
- path: WORKFLOW_CANONICO_SUPERVISOR_GITHUB_IMPLEMENTADOR_AI_STUDIO.md
- blob: 83406e15c3462f4acb8e94eb28de85f6b3850692

The old source remains provenance/history; it is not deleted.

The upstream PROPOSAL / NON-CANONICAL wording inside imported snapshots remains unchanged source provenance. Project canonical authority arises from the project's completed State C adoption, not by editing upstream text.

## 3. Project layering

State C operational layering:

1. Human / Supervisor authority + active Work Item.
2. workflow/adopted/ANDROID_WORKFLOW.md.
3. CURRENT PROJECT/GAME SPECIFICATIONS.
4. workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md where materially applicable.
5. accepted/fresh evidence when triggered.

Concrete game behavior remains governed by current project/game specifications.

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

Project-specific preserved rules remain in workflow/PROJECT_WORKFLOW_OVERLAY.md, which this finalization does not modify.

## 5. Transition history

STATE A:
- old workflow CURRENT_CANONICAL_REFERENCE;
- Android workflow PROPOSED_ADOPTION_SOURCE;
- Unity profile PROPOSED_EXTENSION.

STATE B:
- old workflow CURRENT_CANONICAL_REFERENCE;
- adoption HEAD SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL.

STATE C:
- ANDROID_WORKFLOW CURRENT_CANONICAL_WORKFLOW;
- ANDROID_UNITY_GAME_PROFILE CURRENT_SUBORDINATE_PROFILE where applicable;
- old workflow SUPERSEDED / HISTORICAL_PROVENANCE.

Never permit two CURRENT_CANONICAL workflows or zero CURRENT_CANONICAL workflows.

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

Existing exact-SHA evidence and Supervisor decisions for #73–#87 and PRs #78–#88 remain preserved according to their original identities.

Do not rerun valid evidence solely because workflow vocabulary changes.

## 8. Prototype anti-bottleneck

Do not make full device matrices, profiler suites, performance suites, formal playtests, Vertical Slice, AAB/release signing, full regression, exhaustive traceability, full repository audits, or research "just in case" automatic for every change.

They activate only through Acceptance Criteria, risk, evidence need, project specification, maturity, or material unknown.

## 9. Execution boundary

Stage 2 remains PAUSED after workflow adoption finalization until Supervisor separately authorizes resumption.

Issue #87 finalization does not authorize Unity, Astra/local execution, Android build, APK/AAB, device/performance work, X46, asset import, gameplay/product implementation, or Stage 3.
