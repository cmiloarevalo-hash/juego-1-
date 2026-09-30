# Visual / UX / Content Specification
Status: CURRENT_AUTHORITATIVE for accepted baseline + explicit blocking gaps.
Authority: Issue #57 comment 5914691381 and accepted #64 freeze. This file **does not invent** missing art/UX decisions.

## Accepted baseline
VIS-BASE-001 [FROZEN] Visual grammar: low-poly + toy-workshop/diorama.
VIS-BASE-002 [FROZEN] Santa, helpers, enemies, boss, UI and level composition must be original; no Grinch/distinctive third-party identity, Top Lords proprietary UI/assets/composition or recognizable trade dress.
VIS-BASE-003 [FROZEN] Materials are mostly opaque/matte.
VIS-BASE-004 [FROZEN] Single content scope is an original Santa Christmas village/workshop under attack.
VIS-BASE-005 [FROZEN] Gates communicate operation/value with symbol/value plus shape/border and never color alone.
VIS-BASE-006 [FROZEN] Boss attacks must be readable/telegraphed; exact attacks are not specified here.
VIS-BASE-007 [FROZEN] Critical player-facing UI supports ES+EN, Spanish glyphs and overflow validation.
VIS-BASE-008 [FROZEN] Mobile presentation must pass originality, silhouette/downscale/occlusion and color-independent gate readability checks already defined by VER-ORIG/VER-MOBILE.

## Explicit unresolved product/quality decisions
The following are **REQUIRES_SUPERVISOR_DECISION before the affected production presentation/content is implemented**. An Implementer may prototype neutral technical placeholders only when separately authorized.

VUX-GAP-001 Character identity: approved proportions, silhouette language and differentiation rules for Santa, helper family, ordinary enemies and boss beyond generic originality/low-poly constraints.
VUX-GAP-002 Camera: approved gameplay framing intent, angle/follow behavior, look-ahead/decision visibility, boss framing, transition/motion-comfort expectations. Research alternatives are historical, not accepted requirements.
VUX-GAP-003 HUD/menu/result: required screens/elements, information hierarchy, layout behavior and visual quality bar beyond gate readability and ES/EN support.
VUX-GAP-004 Animation: minimum required state/feedback set and quality/clarity acceptance for Santa/helpers/enemies/boss/tools. No clip list or timing is inferred.
VUX-GAP-005 VFX/audio: required feedback hierarchy and minimum cues for growth, damage/death, gates, hammer destruction, snowball combat, boss telegraphs and terminal result. Exact assets/style remain unselected.
VUX-GAP-006 Typography/palette: exact font/palette may be selected later under the freeze, but no current accepted bounded selection/quality rule exists. Selection must preserve readability, originality and ES glyph support and must be approved through a bounded content decision.
VUX-GAP-007 Environment composition: composition density, landmark/route readability, foreground/background clutter limits and art-quality reference for the workshop/village are not accepted beyond the baseline theme.
VUX-GAP-008 Onboarding/pacing/difficulty acceptance: flow order is frozen and duration/tuning are measurement/playtest-derived, but no accepted playtest rubric defines comprehension, difficulty progression or feel threshold.

## Ordinary-application prevention rule
These gaps are not discretionary styling space. Until resolved, a functionally correct but generic presentation cannot be declared product-ready. Product implementation PRs must cite resolved VUX IDs or remain blocked for the affected dimension.

## What remains intentionally tunable
Touch sensitivity/curves; damage/cooldown/range/projectile speed; counts/spacing; duration and pacing numbers; capacity/performance budgets. These values may be tuned/measured only within frozen semantics and must not substitute for unresolved VUX product decisions.
