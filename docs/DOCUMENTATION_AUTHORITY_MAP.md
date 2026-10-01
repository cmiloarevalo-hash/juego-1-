# Documentation Authority Map

Status: CURRENT_AUTHORITATIVE navigation / Issue #87 State C finalization candidate.  
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

## Workflow transition checkpoint

Durable integration already completed for PR #88 at merge commit 3a4cca27dc049889b19878b6a20bb58c5f15b448.

Supervisor checkpoint 5924268175:
STATE B / INTEGRATED_BUT_CANONICAL_POINTER_NOT_FINALIZED.

This follow-up finalization encodes the State C pointer but State C is established only after this exact finalization HEAD receives SEMANTIC_ACCEPTED, separate MERGE_ELIGIBLE, authorized durable integration, and post-integration pointer verification.

### State C pointer after those conditions pass

- workflow/adopted/ANDROID_WORKFLOW.md / blob 44eef0edb75781885879e8c2ae8d09114d27bb99 = CURRENT_CANONICAL_WORKFLOW.
- workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md / blob 3c3d846e1a3c1d90598e9e64cedff06e27a83269 = CURRENT_SUBORDINATE_PROFILE when materially applicable.
- workflow/PROJECT_WORKFLOW_OVERLAY.md = current durable project-specific operational overlay.
- former G_INF_01 workflow at 3138299c54e590a38b1a3fd51263abcff32afe53 / blob 83406e15c3462f4acb8e94eb28de85f6b3850692 = SUPERSEDED / HISTORICAL_PROVENANCE.

Never infer State C from semantic acceptance alone.

## Project authority chain

- Product-freeze Human authority: Issue #57 comment 5914691381.
- Accepted specification snapshot: PR #71 / docs/issue-64-spec-freeze@09061b4ba372de41fb142ab4c43f1b4302f58083, Supervisor review 5368899526.
- Documentation gate: PR #84 HEAD f63b70ab3b2c75dc1c522e4f67fcdc7e96803b3a, Supervisor review 5374045969.
- Adoption preparation: PR #86 HEAD 688158eb8b3cad99d43a9de35308f40e4568d9a1, Supervisor review 5374533044.
- Adoption implementation: PR #88 reviewed HEAD 7f5f8caf7b03fefb4ef3286dd4831b3387306bfe, merged as 3a4cca27dc049889b19878b6a20bb58c5f15b448.
- Current Work Item: Issue #87 State C finalization.

## Product specification boundary

Project/game specifications remain independent of workflow adoption. Do not move Santa/helpers/gates/boss/stage rules, 30 FPS acceptance, device/performance requirements, VUX/onboarding/content, or gameplay tuning into workflow/profile documents.

## Evidence continuity

Existing exact-SHA evidence and Supervisor decisions remain preserved. Workflow vocabulary changes do not invalidate valid evidence.

## Supporting/historical boundary

technical/stage2/** remains supporting evidence of the paused technical tranche.

research/**, analysis/comparisons/**, and historical ADR/research material remain evidence unless a current authoritative spec explicitly incorporates a statement.

plan/IMPLEMENTATION_PLAN.md and new-code/IMPLEMENTATION_INVENTORY.md remain planning aids and do not authorize work.
