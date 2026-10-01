# Documentation Authority Map

Status: CURRENT_AUTHORITATIVE navigation for Issue #87.  
Execution state: WORKFLOW ADOPTION HOLD / Stage 2 PAUSED.

## Reading order for a new Implementer

1. README.md — current project/adoption status.
2. This file — authority/navigation map.
3. workflow/PROJECT_WORKFLOW_AUTHORITY.md — current workflow state, provenance and State A/B/C transition.
4. workflow/PROJECT_WORKFLOW_OVERLAY.md — preserved project-specific operational rules.
5. PROJECT_AUTHORITY.md — frozen product boundary.
6. docs/specifications/INDEX.md — accepted project/game specification set.
7. docs/specifications/SPEC_FREEZE_MATRIX.md — product decision/status mapping.
8. docs/CURRENT_TRACEABILITY_MATRIX.md — product → spec → implementation/plan → verification → status.
9. analysis/findings/BLOCKING_GAP_REGISTER.md — unresolved measurement/provenance state.
10. workflow/research/SESSION_HANDOFF.md — current Work Item/checkpoint.

## Workflow authority chain — current Issue #87 state

Current State A:
- Old canonical workflow source: cmiloarevalo-hash/G_INF_01@3138299c54e590a38b1a3fd51263abcff32afe53 / WORKFLOW_CANONICO_SUPERVISOR_GITHUB_IMPLEMENTADOR_AI_STUDIO.md / blob 83406e15c3462f4acb8e94eb28de85f6b3850692 = CURRENT_CANONICAL_REFERENCE.
- workflow/adopted/ANDROID_WORKFLOW.md / blob 44eef0edb75781885879e8c2ae8d09114d27bb99 = PROPOSED_ADOPTION_SOURCE.
- workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md / blob 3c3d846e1a3c1d90598e9e64cedff06e27a83269 = PROPOSED_EXTENSION.
- workflow/PROJECT_WORKFLOW_AUTHORITY.md governs project adoption semantics.
- workflow/PROJECT_WORKFLOW_OVERLAY.md preserves project-specific rules absent from the imported Android workflow.

State B, if the exact adoption HEAD receives SEMANTIC_ACCEPTED:
- old workflow remains CURRENT_CANONICAL_REFERENCE;
- new adoption HEAD becomes SEMANTIC_ACCEPTED_FOR_INTEGRATION / NOT_YET_CANONICAL;
- no canonical pointer changes.

State C exists only after separate MERGE_ELIGIBLE, authorized durable adoption/integration, durable authority/navigation update and post-integration pointer verification:
- ANDROID_WORKFLOW becomes CURRENT_CANONICAL_WORKFLOW;
- ANDROID_UNITY_GAME_PROFILE becomes CURRENT_SUBORDINATE_PROFILE where applicable;
- old workflow becomes SUPERSEDED / HISTORICAL_PROVENANCE.

Never infer State C from PR existence or SEMANTIC_ACCEPTED alone.

## Project authority chain

- Product-freeze Human authority: Issue #57 comment 5914691381.
- Canonical accepted specification snapshot: PR #71 / docs/issue-64-spec-freeze@09061b4ba372de41fb142ab4c43f1b4302f58083, Supervisor review 5368899526.
- Preimplementation bounded Stage 2 authorization: PR #72 / reviewed audit evidence; it never authorized product gameplay.
- Stage 2A technical checkpoint: PR #78 / tech/issue-73-unity-android-bootstrap@c8af0b68bf87c6560a5f8b9d42699ccd65210940; execution remains incomplete.
- Documentation gate: PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a, Supervisor review 5374045969 = DOCUMENTATION_GATE_ACCEPTED.
- Adoption preparation: PR #86 HEAD 688158eb8b3cad99d43a9de35308f40e4568d9a1, Supervisor review 5374533044 = SEMANTIC_ACCEPTED / ADOPTION_READY_WITH_EXPLICIT_MIGRATION_ITEMS.
- Active authority: Issue #87 workflow adoption implementation, State A until Supervisor exact-SHA review.

## Classification rules

- CURRENT_AUTHORITATIVE: current product/spec/navigation requirements.
- CURRENT_SUPPORTING: current evidence/status supporting authority but not itself a product decision.
- HISTORICAL_EVIDENCE: useful prior research/evidence; never executable requirements.
- SUPERSEDED: a later durable accepted authority replaces relevant content.
- REFERENCE_ONLY: technical/source material not selected as implementation authority.
- STALE_MUST_FIX: current-looking text contradicting authority.
- REMOVE_FROM_CURRENT_NAVIGATION_BUT_PRESERVE_HISTORY: retain in Git but do not present as current path.

## Product specification boundary

Project/game specifications remain independent of workflow adoption. Do not move Santa/helpers/gates/boss/stage rules, 30 FPS acceptance, device/performance requirements, VUX/onboarding/content, or gameplay tuning into workflow/profile documents.

## Evidence continuity

Existing exact-SHA evidence and Supervisor decisions for #73–#85 and PRs #78–#86 remain preserved. A vocabulary transition does not invalidate valid evidence.

## Supporting/historical boundary

technical/stage2/** remains supporting evidence of the paused technical tranche and is not executable during Issue #87.

research/**, analysis/comparisons/** and historical ADR/research material remain evidence unless a current authoritative spec explicitly incorporates a statement.

plan/IMPLEMENTATION_PLAN.md and new-code/IMPLEMENTATION_INVENTORY.md remain planning aids and do not authorize work.
