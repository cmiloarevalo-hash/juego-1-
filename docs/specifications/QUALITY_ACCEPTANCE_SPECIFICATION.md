# Quality Acceptance Specification
Status: CURRENT_AUTHORITATIVE gate interpretation for Issue #83; derives from accepted verification requirements and explicit unresolved gaps. It adds no invented aesthetic targets.

## Principle
Functional correctness is necessary but not sufficient for product readiness. A product-facing implementation cannot be accepted while a material visual/UX/content dimension is silently unconstrained.

## Existing objective acceptance paths
QA-001 Gameplay semantics: current GAME/SRS requirements and VER-ARMY/ZERO/GATE/HAMMER/SNOW/COMBAT/BOSS/VICTORY/DEFEAT.
QA-002 Scope: exactly one village/workshop slice; excluded/deferred content must remain absent.
QA-003 Originality/provenance: VER-ORIG and VER-PROV.
QA-004 Mobile readability: VER-MOBILE plus gate symbol/value + shape/border; never color alone.
QA-005 Localization: VER-LOC-ES/EN with Spanish glyph and overflow checks.
QA-006 Technical/device: VER-BUILD/PERF/THERM/CAP/X46 when the documentation hold is lifted and prerequisites exist.
QA-007 Traceability: every critical product requirement maps through `docs/CURRENT_TRACEABILITY_MATRIX.md`.

## Quality dimensions currently blocked
The following cannot receive a product-quality PASS until their corresponding VUX gap is resolved:
- character/boss detailed identity — VUX-GAP-001;
- camera/framing/motion comfort — VUX-GAP-002;
- HUD/menu/result hierarchy — VUX-GAP-003;
- minimum animation/feedback clarity — VUX-GAP-004;
- VFX/audio feedback hierarchy — VUX-GAP-005;
- bounded typography/palette selection — VUX-GAP-006;
- environment composition/art-quality reference — VUX-GAP-007;
- onboarding/pacing/difficulty acceptance rubric — VUX-GAP-008.

## Evidence rule
A future verification may use screenshots/video/playtest notes/reference sheets/device captures as appropriate only after the acceptance criterion is explicitly approved. This file does not define palette values, fonts, camera numbers, attack patterns, animation timings, VFX/audio assets, pacing duration or difficulty thresholds.

## Ordinary-application prevention
If an Implementer can produce two materially different presentations that both satisfy existing functional tests, and the choice affects one of the blocked quality dimensions above, the Implementer must stop and request the missing decision rather than selecting the more convenient or generic option.

## Exit from a VUX block
A later explicit Supervisor-approved specification must state the decision and its observable acceptance evidence. Updating this file/traceability is required before that dimension can be called READY_FOR_REVIEW.
