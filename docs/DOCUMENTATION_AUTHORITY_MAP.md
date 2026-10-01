# Documentation Authority Map

Execution state: Stage 2 PAUSED.

## Reading order

1. README.md.
2. workflow/PROJECT_WORKFLOW_AUTHORITY.md.
3. workflow/PROJECT_WORKFLOW_OVERLAY.md.
4. PROJECT_AUTHORITY.md.
5. docs/specifications/INDEX.md.
6. docs/specifications/SPEC_FREEZE_MATRIX.md.
7. docs/CURRENT_TRACEABILITY_MATRIX.md.
8. analysis/findings/BLOCKING_GAP_REGISTER.md.
9. workflow/research/SESSION_HANDOFF.md.

## Workflow authority resolution

Current workflow authority must be reconstructed from GitHub rather than from a static transition label.

Read:
- PR #89 integration state;
- latest applicable Supervisor checkpoint in Issue #87;
- workflow/PROJECT_WORKFLOW_AUTHORITY.md.

If PR #89 is not durably integrated, OR no later applicable Supervisor checkpoint confirms successful post-integration canonical-pointer verification:
- former G_INF_01 workflow = CURRENT_CANONICAL_REFERENCE;
- workflow/adopted/ANDROID_WORKFLOW.md = NOT_YET_CANONICAL;
- workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md = NOT_YET_CANONICAL.

If PR #89 is durably integrated AND the latest applicable Supervisor checkpoint confirms successful post-integration canonical-pointer verification with no material blocker:
- workflow/adopted/ANDROID_WORKFLOW.md / blob 44eef0edb75781885879e8c2ae8d09114d27bb99 = CURRENT_CANONICAL_WORKFLOW;
- workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md / blob 3c3d846e1a3c1d90598e9e64cedff06e27a83269 = CURRENT_SUBORDINATE_PROFILE when materially applicable;
- workflow/PROJECT_WORKFLOW_OVERLAY.md = current durable project-specific operational overlay;
- former G_INF_01 workflow at 3138299c54e590a38b1a3fd51263abcff32afe53 / blob 83406e15c3462f4acb8e94eb28de85f6b3850692 = SUPERSEDED / HISTORICAL_PROVENANCE.

SEMANTIC_ACCEPTED alone does not establish State C.

## Project authority chain

- Product-freeze Human authority: Issue #57 comment 5914691381.
- Accepted specification snapshot: PR #71 / docs/issue-64-spec-freeze@09061b4ba372de41fb142ab4c43f1b4302f58083, Supervisor review 5368899526.
- Documentation gate: PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a, Supervisor review 5374045969.
- Adoption preparation: PR #86 HEAD 688158eb8b3cad99d43a9de35308f40e4568d9a1, Supervisor review 5374533044.
- Adoption implementation: PR #88 reviewed HEAD 7f5f8caf7b03fefb4ef3286dd4831b3387306bfe, merged as 3a4cca27dc049889b19878b6a20bb58c5f15b448.
- Workflow-pointer finalization: Issue #87 / PR #89; current operational state comes from its integration state plus latest applicable Supervisor checkpoint.

## Product specification boundary

Project/game specifications remain independent of workflow adoption. Do not move Santa/helpers/gates/boss/stage rules, 30 FPS acceptance, device/performance requirements, VUX/onboarding/content, or gameplay tuning into workflow/profile documents.

## Evidence continuity

Existing exact-SHA evidence and Supervisor decisions remain preserved. Workflow vocabulary changes do not invalidate valid evidence.

## Supporting/historical boundary

technical/stage2/** remains supporting evidence of the paused technical tranche.

research/**, analysis/comparisons/**, and historical ADR/research material remain evidence unless a current authoritative spec explicitly incorporates a statement.

plan/IMPLEMENTATION_PLAN.md and new-code/IMPLEMENTATION_INVENTORY.md remain planning aids and do not authorize work.
