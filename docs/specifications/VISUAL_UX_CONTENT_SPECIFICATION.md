# Visual / UX / Content Specification
Status: CURRENT_AUTHORITATIVE.
Authority: Issue #57 comment 5914691381; accepted #64 freeze; Supervisor review 5370716635 on PR #84 resolving former VUX-GAP-001..008.
This file does not alter frozen gameplay semantics, invent numeric tuning, select external asset files, or authorize implementation while Issue #83 global hold remains active.

## Accepted baseline carried from #64
VUX-BASE-001 [FROZEN] Visual grammar is low-poly + toy-workshop/diorama.
VUX-BASE-002 [FROZEN] Santa, helpers, enemies, boss, UI and level composition are original; no Grinch/distinctive third-party identity, Top Lords proprietary UI/assets/composition or recognizable trade dress.
VUX-BASE-003 [FROZEN] Materials are mostly opaque/matte.
VUX-BASE-004 [FROZEN] Content scope is one original Santa Christmas village/workshop under attack.
VUX-BASE-005 [FROZEN] Gates communicate operation/value with symbol/value plus shape/border and never color alone.
VUX-BASE-006 [FROZEN] Boss attacks are readable/telegraphed; boss remains one phase, no adds/multiphase.
VUX-BASE-007 [FROZEN] Critical player-facing UI supports ES+EN, Spanish glyphs and overflow validation.
VUX-BASE-008 [FROZEN] Mobile presentation must pass originality, silhouette/downscale/occlusion and color-independent gate readability checks.

## VUX-001 — Character / Boss Identity
VUX-CHAR-001 [SUPERVISOR_ACCEPTED] Adopt the low-poly + toy-workshop/diorama A+B direction as the concrete prototype character language.
VUX-CHAR-002 [SUPERVISOR_ACCEPTED] Santa uses an original broad/rounded toy-maker leader silhouette, visibly larger/broader than helpers, with readable beard/hat/coat/tool-belt/hammer-or-sack cues without copying a third-party Santa treatment.
VUX-CHAR-003 [SUPERVISOR_ACCEPTED] Helpers use one smaller humanoid helper family with compact/triangular silhouette and modular cosmetic variation; multiple gameplay-role rigs are not baseline.
VUX-CHAR-004 [SUPERVISOR_ACCEPTED] Ordinary enemies are original workshop/toy automata and related mechanical Christmas threats with blockier/angular masses clearly distinct from Santa/helpers.
VUX-CHAR-005 [SUPERVISOR_ACCEPTED] Boss is one oversized original malfunctioning gift-workshop automaton / toy-making machine guardian. It is mechanical/toy, not Grinch-like and not a Santa analogue.
VUX-CHAR-006 [SUPERVISOR_ACCEPTED] Production character art requires original model/silhouette sheets and side-by-side originality review before final acceptance.

## VUX-002 — Camera / Framing
VUX-CAM-001 [SUPERVISOR_ACCEPTED] Default camera is third-person trailing and slightly elevated, following Santa/army with forward look-ahead so upcoming gates/obstacles are visible before commitment.
VUX-CAM-002 [SUPERVISOR_ACCEPTED] No camera roll and no abrupt cinematic swings during normal traversal.
VUX-CAM-003 [SUPERVISOR_ACCEPTED] Transitions are smooth and must not hide Santa, gate choice, obstacle affordance or enemy/boss telegraph.
VUX-CAM-004 [SUPERVISOR_ACCEPTED] Boss framing may pull back/elevate to keep boss telegraph and relevant army space visible simultaneously.
VUX-CAM-005 [TUNABLE/PLAYTEST_DERIVED] Exact FOV, height, distance and damping remain device/playtest tuning.

## VUX-003 — HUD / Menu / Result
VUX-UI-001 [SUPERVISOR_ACCEPTED] Prototype UI is intentionally minimal.
VUX-UI-002 [SUPERVISOR_ACCEPTED] Runtime primary information is army count/state, pause, and only the contextual tool/status cue needed to understand current hammer/snowball interaction.
VUX-UI-003 [SUPERVISOR_ACCEPTED] No currencies, shop, upgrades, roster, kingdom/metagame indicators or ad UI.
VUX-UI-004 [SUPERVISOR_ACCEPTED] Onboarding uses short icon/text prompts and in-world affordances; no long tutorial panels.
VUX-UI-005 [SUPERVISOR_ACCEPTED] Pause surface contains Resume + Restart; language/settings appear only if the corresponding minimal setting is actually exposed.
VUX-UI-006 [SUPERVISOR_ACCEPTED] Result surface shows unmistakable Victory/Defeat, concise run outcome, and Retry/Restart; no reward/economy screen.
VUX-UI-007 [SUPERVISOR_ACCEPTED] Gate operation/value remains primarily readable in-world.
VUX-UI-008 [SUPERVISOR_ACCEPTED] Layout must survive ES/EN expansion and mobile safe-area/downscale review.

## VUX-004 — Minimum Animation Contract
VUX-ANIM-001 [SUPERVISOR_ACCEPTED] Santa minimum readable states: idle/run; hammer wind-up/impact/recover; snowball throw/release; hit/defeat feedback; victory.
VUX-ANIM-002 [SUPERVISOR_ACCEPTED] Helper minimum readable states: locomotion; combat action where applicable; hit/death; victory/defeat response as needed.
VUX-ANIM-003 [SUPERVISOR_ACCEPTED] Ordinary enemy minimum readable states: locomotion/idle as needed; attack; hit; death.
VUX-ANIM-004 [SUPERVISOR_ACCEPTED] Boss minimum readable states: idle/locomotion as needed; clear telegraph; attack; recover; hit; death.
VUX-ANIM-005 [FROZEN] Animation is presentation only and never authoritative damage/timing state.
VUX-ANIM-006 [TUNABLE/PERFORMANCE_DERIVED] Exact clip counts/timings/retargeting remain implementation/tuning choices subject to readability and performance evidence.

