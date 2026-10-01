# Current Knowledge Index

## Workflow-state resolution

Do not treat this file as a frozen review-state snapshot.

Determine current workflow authority from:
- PR #89 durable integration state;
- the latest applicable Supervisor checkpoint in Issue #87;
- [Project Workflow Authority](workflow/PROJECT_WORKFLOW_AUTHORITY.md).

Before durable integration plus successful post-integration verification:
- former G_INF_01 workflow = CURRENT_CANONICAL_REFERENCE;
- adopted Android workflow/profile = NOT_YET_CANONICAL.

After both conditions are satisfied and confirmed in Issue #87:
- [ANDROID_WORKFLOW](workflow/adopted/ANDROID_WORKFLOW.md) = CURRENT_CANONICAL_WORKFLOW;
- [ANDROID_UNITY_GAME_PROFILE](workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md) = CURRENT_SUBORDINATE_PROFILE when materially applicable;
- former G_INF_01 workflow = SUPERSEDED / HISTORICAL_PROVENANCE.

## Required project path

- [Documentation Authority Map](docs/DOCUMENTATION_AUTHORITY_MAP.md)
- [Project Workflow Authority](workflow/PROJECT_WORKFLOW_AUTHORITY.md)
- [Project Workflow Overlay](workflow/PROJECT_WORKFLOW_OVERLAY.md)
- [Project Authority](PROJECT_AUTHORITY.md)
- [Product Specifications](docs/specifications/INDEX.md)
- [Current Traceability Matrix](docs/CURRENT_TRACEABILITY_MATRIX.md)
- [Blocking Gap Register](analysis/findings/BLOCKING_GAP_REGISTER.md)
- [Session Handoff](workflow/research/SESSION_HANDOFF.md)

## Current supporting evidence

- [Reuse matrix](reuse/REUSE_MATRIX.md)
- [Sources](sources/INDEX.md)
- [Stage 2 technical evidence](technical/stage2/BOOTSTRAP_BASELINE.md) — preserved; Stage 2 remains paused.

## Historical evidence

- [Research index](research/INDEX.md)
- [Historical ADRs / research gates](decisions/adr/RESEARCH_GATES.md)
- [Historical final traceability audit](analysis/findings/FINAL_TRACEABILITY_AUDIT.md)

## Planning aids

- [Future implementation plan](plan/IMPLEMENTATION_PLAN.md) — planning only; not authorization.
- [Current component inventory](new-code/IMPLEMENTATION_INVENTORY.md) — responsibility map only; not authorization.
