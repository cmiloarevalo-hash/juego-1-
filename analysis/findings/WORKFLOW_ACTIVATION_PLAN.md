# WORKFLOW ACTIVATION PLAN — Issue #85

Status: PLAN_ONLY / DO_NOT_EXECUTE_IN_ISSUE_85

## Goal

A later separately authorized Work Item may activate:

ANDROID_WORKFLOW
+
ANDROID_UNITY_GAME_PROFILE
+
CURRENT PROJECT/GAME SPECIFICATIONS

without two simultaneously canonical workflows and without invalidating existing exact-SHA evidence.

## Preconditions

1. Issue #85 receives Supervisor SEMANTIC_ACCEPTED on its exact PR HEAD.
2. A separate adoption/activation Work Item defines Semantic Scope, Path Scope, exact source identities and Base.
3. No adoption action is inferred from #85 readiness alone.

## Exact adoption sources

- cmiloarevalo-hash/W-F-Android@2c8fa140b307db8607ffb919970bf9a266dd1df9
- ANDROID_WORKFLOW.md blob 44eef0edb75781885879e8c2ae8d09114d27bb99
- ANDROID_UNITY_GAME_PROFILE.md blob 3c3d846e1a3c1d90598e9e64cedff06e27a83269
- current project documentation checkpoint PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a, review 5374045969
- current workflow reference G_INF_01@3138299c54e590a38b1a3fd51263abcff32afe53, blob 83406e15c3462f4acb8e94eb28de85f6b3850692

The activation Work Item must refetch these identities. Any source SHA/blob change requires renewed migration review.

## Canonical transition — mandatory three-state model

### STATE A — BEFORE SEMANTIC ACCEPTANCE

- Existing project workflow: CURRENT_CANONICAL_REFERENCE.
- ANDROID_WORKFLOW: PROPOSED_ADOPTION_SOURCE.
- ANDROID_UNITY_GAME_PROFILE: PROPOSED_EXTENSION.
- No canonical authority/navigation pointer changes.

### STATE B — AFTER SEMANTIC_ACCEPTED, BEFORE INTEGRATION / DURABLE ADOPTION

- Existing project workflow: STILL CURRENT_CANONICAL_REFERENCE.
- New adoption HEAD: SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL.
- No canonical authority/navigation pointer changes.
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.
- SEMANTIC_ACCEPTED != CANONICAL_ADOPTION.

The project must continue operating under the old canonical workflow in this state.

### STATE C — AFTER AUTHORIZED DURABLE ADOPTION

Transition to State C only after all applicable conditions hold:
1. exact adoption HEAD has Supervisor SEMANTIC_ACCEPTED;
2. separate MERGE_ELIGIBLE checks pass;
3. authorized integration/merge or another explicit durable canonical-adoption action defined by the adoption Work Item occurs;
4. project authority/navigation is durably updated to the new canonical path;
5. post-integration verification confirms the canonical pointer;
6. no material contradiction or blocker remains.

Only then:
- ANDROID_WORKFLOW = CURRENT_CANONICAL_WORKFLOW;
- ANDROID_UNITY_GAME_PROFILE = CURRENT_SUBORDINATE_PROFILE, activated only for applicable Unity/Game Work Items;
- existing project workflow = SUPERSEDED / HISTORICAL_PROVENANCE.

Hard invariant:
- never two CURRENT_CANONICAL workflows;
- never zero CURRENT_CANONICAL workflows;
- never change the canonical pointer solely because a PR receives SEMANTIC_ACCEPTED.

CANONICAL_TRANSITION_THREE_STATE_MODEL = PASS.
NO_DUAL_CANONICAL_WORKFLOW = PASS.

## Activation sequence

### A. Establish one canonical workflow path

The following operations belong only to the authorized durable adoption action that transitions State B → State C; they do not occur merely on semantic acceptance.