## VUX-005 — VFX / Audio Feedback Hierarchy
VUX-FX-001 [SUPERVISOR_ACCEPTED] Distinct feedback exists for army gain/loss, gate mutation, hammer impact/break, snowball launch/impact, ordinary enemy hit/death, boss telegraph/attack/hit/death, Victory and Defeat.
VUX-FX-002 [SUPERVISOR_ACCEPTED] Feedback priority is: boss telegraph + terminal result > critical player/army loss > tool/gate action > routine combat hit > ambient decoration.
VUX-FX-003 [SUPERVISOR_ACCEPTED] Snow/white backgrounds may not be answered with white-only VFX; shape/value/motion contrast is required.
VUX-FX-004 [SUPERVISOR_ACCEPTED] Music/ambience must not mask boss telegraphs or terminal cues.
VUX-FX-005 [EXTERNAL_PROVENANCE_REQUIRED] Exact music/SFX/VFX assets remain provenance-gated and must be original or properly licensed.

## VUX-006 — Typography / Palette Direction
VUX-TYPE-001 [SUPERVISOR_ACCEPTED] Palette direction: warm festive workshop for Santa/allies/interactive positive spaces using red/burgundy, cream and warm wood/gold family; cooler threat/mechanical/ice families using blue/teal/charcoal/metal; snow is neutral background.
VUX-TYPE-002 [SUPERVISOR_ACCEPTED] Color may reinforce meaning but is never the sole gate/team/interaction code.
VUX-TYPE-003 [SUPERVISOR_ACCEPTED] Avoid excessive saturation/reflectivity and preserve value contrast at mobile size.
VUX-TYPE-004 [SUPERVISOR_ACCEPTED] Typography direction: rounded/geometric sans-serif with open counters, strong numeral/symbol legibility and Latin-Extended coverage.
VUX-TYPE-005 [SUPERVISOR_ACCEPTED] Large gate/result numerals remain readable at distance/downscale.
VUX-TYPE-006 [CONTENT/PROVENANCE_TUNABLE] Exact font file and exact color values remain content/provenance/tuning selections but must conform to this direction and pass ES/EN/readability/originality review.

## VUX-007 — Environment Composition / Art Quality
VUX-ENV-001 [SUPERVISOR_ACCEPTED] The one stage is a coherent original village/workshop route with three visual beats:
1. festive village/workshop entry for onboarding;
2. toy-workshop production/yard route where gates/tools/combat escalate;
3. visibly attacked/damaged dispatch/plaza/warehouse-like final area for boss.
VUX-ENV-002 [SUPERVISOR_ACCEPTED] Use snow, wood/toy-workshop construction, presents/crates/machinery and warm practical lighting as a coherent language while keeping route and decision objects visually dominant.
VUX-ENV-003 [SUPERVISOR_ACCEPTED] Untouched asset-pack demo scenes, placeholder-primitives-as-final-art, mismatched-scale collage and mixed unrelated art styles cannot pass product-quality review.
VUX-ENV-004 [SUPERVISOR_ACCEPTED] Clutter/background decoration must not obscure gates, Santa, obstacles, enemies or boss telegraphs.

## VUX-008 — Onboarding / Pacing / Difficulty Acceptance
VUX-PACE-001 [SUPERVISOR_ACCEPTED] Introduce mandatory concepts in frozen order and initially one concept at a time: movement → army growth → +/× gate decision → avoidable obstacle → hammer break → snowball/combat → boss.
VUX-PACE-002 [SUPERVISOR_ACCEPTED] A mechanic is demonstrated in a lower-risk context before it is required under boss pressure.
VUX-PACE-003 [SUPERVISOR_ACCEPTED] Difficulty escalates by combining already taught mechanics and tightening decisions, not by introducing unexplained rules.
VUX-PACE-004 [SUPERVISOR_ACCEPTED] No new core mechanic is introduced for the first time during the boss.
VUX-PACE-005 [SUPERVISOR_ACCEPTED] First-time-user playtest evidence is required.
VUX-PACE-006 [SUPERVISOR_ACCEPTED] A critical concept that requires developer verbal explanation, is repeatedly misread, or leaves the player unable to explain the cause of Victory/Defeat is a blocking UX defect and must be revised.
VUX-PACE-007 [MEASUREMENT/PLAYTEST_DERIVED] Exact duration, spacing, damage, cooldown, counts and difficulty numbers remain playtest-derived.

## Required future evidence
VUX-EVID-001 Character/model/silhouette sheets for Santa/helpers/enemies/boss.
VUX-EVID-002 Side-by-side originality review against prohibited/distinctive third-party identity/reference risks.
VUX-EVID-003 Camera/readability captures showing traversal choices, obstacle affordance and boss telegraph + army framing.
VUX-EVID-004 HUD ES/EN layouts including safe-area/downscale checks.
VUX-EVID-005 Animation-state coverage matrix proving required minimum states are represented/readable.
VUX-EVID-006 VFX/audio cue matrix mapping every required event and hierarchy priority.
VUX-EVID-007 Typography/palette/readability review at mobile scale with ES/EN/Latin-Extended evidence.
VUX-EVID-008 Stage-composition screenshots covering the three required visual beats and gameplay dominance.
VUX-EVID-009 First-time-user playtest evidence for concept comprehension and Victory/Defeat causality.

## Non-authorizations
These baselines do not select exact external assets/licenses, exact numeric tuning, device/performance results, or implementation architecture. Issue #83 global hold remains active until DOCUMENTATION_GATE_ACCEPTED.
