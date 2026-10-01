# juego-1-

Christmas Android prototype repository.

## Workflow authority

Current workflow state is reconstructed from GitHub, not from a static transition label in this file.

Read:
1. [Project Workflow Authority](workflow/PROJECT_WORKFLOW_AUTHORITY.md)
2. Issue #87 and its latest applicable Supervisor checkpoint
3. PR #89 integration state

Resolution:
- before PR #89 durable integration plus successful Supervisor post-integration canonical-pointer verification, the former G_INF_01 workflow remains CURRENT_CANONICAL_REFERENCE;
- after both conditions are satisfied and persisted in Issue #87, [ANDROID_WORKFLOW](workflow/adopted/ANDROID_WORKFLOW.md) is CURRENT_CANONICAL_WORKFLOW, [ANDROID_UNITY_GAME_PROFILE](workflow/adopted/ANDROID_UNITY_GAME_PROFILE.md) is CURRENT_SUBORDINATE_PROFILE when materially applicable, and the former workflow is SUPERSEDED / HISTORICAL_PROVENANCE.

[Project Workflow Overlay](workflow/PROJECT_WORKFLOW_OVERLAY.md) remains the durable project-specific operational overlay in either transition state.

Stage 2 remains paused until Supervisor separately authorizes resumption. Workflow adoption does not itself authorize Unity/Astra execution, gameplay/product implementation, asset import, build/device/performance work, Stage 3, self-approval, or publication.

## Start here

1. [Documentation Authority Map](docs/DOCUMENTATION_AUTHORITY_MAP.md)
2. [Project Workflow Authority](workflow/PROJECT_WORKFLOW_AUTHORITY.md)
3. [Project Workflow Overlay](workflow/PROJECT_WORKFLOW_OVERLAY.md)
4. [Project Authority](PROJECT_AUTHORITY.md)
5. [Accepted Specifications](docs/specifications/INDEX.md)
6. [Current Traceability](docs/CURRENT_TRACEABILITY_MATRIX.md)
7. [Blocking Gap Register](analysis/findings/BLOCKING_GAP_REGISTER.md)
8. [Current Handoff](workflow/research/SESSION_HANDOFF.md)

Historical research/ADRs remain preserved for evidence but are not executable current requirements.