1. Incorporate or reference the exact ANDROID_WORKFLOW source through the activation Work Item.
2. Incorporate or reference the exact Unity profile as an extension, never as standalone governance.
3. Persist the project-specific operational overlays required by migration, including the Implementer checkout/bootstrap/recovery rule.
4. Perform the authorized integration/merge or other durable canonical-adoption action defined by the Work Item only after MERGE_ELIGIBLE.
5. Update project navigation/authority durably to point to the new workflow path as part of that authorized action.
6. Mark the old project workflow reference SUPERSEDED/HISTORICAL only when the new canonical pointer is durable.
7. Verify post-integration that exactly one CURRENT_CANONICAL workflow pointer exists.

Acceptance:
NO_DUAL_CANONICAL_WORKFLOW = PASS.

### B. Preserve layering

Navigation must state:

ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW.
ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW.
ANDROID_UNITY_GAME_PROFILE DOES NOT OVERRIDE AUTHORITY.
PROFILE ACTIVATION != NEW WORKFLOW AUTHORITY.

Current game specifications remain separate and authoritative for mechanics, VUX, thresholds, device/performance acceptance and content.

### C. Preserve project authority and current-canonical operational deltas

Explicitly retain:
- Human product/material/publication authority;
- Supervisor semantic-review authority;
- current project-specific Supervisor merge authority only under its already-persisted conditions;
- Implementer no self-approval/no merge;
- exact-SHA review;
- SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE;
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE;
- PUBLISH = HUMAN ACTION.

Persist the current Implementer checkout/bootstrap/recovery rule as a durable project-specific operational overlay or equivalent project rule:
- reuse the existing checkout/workspace supplied by the authorized implementation channel;
- verify repository cwd, expected origin, git status, current HEAD, current branch and required Base before editing;
- git fetch origin may refresh remote refs;
- git clone is not normal bootstrap/recovery;
- do not create a second clone, move/reconstruct the repository into another workspace, or use an alternate/unverified origin by initiative;
- if no usable/verifiable checkout exists: STOP → Supervisor; RESULT: BLOCKED; CLASSIFICATION: IMPLEMENTER_ENVIRONMENT; REASON: CANONICAL_CHECKOUT_UNAVAILABLE;
- exceptional clone recovery requires explicit Supervisor authorization.

This overlay must have a durable project location/reference before the old workflow may become historical. Do not use profile activation to alter these rules.

### D. Transition external/local actors

1. Map Astra to EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT.
2. Future local execution creates a bounded EXTERNAL_ACTOR_ACTIVITY when material.
3. Use LOCAL_TEST_PACKET and LOCAL_RESULT for new activities.
4. Default repository write remains NO.
5. If local execution reports REPOSITORY_CHANGE_REQUIRED, return to Supervisor/Implementer.
6. Existing AI_STUDIO_OPERATOR-specific material remains historical/subordinate actor-specific material; it does not become the new canonical workflow.

### E. Transition open work without evidence loss

For #73–#77 and PRs #78–#82:
- preserve Issue/branch/PR history;
- preserve exact reviewed SHAs and Supervisor decisions;
- preserve valid build/test/blocker/provenance evidence;
- do not rerun valid evidence solely because workflow vocabulary changed;
- translate future handoffs/activities to the new schemas at the next material action;
- mark evidence STALE_RESULT only if the material source/config/test tuple changed;
- mark DUPLICATE_RESULT when an equivalent durable result already exists and rerun adds no required proof.

For #83/PR #84:
- retain DOCUMENTATION_GATE_ACCEPTED at exact f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a;
- no documentation-gate rerun solely due adoption.

### F. Navigation/handoff update

During the authorized durable adoption action that performs State B → State C:
- update current authority/navigation to the one canonical workflow;
- durably reference the preserved project-specific checkout/bootstrap/recovery overlay;
- update SESSION_HANDOFF to record activation Work Item, exact source provenance, activated profile applicability, current hold/work state and next legal action;
- keep game-spec navigation separate;
- keep historical workflow provenance accessible but visibly non-current;
- post-integration verify that the canonical pointer resolves to the new workflow and that the old workflow is no longer marked current.

### G. Acceptance tests for activation

