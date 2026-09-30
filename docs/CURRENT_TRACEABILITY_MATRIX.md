# Current Traceability Matrix
Status: CURRENT_AUTHORITATIVE traceability view for Issue #83.
Product semantics derive from accepted #64 freeze plus Supervisor review 5370716635 for VUX-001..008. This matrix does not authorize implementation while the global hold is active.

| Product decision | Current spec | Component / future implementation | Verification | Status |
|---|---|---|---|---|
| Android-only 3D Christmas runner APK; Santa/helpers; ES+EN | SRS-PROD-001/002, TECH-PLATFORM-001 | platform/bootstrap; Presentation/Localization | VER-BUILD, VER-LOC-ES/EN | FROZEN |
| one village/workshop vertical slice and required flow | SRS-SCOPE-001, SRS-LOOP-001, GAME-STAGE-001 | Run + Stage Definition | scripted sequence + QA-VUX-PACE-* | FROZEN; numeric duration MEASUREMENT/PLAYTEST_DERIVED |
| army protects Santa; zero army defeat | SRS-ARMY/HEALTH, GAME-ARMY/HEALTH/DEFEAT | Army State + Run | VER-ARMY, VER-ZERO, VER-DEFEAT | FROZEN |
| +N / ×N positive integer gates, once per gate | SRS-GATE-001/002, GAME-GATE-001..005 | Gate Resolver | VER-GATE-ADD/MUL/DUP/SCOPE | FROZEN; capacity MEASUREMENT_REQUIRED |
| hammer authored destruction | SRS-TOOL/OBS, GAME-HAMMER | Obstacle/Tool | VER-HAMMER | FROZEN; runtime fracture OUT_OF_SCOPE |
| snowball ranged combat | SRS-TOOL, GAME-SNOW | Combat | VER-SNOW, VER-COMBAT | FROZEN; numeric tuning TUNABLE |
| mandatory one-phase final boss; no adds/multiphase | SRS-BOSS, GAME-BOSS | Boss Encounter + Result | VER-BOSS, VER-VICTORY | FROZEN |
| exactly-once victory/defeat result | SRS-RESULT, GAME-RESULT | Run Coordinator + Result | VER-VICTORY/DEFEAT | FROZEN |
| concrete Santa/helper/enemy/boss identity | VUX-CHAR-001..006 | Presentation/content; future character art implementation | QA-VUX-CHAR-001..005 + VER-ORIG | RESOLVED_BY_SUPERVISOR_DECISION review 5370716635; evidence VUX-EVID-001/002 required |
| third-person trailing/slightly elevated camera with look-ahead/readability rules | VUX-CAM-001..005 | Camera Presenter | QA-VUX-CAM-001..005 | RESOLVED_BY_SUPERVISOR_DECISION; exact FOV/height/distance/damping playtest/device-derived |
| minimal runtime HUD/pause/result surfaces | VUX-UI-001..008 | HUD/Menu/Result Presentation | QA-VUX-UI-001..007 + VER-LOC-ES/EN | RESOLVED_BY_SUPERVISOR_DECISION; VUX-EVID-004 required |
| minimum animation state coverage | VUX-ANIM-001..006 | Character/Combat/Boss Presentation | QA-VUX-ANIM-001..006 | RESOLVED_BY_SUPERVISOR_DECISION; VUX-EVID-005 required |
| VFX/audio event set and priority hierarchy | VUX-FX-001..005 | Feedback/VFX/Audio Presentation | QA-VUX-FX-001..005 | RESOLVED_BY_SUPERVISOR_DECISION; exact assets BG-011 provenance-gated; VUX-EVID-006 required |
| warm-allies/cool-threat palette direction + rounded/geometric sans typography | VUX-TYPE-001..006 | UI/Art Direction/Presentation | QA-VUX-TYPE-001..006 + VER-MOBILE/LOC | RESOLVED_BY_SUPERVISOR_DECISION; exact files/values remain provenance/tuning; VUX-EVID-007 required |
| three-beat coherent village/workshop environment composition | VUX-ENV-001..004 | Stage Presentation/Content | QA-VUX-ENV-001..005 + VER-MOBILE/ORIG | RESOLVED_BY_SUPERVISOR_DECISION; VUX-EVID-008 required |
| onboarding/pacing/difficulty teaching contract | VUX-PACE-001..007, GAME-STAGE-001 | Stage sequencing/tuning | QA-VUX-PACE-001..007 | RESOLVED_BY_SUPERVISOR_DECISION; exact numeric tuning playtest-derived; VUX-EVID-009 required |
| low-poly toy-workshop/diorama, original identity, mostly opaque/matte | SRS-ART/ORIG, VUX-BASE-* | Presentation/content | VER-ORIG, VER-MOBILE | FROZEN baseline |
| gates symbol/value + shape/border; no color-only semantics | SRS-UX-001, VUX-BASE-005/VUX-TYPE-002 | Gate Presentation | VER-OBS, VER-MOBILE, QA-VUX-TYPE-002 | FROZEN |
| ES/EN critical UI | SRS-LOC-001, DATA-LOC-001, VUX-UI-008/VUX-TYPE-004 | Localization/Presentation | VER-LOC-ES/EN, QA-VUX-UI-007 | FROZEN |
| Unity 6.3 LTS/URP/Input/Android landscape | SRS-TECH, TECH-* | paused Stage 2 bootstrap | VER-BUILD | FROZEN family; exact technical pins partly unresolved |
| stable 30 FPS lower representative device + no sustained thermal collapse | SRS-PERF, PERF-001/002 | Instrumentation / X46 | VER-PERF, VER-THERM | FROZEN acceptance; BG-009/010 measurement required |
| backend/render/lifecycle/physics/capacity | ARCH + PERF-004..013 | future Stage 2 X46 | VER-CAP, VER-X46 | BG-009 MEASUREMENT_REQUIRED; execution held |
| game-specific logic NEW; external provenance gates | SRS-REUSE, reuse matrix | every future implementation WI | VER-PROV, VER-ORIG | FROZEN; BG-011 EXTERNAL_PROVENANCE_REQUIRED |
| kingdom/metagame/economy excluded | SRS-PROD-003, DATA-UPGRADE/ECON/ROSTER/CLOUD | no product component | scope contamination audit, QA-VUX-UI-002/005 | OUT_OF_SCOPE |
| extra stages/forest/ice fortress/store commercialization | SRS-SCOPE, DATA-STORE | none current | scope contamination audit | DEFERRED |

## Evidence status
The VUX evidence IDs define required future evidence; no model sheet, capture, layout, animation coverage, cue matrix, palette/type review, stage screenshot or playtest result is claimed to exist in Issue #83.
