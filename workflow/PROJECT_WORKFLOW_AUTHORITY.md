# PROJECT WORKFLOW AUTHORITY

Status: ADOPTION IMPLEMENTATION / STATE A / NOT_YET_CANONICAL  
Active Work Item: Issue #87  
Base: workflow/issue-85-adoption-readiness@688158eb8b3cad99d43a9de35308f40e4568d9a1

## 1. Current authority during Issue #87

This document implements the repository state required for controlled adoption. Its existence, branch, PR, or future semantic acceptance does not by itself change the canonical workflow pointer.

Current State A:
- old workflow: CURRENT_CANONICAL_REFERENCE;
- adopted ANDROID_WORKFLOW snapshot: PROPOSED_ADOPTION_SOURCE;
- adopted ANDROID_UNITY_GAME_PROFILE snapshot: PROPOSED_EXTENSION.

Current canonical workflow source:
- repository: cmiloarevalo-hash/G_INF_01
- ref: 3138299c54e590a38b1a3fd51263abcff32afe53
- path: WORKFLOW_CANONICO_SUPERVISOR_GITHUB_IMPLEMENTADOR_AI_STUDIO.md
- blob: 83406e15c3462f4acb8e94eb28de85f6b3850692

## 2. Exact adopted source snapshots

Android workflow:
- project path: workflow/adopted/ANDROID_WORKFLOW.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_WORKFLOW.md
- blob: 44eef0edb75781885879e8c2ae8d09114d27bb99

Unity/Game profile:
- project path: workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md
- source: cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- source path: workpacks/workflow-operationalization-01/ANDROID_UNITY_GAME_PROFILE.md
- blob: 3c3d846e1a3c1d90598e9e64cedff06e27a83269

The imported snapshots are byte-identical source artifacts. Their upstream PROPOSAL / NON-CANONICAL wording remains unchanged and records upstream source status. Project canonical authority arises only from this project's completed State C adoption.

## 3. Project layering

When State C is durably completed, operational interpretation is layered as:

1. Human / Supervisor authority + active Work Item.
2. adopted ANDROID_WORKFLOW.
3. CURRENT PROJECT/GAME SPECIFICATIONS.
4. ANDROID_UNITY_GAME_PROFILE where materially applicable.
5. accepted/fresh evidence when triggered.

Concrete game behavior remains governed by current project/game specifications. Workflow/profile documents do not absorb mechanics, product UX, content, tuning, device targets, or project performance thresholds.

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

Project-specific rules that must survive adoption are in workflow/PROJECT_WORKFLOW_OVERLAY.md.

## 5. Three-state canonical transition

### STATE A — before adoption-head semantic acceptance

Old workflow:
CURRENT_CANONICAL_REFERENCE

New Android workflow:
PROPOSED_ADOPTION_SOURCE

Unity/Game profile:
PROPOSED_EXTENSION

No canonical authority/navigation pointer changes.

### STATE B — after SEMANTIC_ACCEPTED, before durable integration/adoption

Old workflow:
CURRENT_CANONICAL_REFERENCE

New adoption HEAD:
SEMANTIC_ACCEPTED_FOR_INTEGRATION
NOT_YET_CANONICAL

No canonical authority/navigation pointer changes.

SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.
SEMANTIC_ACCEPTED != CANONICAL_ADOPTION.

### STATE C — after authorized durable adoption

State C exists only after all applicable conditions are satisfied:
- exact adoption HEAD received SEMANTIC_ACCEPTED;
- separate MERGE_ELIGIBLE checks pass;
- authorized durable integration/merge or another explicit durable canonical-adoption action defined by the Work Item occurs;
- project authority/navigation is durably updated;
- post-integration verification confirms the canonical pointer;
- no material contradiction or blocker remains.

Only then:

ANDROID_WORKFLOW:
CURRENT_CANONICAL_WORKFLOW

ANDROID_UNITY_GAME_PROFILE:
CURRENT_SUBORDINATE_PROFILE

Old workflow:
SUPERSEDED / HISTORICAL_PROVENANCE

The Unity/Game profile remains conditionally activated only for applicable Unity/Game Work Items.

Never permit:
- two CURRENT_CANONICAL workflows;
- zero CURRENT_CANONICAL workflows;
- a canonical pointer change solely because a PR receives SEMANTIC_ACCEPTED.

## 6. Local execution agent

Astra = EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT.

Astra is not a new authority class.

Default:
REPOSITORY_WRITE = NO.

Future local/runtime activities use, when material:
- EXTERNAL_ACTOR_ACTIVITY;
- LOCAL_TEST_PACKET;
- LOCAL_RESULT.

Evidence/execution states may include:
- PASS;
- FAIL;
- BLOCKED;
- NOT_RUN;
- STALE_RESULT;
- DUPLICATE_RESULT.

These are not Supervisor semantic decisions:
- SEMANTIC_ACCEPTED;
- REWORK;
- HOLD;
- ESCALATE.

If repository correction is required:

REPOSITORY_CHANGE_REQUIRED: YES
→ return to Supervisor/Implementer.

## 7. Evidence continuity

Existing exact-SHA evidence and Supervisor decisions for #73, #74, #75, #76, #77, #83, #84, #85 and PRs #78, #79, #80, #81, #82, #84, #86 remain valid according to their original exact source/evidence identity.

Do not rerun valid evidence solely because workflow vocabulary changes.

Use STALE_RESULT only when material source/configuration/test identity changes.
Use DUPLICATE_RESULT when equivalent durable evidence already exists and a rerun adds no required proof.

## 8. Prototype anti-bottleneck

Do not make these automatic for every change:
- full device matrix;
- profiler;
- performance suite;
- formal playtest;
- Vertical Slice;
- AAB;
- release signing;
- release validation;
- full regression;
- exhaustive traceability;
- full repository documentation audit;
- research "just in case".

They activate only through Acceptance Criteria, risk, evidence need, project specification, maturity, or material unknown.

## 9. Current execution boundary

Issue #87 implements adoption repository state only.

Stage 2 remains PAUSED.
Do not execute Unity, Astra/local execution, Android builds, APK/AAB, device/performance tests, X46, asset imports, gameplay, production content, or Stage 3 during Issue #87.

After this adoption HEAD is created, it remains State A until exact-SHA Supervisor review. If SEMANTIC_ACCEPTED is issued, it becomes State B only. State C requires separate durable integration/adoption and post-integration verification.
