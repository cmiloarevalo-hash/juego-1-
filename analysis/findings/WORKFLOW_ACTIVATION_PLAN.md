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

## Activation sequence

### A. Establish one canonical workflow path

1. Incorporate or reference the exact ANDROID_WORKFLOW source through the activation Work Item.
2. Incorporate or reference the exact Unity profile as an extension, never as standalone governance.
3. Update project navigation/authority to point to the new workflow path.
4. In the same activation change, mark the old project workflow reference as SUPERSEDED/HISTORICAL for this project.
5. Do not leave both old and new workflows described as CURRENT_CANONICAL.

Acceptance:
NO_DUAL_CANONICAL_WORKFLOW = PASS.

### B. Preserve layering

Navigation must state:

ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW.
ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW.
ANDROID_UNITY_GAME_PROFILE DOES NOT OVERRIDE AUTHORITY.
PROFILE ACTIVATION != NEW WORKFLOW AUTHORITY.

Current game specifications remain separate and authoritative for mechanics, VUX, thresholds, device/performance acceptance and content.

### C. Preserve project authority

Explicitly retain:
- Human product/material/publication authority;
- Supervisor semantic-review authority;
- current project-specific Supervisor merge authority only under its already-persisted conditions;
- Implementer no self-approval/no merge;
- exact-SHA review;
- SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE;
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE;
- PUBLISH = HUMAN ACTION.

Do not use profile activation to alter these.

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

At activation:
- update current authority/navigation to the one canonical workflow;
- update SESSION_HANDOFF to record activation Work Item, exact source provenance, activated profile applicability, current hold/work state and next legal action;
- keep game-spec navigation separate;
- keep historical workflow provenance accessible but visibly non-current.

### G. Acceptance tests for activation

Required:
1. SOURCE_IDENTITY: exact SHAs/blobs unchanged or explicitly re-reviewed.
2. AUTHORITY_NON_REGRESSION: Human/Supervisor/Implementer authority unchanged.
3. NO_DUAL_CANONICAL_WORKFLOW: exactly one current workflow path.
4. PROFILE_LAYERING: profile points to parent Android workflow and cannot override it.
5. GAME_SPEC_BOUNDARY: no Santa/gates/boss/30-FPS/device/VUX requirements migrated into workflow/profile.
6. EXACT_SHA: prior reviews remain bound to their historical exact SHAs; new adoption HEAD has separate review.
7. LOCAL_AGENT: Astra maps to LOCAL_EXECUTION_AGENT with no new authority.
8. OPEN_WORK: #73–#84 evidence/status is preserved.
9. MERGE: semantic acceptance checked separately from integration/merge eligibility.
10. PUBLICATION: remains Human action.
11. ANTI_BOTTLENECK: no release-grade controls become default for prototype work.
12. RECOVERY: new session can reconstruct workflow + profile + project specs + active Work Item from GitHub.

### H. Supervisor review and integration

1. Implementer hands off exact adoption HEAD.
2. Supervisor performs independent exact-SHA review.
3. SEMANTIC_ACCEPTED, if issued, applies only to that SHA.
4. Merge eligibility is checked separately.
5. No merge occurs without existing project merge authority and required integration checks.

### I. Rollback/recovery

If adoption introduces a material contradiction:
- do not partially operate under both workflows;
- issue REWORK/HOLD/ESCALATE as appropriate;
- keep the pre-adoption workflow current until the adoption SHA is accepted;
- if contradiction is discovered after activation but before merge/integration completion, restore the last unambiguous canonical pointer and preserve the failed adoption commit as evidence;
- if authority/lifecycle/state vocabulary cannot be mapped without changing governance, report ARCHITECTURE_DECISION_REQUIRED and stop.

Rollback must not delete historical evidence or silently transfer semantic acceptance across SHAs.

## Current/superseded/historical classification at actual activation

| Artifact | Before activation | After accepted activation |
|---|---|---|
| Existing project workflow reference | CURRENT CANONICAL | SUPERSEDED / HISTORICAL PROVENANCE |
| ANDROID_WORKFLOW exact adopted source | PROPOSAL SOURCE | CURRENT CANONICAL WORKFLOW |
| ANDROID_UNITY_GAME_PROFILE exact adopted source | PROPOSAL EXTENSION | CURRENT PROFILE EXTENDING ANDROID_WORKFLOW |
| Current project/game specifications | CURRENT AUTHORITATIVE | CURRENT AUTHORITATIVE, unchanged layer |
| Existing #73–#84 evidence/reviews | CURRENT/HISTORICAL SHA-bound evidence as applicable | PRESERVED SHA-bound evidence |

## Follow-up decisions

No architecture decision is required before a normal activation Work Item.

The activation Work Item must still obtain:
- explicit Supervisor semantic acceptance for the adoption HEAD;
- separate integration/merge eligibility;
- normal per-activity authority before any future local execution.

ACTIVATION_PLAN_COMPLETE: PASS.
