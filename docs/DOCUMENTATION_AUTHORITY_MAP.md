# Documentation Authority Map
Status: CURRENT_AUTHORITATIVE for navigation. Work Item #83.
Global execution state: **DOCUMENTATION HOLD** until Supervisor issues `DOCUMENTATION_GATE_ACCEPTED`.

## Reading order for a new Implementer
1. `README.md` — entrypoint and global hold.
2. This file — authority/supersession map.
3. `PROJECT_AUTHORITY.md` — frozen product boundary.
4. `docs/specifications/INDEX.md` — accepted specification set.
5. `docs/specifications/SPEC_FREEZE_MATRIX.md` — decision/status mapping.
6. `docs/CURRENT_TRACEABILITY_MATRIX.md` — product → spec → component/plan → verification → status.
7. `docs/specifications/VISUAL_UX_CONTENT_SPECIFICATION.md` — accepted visual/UX baseline plus explicit unresolved quality decisions.
8. `analysis/findings/BLOCKING_GAP_REGISTER.md` — unresolved decisions/measurements/provenance.
9. `workflow/research/SESSION_HANDOFF.md` — current Work Item/checkpoint only.

## Authority chain
- Product-freeze human authority: Issue #57 comment 5914691381 (2026-09-30).
- Canonical accepted specification snapshot: PR #71 / `docs/issue-64-spec-freeze@09061b4ba372de41fb142ab4c43f1b4302f58083`, Supervisor review 5368899526, `SEMANTIC_ACCEPTED`.
- Preimplementation documentary GO: PR #72 / `87623c57cc5813e15eeec661b762a7be28b24820`, review 5368900046. It authorized only the bounded Stage 2 technical tranche and did not authorize product gameplay.
- Stage 2A technical checkpoint inherited by #83: `tech/issue-73-unity-android-bootstrap@c8af0b68bf87c6560a5f8b9d42699ccd65210940`.
- Current overriding execution authority: Issue #83 GLOBAL HOLD. It suspends all other project work until explicit `DOCUMENTATION_GATE_ACCEPTED`.

Later explicit Supervisor/Product Owner decisions supersede earlier proposals where they conflict. Historical evidence remains preserved.

## Classification rules
- **CURRENT_AUTHORITATIVE**: current product/spec/navigation requirements.
- **CURRENT_SUPPORTING**: current evidence/status supporting authority but not itself a product decision.
- **HISTORICAL_EVIDENCE**: useful prior research; never executable requirements.
- **SUPERSEDED**: a later accepted decision replaces its relevant content.
- **REFERENCE_ONLY**: technical/source material not selected as implementation authority.
- **STALE_MUST_FIX**: current-looking text contradicting authority; no such item may remain at READY_FOR_REVIEW.
- **REMOVE_FROM_CURRENT_NAVIGATION_BUT_PRESERVE_HISTORY**: retain in Git but do not present as current path.

## Current authoritative set
`PROJECT_AUTHORITY.md`; all files under `docs/specifications/` as indexed by its repaired INDEX; this map; `docs/CURRENT_TRACEABILITY_MATRIX.md`; #83 gap register for unresolved decisions.

## Current supporting set
`technical/stage2/**` is evidence of the paused technical tranche only. It is **not executable while #83 hold is active**.
`reuse/REUSE_MATRIX.md` and `sources/**` are provenance/supporting evidence, not permission to import.
`analysis/findings/CHRISTMAS_SPEC_FREEZE_ASSESSMENT.md` and `FREEZE_AUTHORITY_TABLE.md` support the accepted freeze.

## Historical/superseded boundary
`research/**`, `analysis/comparisons/**`, the pre-freeze experiment matrix, pre-freeze consolidated/final audits, and `decisions/adr/**` are historical proposals/evidence unless a current authoritative spec explicitly incorporates a statement. Their recommendations, TBDs, optional features and proposed architectures do not override the freeze.

`plan/IMPLEMENTATION_PLAN.md` and `new-code/IMPLEMENTATION_INVENTORY.md` are current-facing planning aids only after their #83 remediation; neither authorizes work.

## Prohibited inference
Absence of a resolved visual/UX/content decision is not permission for an Implementer to choose silently. Items marked `REQUIRES_SUPERVISOR_DECISION` in the visual/UX spec and Blocking Gap Register stop the affected product implementation.
