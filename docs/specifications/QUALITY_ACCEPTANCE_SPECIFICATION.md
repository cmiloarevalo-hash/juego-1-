# Quality Acceptance Specification
Status: CURRENT_AUTHORITATIVE.
Authority: accepted #64 verification contract plus Supervisor review 5370716635 resolving former VUX-GAP-001..008.
Issue #83 global hold remains active; this document defines acceptance, not implementation authorization.

## General rule
Functional correctness is necessary but not sufficient. Product-facing readiness requires the applicable VUX verification IDs below plus the existing gameplay, localization, originality, provenance and performance verification paths.

## Character / boss identity
QA-VUX-CHAR-001 Verify Santa reads as a broad/rounded original toy-maker leader, visibly larger/broader than helpers, with the required beard/hat/coat/tool-belt/hammer-or-sack cues and without distinctive third-party treatment.
QA-VUX-CHAR-002 Verify helpers read as one smaller compact/triangular humanoid family with modular cosmetic variation and no baseline proliferation of gameplay-role rigs.
QA-VUX-CHAR-003 Verify ordinary enemies use blockier/angular original workshop/toy-automata mechanical Christmas silhouettes distinct from Santa/helpers.
QA-VUX-CHAR-004 Verify boss is an oversized original malfunctioning gift-workshop automaton/toy-making machine guardian, mechanical/toy rather than Grinch-like or Santa-analogue.
QA-VUX-CHAR-005 Evidence required: original model/silhouette sheets + side-by-side originality review before final acceptance.

## Camera / framing
QA-VUX-CAM-001 Capture default third-person trailing/slightly elevated framing with forward look-ahead sufficient to expose upcoming gate/obstacle before commitment.
QA-VUX-CAM-002 Verify normal traversal has no camera roll or abrupt cinematic swings.
QA-VUX-CAM-003 Capture representative transitions and verify Santa, gate choice, obstacle affordance and enemy/boss telegraph remain visible.
QA-VUX-CAM-004 Capture boss framing and verify boss telegraph plus relevant army space are simultaneously readable.
QA-VUX-CAM-005 Exact FOV/height/distance/damping are not pass/fail constants; they remain device/playtest-derived while satisfying the observable criteria above.

## HUD / menu / result
QA-VUX-UI-001 Runtime capture shows only army count/state, pause, and necessary contextual hammer/snowball cue as primary information.
QA-VUX-UI-002 Verify absence of currencies, shop, upgrades, roster, kingdom/metagame indicators and ad UI.
QA-VUX-UI-003 Onboarding evidence shows short icon/text prompts and in-world affordances; no long tutorial panels.
QA-VUX-UI-004 Pause capture shows Resume + Restart; language/settings appears only if actually exposed.
QA-VUX-UI-005 Result capture shows unmistakable Victory/Defeat, concise run outcome and Retry/Restart; no reward/economy screen.
QA-VUX-UI-006 Gate operation/value remains primarily readable in-world.
QA-VUX-UI-007 Evidence required: ES and EN layouts with safe-area/downscale/overflow review.

## Animation
QA-VUX-ANIM-001 Coverage matrix includes Santa idle/run, hammer wind-up/impact/recover, snowball throw/release, hit/defeat feedback and victory.
QA-VUX-ANIM-002 Coverage matrix includes helper locomotion, combat action where applicable, hit/death and victory/defeat response as needed.
QA-VUX-ANIM-003 Coverage matrix includes ordinary enemy locomotion/idle as needed, attack, hit and death.
QA-VUX-ANIM-004 Coverage matrix includes boss idle/locomotion as needed, clear telegraph, attack, recover, hit and death.
QA-VUX-ANIM-005 Verify gameplay damage/timing authority does not originate from animation events/presentation.
QA-VUX-ANIM-006 Exact clip count/timing/retargeting is not fixed; readability/performance evidence governs those choices.

## VFX / audio
QA-VUX-FX-001 Cue matrix contains distinct feedback for army gain/loss, gate mutation, hammer impact/break, snowball launch/impact, ordinary enemy hit/death, boss telegraph/attack/hit/death, Victory and Defeat.
QA-VUX-FX-002 Verify perceptual priority: boss telegraph + terminal result > critical player/army loss > tool/gate action > routine combat hit > ambient decoration.
QA-VUX-FX-003 On snow/white backgrounds, critical VFX use shape/value/motion contrast and are not white-only.
QA-VUX-FX-004 Verify music/ambience does not mask boss telegraphs or terminal cues.
QA-VUX-FX-005 Evidence required: VFX/audio cue matrix. Exact assets remain provenance-gated.

