# WORKFLOW ADOPTION READINESS — Issue #85

Status: PREPARATION_ONLY / NOT_ACTIVATED
Base: docs/documentation-readiness-gate@f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a

## Source identity

| Source | Exact identity | Blob / review | Result |
|---|---|---|---|
| Current project workflow reference | cmiloarevalo-hash/G_INF_01@3138299c54e590a38b1a3fd51263abcff32afe53 / WORKFLOW_CANONICO_SUPERVISOR_GITHUB_IMPLEMENTADOR_AI_STUDIO.md | 83406e15c3462f4acb8e94eb28de85f6b3850692 | VERIFIED |
| Proposed Android workflow | cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9 / workpacks/workflow-operationalization-01/ANDROID_WORKFLOW.md | 44eef0edb75781885879e8c2ae8d09114d27bb99 | VERIFIED |
| Proposed Unity/Game profile | cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9 / workpacks/workflow-operationalization-01/ANDROID_UNITY_GAME_PROFILE.md | 3c3d846e1a3c1d90598e9e64cedff06e27a83269 | VERIFIED |
| Current accepted project documentation checkpoint | PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a | Supervisor review 5374045969 | SEMANTIC_ACCEPTED / DOCUMENTATION_GATE_ACCEPTED |

SOURCE_IDENTITY: PASS.

## Current authority

Until a later explicit adoption Work Item is accepted and activated, the current project workflow remains the existing canonical workflow reference. The two W-F-Android documents are exact proposal/adoption sources for #85 only; their presence and this preparation do not create project workflow authority.

Current project/game specifications remain separately authoritative for product requirements. Issue #85 is the current transition hold and prohibits Stage 2 execution while this preparation is active.

AUTHORITY_NON_REGRESSION: PASS.

## Required layering

The prepared target layering is:

1. ANDROID_WORKFLOW — universal Android lifecycle/governance.
2. ANDROID_UNITY_GAME_PROFILE — Unity/Game operational extension.
3. Risk/maturity/evidence-triggered controls — local actor, device, performance, playtest, readiness, provenance only when triggered.
4. CURRENT PROJECT/GAME SPECIFICATIONS — concrete product/game requirements and thresholds.

Required invariants are preserved:

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

ANDROID_PROFILE_LAYERING: PASS.
UNITY_PROFILE_LAYERING: PASS.

## Current workflow coverage and migration posture

The current workflow and ANDROID_WORKFLOW agree materially on:
- Human / Supervisor / Implementer authority separation;
- six-field Work Item contract: Objective, Acceptance Criteria, Authorized Scope, Relevant Sources, Verification, Base;
- Semantic Scope vs Path Scope;
- exact-SHA semantic review;
- REWORK continuity in same Issue/branch/PR when objective/scope stay valid;
- semantic decisions SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE;
- CI/tests as evidence rather than approval;
- semantic acceptance separate from merge eligibility;
- Human-only product publication;
- GitHub as durable state;
- bounded research gate for mutable external facts;
- recovery/handoff from repository state, not chat memory.

The Android workflow extends these rules with Android environment/readiness/device/signing/external-actor detail. No rule in the inspected exact source requires changing project product semantics.

CURRENT_WORKFLOW_COVERAGE: PASS.

## Merge/integration boundary

The current project workflow contains an explicit project-specific rule assigning merge execution to the Supervisor only after exact-SHA semantic acceptance plus MERGE_ELIGIBLE checks. ANDROID_WORKFLOW does not contradict this: it requires separate merge eligibility and existing governing merge authority.

Migration item: preserve the project-specific merge-authority decision explicitly as project authority/overlay when adopting the generic workflow. Do not infer merge permission from the generic document itself.

No ARCHITECTURE_DECISION_REQUIRED is triggered by this difference.

## Publication boundary

Both sources preserve PUBLISH = HUMAN ACTION. No migration decision is required.

## Research/freshness

Current RESEARCH_GATE + STRATEGIC_RATIONALE maps to ANDROID_WORKFLOW Research/Freshness Gate. Use ADAPT: retain material-current-fact gating while adopting the newer proportional rule against research "just in case".

## External actor / Astra mapping

Astra maps to:

EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT

This is not a new authority class.

Preserve from the current Astra model:
- exact target SHA binding;
- read/execute/test-only default;
- no semantic approval;
- no source correction by local actor;
- compact evidence return;
- Implementer owns repository fixes;
- new SHA requires renewed test authority/evidence binding;
- PASS/FAIL/BLOCKED are evidence states, not semantic decisions.

Adapt to the profile:
- ASTRA_LOCAL_TEST_PACKET -> LOCAL_TEST_PACKET;
- Astra result -> LOCAL_RESULT;
- persist an EXTERNAL_ACTOR_ACTIVITY when the local capability is invoked;
- use STALE_RESULT / DUPLICATE_RESULT instead of rerunning equivalent valid evidence;
- classify failures diagnostically without converting failure class into REWORK/HOLD automatically.