Required:
1. SOURCE_IDENTITY: exact SHAs/blobs unchanged or explicitly re-reviewed.
2. AUTHORITY_NON_REGRESSION: Human/Supervisor/Implementer authority and preserved project checkout/bootstrap/recovery rule unchanged.
3. NO_DUAL_CANONICAL_WORKFLOW: exactly one current workflow path throughout States A/B/C.
4. PROFILE_LAYERING: profile points to parent Android workflow and cannot override it.
5. GAME_SPEC_BOUNDARY: no Santa/gates/boss/30-FPS/device/VUX requirements migrated into workflow/profile.
6. EXACT_SHA: prior reviews remain bound to their historical exact SHAs; new adoption HEAD has separate review.
7. LOCAL_AGENT: Astra maps to LOCAL_EXECUTION_AGENT with no new authority.
8. OPEN_WORK: #73–#84 evidence/status is preserved.
9. MERGE: semantic acceptance checked separately from integration/merge eligibility.
10. PUBLICATION: remains Human action.
11. ANTI_BOTTLENECK: no release-grade controls become default for prototype work.
12. RECOVERY: new session can reconstruct workflow + profile + project specs + active Work Item from GitHub.
13. CHECKOUT_RULE_PRESERVED: project overlay durably preserves the current checkout/bootstrap/recovery semantics.
14. CANONICAL_TRANSITION_THREE_STATE_MODEL: State A/B/C classification and switch conditions are explicitly verified.

### H. Supervisor review and integration

1. Implementer hands off exact adoption HEAD.
2. Supervisor performs independent exact-SHA review.
3. SEMANTIC_ACCEPTED, if issued, applies only to that SHA and places the adoption in State B; it does not make the workflow canonical.
4. Merge eligibility is checked separately.
5. No integration/merge or durable canonical-adoption action occurs without existing project authority and required integration checks.
6. After the authorized durable adoption action, verify the project authority/navigation pointer; only successful verification establishes State C.

### I. Rollback/recovery

If adoption introduces a material contradiction:
- do not partially operate under both workflows;
- issue REWORK/HOLD/ESCALATE as appropriate;
- keep the pre-adoption workflow CURRENT_CANONICAL through State A and State B, including after semantic acceptance, until the authorized durable State C transition completes and is verified;
- if contradiction is discovered during integration/adoption before State C verification, retain/restore the last unambiguous old canonical pointer and preserve the failed adoption commit as evidence;
- if authority/lifecycle/state vocabulary cannot be mapped without changing governance, report ARCHITECTURE_DECISION_REQUIRED and stop.

Rollback must not delete historical evidence or silently transfer semantic acceptance across SHAs.

## Current/superseded/historical classification across the transition

| Artifact | State A — before semantic acceptance | State B — accepted for integration, not canonical | State C — durable adoption verified |
|---|---|---|---|
| Existing project workflow reference | CURRENT_CANONICAL_REFERENCE | CURRENT_CANONICAL_REFERENCE | SUPERSEDED / HISTORICAL_PROVENANCE |
| ANDROID_WORKFLOW exact adopted source | PROPOSED_ADOPTION_SOURCE | SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL | CURRENT_CANONICAL_WORKFLOW |
| ANDROID_UNITY_GAME_PROFILE exact adopted source | PROPOSED_EXTENSION | SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL | CURRENT_SUBORDINATE_PROFILE; conditional per Unity/Game Work Item |
| Preserved project checkout/bootstrap/recovery rule | CURRENT rule inside old canonical workflow | CURRENT rule still governed through old canonical workflow; adoption overlay prepared | CURRENT project-specific operational overlay/equivalent durable project rule |
| Current project/game specifications | CURRENT_AUTHORITATIVE | CURRENT_AUTHORITATIVE | CURRENT_AUTHORITATIVE, unchanged layer |
| Existing #73–#84 evidence/reviews | SHA-bound evidence preserved | SHA-bound evidence preserved | SHA-bound evidence preserved |

## Follow-up decisions

No architecture decision is required before a normal activation Work Item.

The activation Work Item must still obtain:
- explicit Supervisor semantic acceptance for the adoption HEAD;
- separate integration/merge eligibility;
- authorized integration/merge or other durable canonical-adoption action;
- post-integration verification of the durable canonical pointer and preserved operational overlays;
- normal per-activity authority before any future local execution.

ACTIVATION_PLAN_COMPLETE: PASS.