## Typography / palette
QA-VUX-TYPE-001 Review palette direction for warm festive workshop allies/positive spaces versus cooler threat/mechanical/ice families with snow neutral.
QA-VUX-TYPE-002 Verify color is never the sole gate/team/interaction code.
QA-VUX-TYPE-003 Mobile/downscale review verifies preserved value contrast and no excessive saturation/reflectivity that harms readability.
QA-VUX-TYPE-004 Typography review verifies rounded/geometric sans-serif direction, open counters, strong numeral/symbol legibility and Latin-Extended coverage.
QA-VUX-TYPE-005 Distance/downscale review verifies large gate/result numerals remain readable.
QA-VUX-TYPE-006 Evidence required: typography/palette/readability review in ES/EN. Exact font file/color values remain content/provenance/tuning selections.

## Environment composition / art quality
QA-VUX-ENV-001 Stage-composition evidence shows all three required beats: festive entry; toy-workshop production/yard escalation; attacked/damaged dispatch/plaza/warehouse-like boss area.
QA-VUX-ENV-002 Verify coherent snow + wood/toy-workshop + presents/crates/machinery + warm practical-light language while gameplay route/decision objects remain dominant.
QA-VUX-ENV-003 Reject untouched asset-pack demo scene, placeholder-primitives-as-final-art, mismatched-scale collage or mixed unrelated art styles.
QA-VUX-ENV-004 Verify clutter/background decoration does not obscure gates, Santa, obstacles, enemies or boss telegraphs.
QA-VUX-ENV-005 Evidence required: stage-composition screenshots for each visual beat and representative gameplay-readability views.

## Onboarding / pacing / difficulty
QA-VUX-PACE-001 First-time-user evidence shows concepts introduced in order: movement → army growth → +/× gate decision → avoidable obstacle → hammer break → snowball/combat → boss, initially one concept at a time.
QA-VUX-PACE-002 Verify each mechanic is demonstrated in a lower-risk context before boss pressure.
QA-VUX-PACE-003 Verify difficulty escalates by combining taught mechanics/tightening decisions, not unexplained rules.
QA-VUX-PACE-004 Verify no new core mechanic appears first during boss.
QA-VUX-PACE-005 First-time-user playtest record is mandatory.
QA-VUX-PACE-006 Blocking UX defect if a critical concept requires developer verbal explanation, is repeatedly misread, or player cannot explain Victory/Defeat causality.
QA-VUX-PACE-007 Exact duration/spacing/damage/cooldown/count/difficulty numbers remain playtest-derived and are not invented by this spec.

## Existing cross-cutting acceptance
QA-CROSS-001 Gameplay semantics continue through current VER-ARMY/ZERO/GATE/HAMMER/SNOW/COMBAT/BOSS/VICTORY/DEFEAT.
QA-CROSS-002 Originality/provenance continue through VER-ORIG and VER-PROV.
QA-CROSS-003 Localization continues through VER-LOC-ES/EN.
QA-CROSS-004 Mobile readability continues through VER-MOBILE plus the VUX checks above.
QA-CROSS-005 Technical/device acceptance remains VER-BUILD/PERF/THERM/CAP/X46 when the global hold is lifted and prerequisites exist.
QA-CROSS-006 Current traceability must map each VUX decision to specification, component/future implementation, verification ID and status.

## Required future evidence bundle
- VUX-EVID-001 model/silhouette sheets.
- VUX-EVID-002 side-by-side originality review.
- VUX-EVID-003 camera/readability captures.
- VUX-EVID-004 HUD ES/EN layouts.
- VUX-EVID-005 animation-state coverage matrix.
- VUX-EVID-006 VFX/audio cue matrix.
- VUX-EVID-007 typography/palette/readability review.
- VUX-EVID-008 stage-composition screenshots.
- VUX-EVID-009 first-time-user playtest evidence.

No future evidence is claimed to exist by this documentation update.
