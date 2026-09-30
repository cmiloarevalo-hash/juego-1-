> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Consolidación — prototipo navideño

Work Item: #47
Dependencies consumed:
#39 PR #48 @ 53b28c930a7963eb617271d2113dfcae233ab19e
#40 PR #49 @ e41c7defe252c57128c47a20063de8dc97af9dbc
#41 PR #50 @ e42590bd90ba6946a6d0ca691f105a376d401e5b
#42 PR #51 @ 6ddb0c40f8e24394e743eb5a917668e9c3566c3c
#43 PR #52 @ f743b91abda1aa9ae28ac2e67de3af8daeb5d12a
#44 PR #53 @ 09ea1ac54c5163f34545540241eb20ee42ee1542
#45 PR #54 @ ac34ab9b6b69baa4e53403d33353684bcb591448
#46 PR #55 @ a61c23e93edff60604e15c4872be14bb33fe6354

All are READY_FOR_REVIEW-quality research artifacts; ordinary review is not an execution dependency.

## Consolidated matrix
| Hallazgo | Evidencia/fuente | Alternativas | Recomendación de investigación | Decisión humana pendiente | Impacto técnico | Reuse/New | Verificación futura |
|---|---|---|---|---|---|---|---|
| loop runner sin metajuego | #39 + prior #6–#10 | traversal/gate/obstacle/combat/final | loop mínimo segmentado con resultado/retry | final condition, Santa health | Run/Army/Gate/Combat/Result | NEW | LOOP-001/002 |
| gates | #39/#7/REP-001 ref | +,-,×,%,conditional | evaluar + y × primero por lectura | fórmulas/values/caps/rounding | Army/Gate | NEW | arithmetic/idempotency/playtest |
| formación | #39/#6/#46 | slots, slots+local, steering, nav | slots deterministas como baseline hypothesis | cap/feel | Formation/Movement | NEW | X46-01 + stability |
| herramientas | #40 | combat/break/avoid verbs | bastón/snowball, martillo, hazards as small test set | exact set/semantics/tone | Combat/Tool/Obstacle | NEW | OBS-001/002 |
| destrucción | #40/#43 XREP-003/004 | swap/prefracture/physics/Voronoi | simple swap/prefracture baseline; XREP-004 only if needed | true fracture? | Obstacle/VFX/Physics | XREP-004 ADAPT candidate | X46-03 |
| etapas | #41/#10 | 1/2/3 | kit modular supports 1–3; don't approve 3 by default | stage count/duration/themes | Level data/tools/loading | NEW + asset ADAPT | telemetry/authoring validation |
| personajes | #42 | Santa + shared humanoid helpers + optional roles | one helper family + modular variation baseline | roles/Santa health/style | Rig/Animator/Combat | assets ADAPT/NEW hero art | retarget/silhouette |
| boss | #42/#8 | none/final troops/simple/phased/adds | no-boss or simple boss are prototype alternatives | boss yes/no | encounter/AI/art/VFX/QA | NEW | boss spike only if approved |
| public code | #43 | REP + XREP-001..006 | reuse narrowly | approve imports later | provenance/dependency | XREP-004/006 ADAPT candidates; rest ref | compatibility/license/profile |
| assets | #44 | primary license pages | CC0 Kenney/Poly Haven; Mixamo/QAL conditional | final shortlist | art pipeline/repo rights | ADAPT candidates | per-file provenance/import audit |
| visual | #45 | Unity localization/W3C reference + project evidence | low-poly, toy, storybook | A+B hybrid baseline for prototype test | materials/camera/HUD | transformed assets + NEW identity | VIS-001..005 |
| Android | #46/#9 + Unity/Android docs | GO/central/jobs/ECS; render/anim/physics tiers | behavior abstraction + measured simplest backend | devices/FPS/cap/memory | all runtime architecture | NEW + optional utilities | X46-01..06 |

## Recomendaciones no equivalen a aprobación
1. Prototipo sin metajuego; una etapa vertical slice puede probar loop antes de comprometer 3.
2. Santa + una familia de ayudantes humanoides reduce variedad de rigs; final identity must be original.
3. Gates aditivos/multiplicativos y tres verbos (combat/break/avoid) ofrecen un test compacto.
4. Boss no es requisito; comparar no-boss vs boss simple por coste/valor.
5. Low-poly + toy-diorama es baseline visual para prototipado, no art direction final.
6. Pool/crowd/render choices remain measurement-driven.

## Reuse consolidado
### ADAPT candidates
- XREP-004 sinanata/unity-mesh-fracture MIT @ dd04f3... — only if true fracture approved + Unity/Android profiling.
- XREP-006 SST-Systems/Pooling MIT @ 8dd93d... — only if value over UnityEngine.Pool.
- Kenney CC0 Holiday/Prototype/UI/Input/Audio materials.
- Poly Haven CC0 snow/wood materials.
- Mixamo official royalty-free game use candidate; raw redistribution/repo handling requires terms review.
- Quaternius QAL candidate; product use allowed, standalone asset redistribution prohibited; exact pack check required.

### REFERENCE_ONLY / no import
REP prior classifications; XREP-001/002 runner; XREP-003 destruction; XREP-005 state machine; Freesound/OGA until exact item license pinned.

### NEW/original required
Santa hero expression/model treatment; elf/helper identity; enemy/boss identity; gate visual language; game-specific combat/tool/army/gate/result domain; level composition; HUD styling.

## Originality risks/gates
ORIG-001 side-by-side review before final Santa/enemy/boss approval.
ORIG-002 no complete asset demo/template used as final scene.
ORIG-003 distinguish allies/enemies/gates by silhouette/value/icon/motion, not copied palettes.
ORIG-004 per-file provenance before import.
Grinch/distinctive third-party characters: DO_NOT_REUSE.

## Research Gates
RG-XMAS-01 PRODUCT LOOP: gate formulas, Santa health, final condition/boss, tool set. Supervisor PENDING.
RG-XMAS-02 CONTENT SCOPE: 1/2/3 stages, themes, duration/content budget. Supervisor PENDING.
RG-XMAS-03 ART: visual direction, hero/enemy model sheets, asset shortlist, originality review. Supervisor PENDING.
RG-XMAS-04 ANDROID: exact Unity/packages, target devices, FPS/memory/unit hypotheses. Supervisor PENDING.
RG-XMAS-05 REUSE: approve any XREP-004/006 or restricted-source asset import after exact compatibility/license review. Supervisor PENDING where product/repository policy is material.

## Mandatory experiments before architecture/performance acceptance
X46-01 crowd update; X46-02 render/animation; X46-03 physics/destruction; X46-04 lifecycle; X46-05 thermal sustained; X46-06 asset/load. All NOT RUN.
Visual/playtest: LOOP-001/002, OBS-001/002, VIS-001..005. All NOT RUN.

## UNKNOWN
Target device matrix, FPS/memory/crowd budgets, stage count/duration, boss, Santa health, exact gate values, exact tool set, final character/music/VFX/font assets, final art direction, measured backend winner, raw-file repository permissions for conditional asset services.

## Minimum human decisions before development
1. choose prototype content scope (stage count/themes);
2. choose loop semantics (Santa health/final/boss/gates/tool set);
3. approve visual baseline/originality direction;
4. define Android audience/device/performance targets;
5. decide whether conditional third-party code/assets may be imported under recorded terms;
6. authorize a separate implementation phase. Research alone does not authorize product code.