Current AI_STUDIO_OPERATOR provider-specific assumptions are not generalized to Astra. AI Studio-specific preview/materialization/request-mode rules remain actor-specific historical/subordinate rules unless a later Work Item explicitly needs that actor.

LOCAL_AGENT_MAPPING: PASS.

## Game specification boundary

The workflow/profile must not absorb:
- Santa/gates/boss/level rules;
- 30 FPS target;
- selected device tier;
- game performance budgets;
- VUX requirements;
- game-specific content/UX.

Those remain in current project/game specifications. The Unity profile explicitly defines execution/evidence mechanics, not game behavior or numeric product thresholds.

GAME_SPEC_BOUNDARY: PASS.

## Open work transition #73–#84

| Work/evidence | Transition |
|---|---|
| #73 / PR #78 HEAD c8af0b68bf87c6560a5f8b9d42699ccd65210940 | PRESERVE repository rework and Supervisor exact-SHA local-retest acceptance. Stage 2A is still not accepted complete. Future local execution should use profile LOCAL_TEST_PACKET/LOCAL_RESULT without rerunning repository checks unless target/material identity changes. |
| #74 / PR #79 HEAD 11391e4fc169ea256059a112e939d92acd222d27 | PRESERVE accepted blocker checkpoint. After #73 completion, future build/device work transitions to profile evidence model; prior blocker evidence is not invalidated by workflow adoption. |
| #75 / PR #80 HEAD c4d6184a296b810db12f8972ce33820a888e0109 | PRESERVE accepted experiment contract and NOT_RUN state. No benchmark exists to rerun. Execute later only after authorization using profile evidence fields. |
| #76 / PR #81 HEAD 292b6a91f6f8bb43926df448610b827738f08454 | PRESERVE BLOCKED_BY_DEVICE_SELECTION evidence. Device/performance controls activate only when prerequisites exist. |
| #77 / PR #82 HEAD cccc71092a8f9c6ac9c5377e8ffe5ed77a69d323 | PRESERVE provenance/asset-selection blocker. Profile does not bypass project provenance gates. |
| #83 / PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a | PRESERVE DOCUMENTATION_GATE_ACCEPTED exact-SHA evidence. No documentation gate rerun is required merely because workflow adoption is prepared. |
| PRs #78–#82 | Preserve current PR history, exact reviewed SHAs, blockers and reviews. Adoption must not rewrite historical evidence or silently transfer acceptance to later SHAs. |
| Issue #85 | Current transition preparation authority only; no Stage 2 resume and no workflow activation. |

OPEN_WORK_TRANSITION: PASS.

## Anti-bottleneck

The profile explicitly prohibits making full device matrices, profiler runs, performance suites, formal playtests, Vertical Slice, AAB/release signing, full regression, exhaustive trace chains, checkpoint-per-edit, or broad research mandatory for every prototype change. Controls are triggered only by Acceptance Criteria, risk, evidence need, project specification, maturity, or material unknown.

This is compatible with the project's existing Stage 2 design: preserve valid evidence; execute X46/device/provenance work only when its existing prerequisites and authorization apply.

ANTI_BOTTLENECK_PRESERVED: PASS.

## Conflicts / decisions

AUTHORITY_CONFLICTS: NONE FOUND.

No unresolved conflict was found affecting authority, lifecycle, exact-SHA semantics, merge, publication, or formal semantic state vocabulary. Therefore no ARCHITECTURE_DECISION_REQUIRED is raised by this preparation.

Explicit migration items remain necessary:
1. establish a single canonical workflow pointer during actual adoption;
2. preserve project-specific Supervisor merge authority as explicit existing authority, not as a generic Android inference;
3. activate Unity profile only for applicable Unity/Game Work Items;
4. map Astra/local execution records to the new external-actor/profile vocabulary;
5. classify the old canonical workflow as superseded/historical only after the new exact adoption SHA is Supervisor-accepted;
6. preserve exact-SHA evidence and avoid unnecessary reruns.

## Documentary verification

- SOURCE_IDENTITY: PASS
- AUTHORITY_NON_REGRESSION: PASS
- CURRENT_WORKFLOW_COVERAGE: PASS
- ANDROID_PROFILE_LAYERING: PASS
- UNITY_PROFILE_LAYERING: PASS
- GAME_SPEC_BOUNDARY: PASS
- LOCAL_AGENT_MAPPING: PASS
- OPEN_WORK_TRANSITION: PASS
- ANTI_BOTTLENECK_PRESERVED: PASS
- NO_DUAL_CANONICAL_WORKFLOW: PASS by activation design
- ACTIVATION_PLAN_COMPLETE: PASS

## Conclusion

ADOPTION_READINESS: ADOPTION_READY_WITH_EXPLICIT_MIGRATION_ITEMS

This is readiness for a later separately authorized adoption Work Item. It is not adoption or activation.
