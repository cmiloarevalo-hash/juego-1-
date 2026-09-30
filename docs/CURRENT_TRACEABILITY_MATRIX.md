# Current Traceability Matrix
Status: CURRENT_AUTHORITATIVE traceability view for Issue #83.
Canonical product semantics derive from accepted #64 freeze; this matrix does not create new product requirements.

| Product decision | Current spec | Component / future plan | Verification | Evidence/status |
|---|---|---|---|---|
| Android-only 3D Christmas runner APK; Santa/helpers; ES+EN | SRS-PROD-001/002, TECH-PLATFORM-001 | platform/bootstrap; Presentation/Localization | VER-BUILD, VER-LOC-ES/EN | FROZEN |
| one village/workshop vertical slice and required flow | SRS-SCOPE-001, SRS-LOOP-001, GAME-STAGE-001 | Run + Stage Definition | scripted sequence + trace review | FROZEN; duration MEASUREMENT_DERIVED |
| army protects Santa; zero army defeat | SRS-ARMY/HEALTH, GAME-ARMY/HEALTH/DEFEAT | Army State + Run | VER-ARMY, VER-ZERO, VER-DEFEAT | FROZEN |
| +N / ×N positive integer gates, once per gate | SRS-GATE-001/002, GAME-GATE-001..005 | Gate Resolver | VER-GATE-ADD/MUL/DUP/SCOPE | FROZEN; capacity MEASUREMENT_DERIVED |
| hammer authored destruction | SRS-TOOL/OBS, GAME-HAMMER | Obstacle/Tool | VER-HAMMER | FROZEN; runtime fracture OUT_OF_SCOPE |
| snowball ranged combat | SRS-TOOL, GAME-SNOW | Combat | VER-SNOW, VER-COMBAT | FROZEN; numeric tuning TUNABLE |
| mandatory one-phase final boss; no adds/multiphase | SRS-BOSS, GAME-BOSS | Boss Encounter + Result | VER-BOSS, VER-VICTORY | FROZEN |
| exactly-once victory/defeat result | SRS-RESULT, GAME-RESULT | Run Coordinator + Result | VER-VICTORY/DEFEAT | FROZEN |
| low-poly toy-workshop/diorama, original identity, mostly opaque/matte | SRS-ART/ORIG + VISUAL_UX_CONTENT_SPECIFICATION | Presentation/content, future bounded art WI | VER-ORIG, VER-MOBILE | FROZEN baseline; detailed identity gaps BLOCKED |
| gates symbol/value + shape/border; no color-only semantics | SRS-UX-001 | Gate Presentation | VER-OBS, VER-MOBILE | FROZEN |
| ES/EN critical UI | SRS-LOC-001, DATA-LOC-001 | Localization/Presentation | VER-LOC-ES/EN | FROZEN; detailed typography/layout unresolved |
| Unity 6.3 LTS/URP/Input/Android landscape | SRS-TECH, TECH-* | Stage 2 bootstrap | VER-BUILD | FROZEN family; exact technical pins partly unresolved |
| stable 30 FPS lower representative device + no sustained thermal collapse | SRS-PERF, PERF-001/002 | Instrumentation / X46 | VER-PERF, VER-THERM | FROZEN acceptance; measurements pending |
| backend/render/lifecycle/physics/capacity | ARCH + PERF-004..013 | Stage 2 X46 | VER-CAP, VER-X46 | MEASUREMENT_REQUIRED; #83 currently holds execution |
| game-specific logic NEW; external provenance gates | SRS-REUSE, reuse matrix | every future implementation WI | VER-PROV, VER-ORIG | FROZEN |
| kingdom/metagame/economy excluded | SRS-PROD-003, DATA-UPGRADE/ECON/ROSTER/CLOUD | no product component | scope contamination audit | OUT_OF_SCOPE |
| extra stages/forest/ice fortress/store commercialization | SRS-SCOPE, DATA-STORE | none current | scope contamination audit | DEFERRED |
| camera/framing quality | VISUAL_UX_CONTENT_SPECIFICATION | Presentation/Camera | future visual acceptance | REQUIRES_SUPERVISOR_DECISION |
| character/boss detailed visual identity | VISUAL_UX_CONTENT_SPECIFICATION | Presentation/content | future model-sheet/silhouette acceptance | REQUIRES_SUPERVISOR_DECISION |
| HUD/menu/result composition | VISUAL_UX_CONTENT_SPECIFICATION | Presentation | future UI acceptance | REQUIRES_SUPERVISOR_DECISION |
| animation minimum set/quality | VISUAL_UX_CONTENT_SPECIFICATION | Presentation | future animation acceptance | REQUIRES_SUPERVISOR_DECISION |
| VFX/audio feedback hierarchy | VISUAL_UX_CONTENT_SPECIFICATION | Presentation | future feedback acceptance | REQUIRES_SUPERVISOR_DECISION |
| onboarding/pacing/difficulty quality | GAME-STAGE/TUNING + VISUAL_UX_CONTENT_SPECIFICATION | Stage/content tuning | playtest protocol | pacing numeric data MEASUREMENT_DERIVED; acceptance rubric requires decision |
