# Software Requirements Specification — Christmas Prototype Freeze
Status: FROZEN / SEMANTIC_ACCEPTED at PR #71 HEAD `09061b4ba372de41fb142ab4c43f1b4302f58083`. Authority: Supervisor decision Issue #57 comment 5914691381 (2026-09-30). Supersedes incompatible pre-Christmas #13 requirements for this prototype; historical Git remains evidence.

## Product boundary
SRS-PROD-001 [FROZEN] Playable Android-only 3D runner prototype delivered as installable APK.
SRS-PROD-002 [FROZEN] Christmas theme; original Santa protagonist; original elf/Christmas-helper army; Spanish + English.
SRS-PROD-003 [OUT_OF_SCOPE] Kingdom/metagame/strategic economy. Play Store/commercialization [DEFERRED].
SRS-SCOPE-001 [FROZEN] Exactly one complete vertical-slice stage: original Santa Christmas village/workshop under attack. Stage 2/3, snow forest, ice fortress [DEFERRED]. Duration [MEASUREMENT_DERIVED] by pacing/playtest.
SRS-LOOP-001 [FROZEN] onboarding/control → army growth → +/× gate choice → avoidable obstacle → hammer break → combat/snowball → final boss → result.

## Functional
SRS-INPUT-001 [FROZEN] Runtime SHALL map player lateral/path-choice intent through an input abstraction and remain controllable during traversal except explicit authored locks.
SRS-ARMY-001 [FROZEN] Maintain authoritative non-negative integer helper count independent of presentation objects.
SRS-HEALTH-001 [FROZEN] Army is Santa's baseline protection; ordinary damage removes helpers first; no independent Santa HP/hearts baseline; count reaching zero causes immediate defeat; no baseline solo-Santa state.
SRS-GATE-001 [FROZEN] Gates SHALL apply exactly once per gate/run and support only positive-integer +N and ×N baseline operations. Subtraction, percentage, conditional and fractional semantics are OUT_OF_SCOPE.
SRS-GATE-002 [MEASUREMENT_DERIVED] A configurable technical army capacity SHALL exist; numeric value comes from profiling/spike, never silent tuning.
SRS-FORM-001 [FROZEN] Formation representation SHALL update after army mutation/death while leaving exact crowd backend replaceable.
SRS-TOOL-001 [FROZEN] Snowball provides ranged/combat verb; toy-maker hammer provides obstacle-breaking verb. Candy-cane melee, axe, sleigh/ram and extra tools OUT_OF_SCOPE baseline.
SRS-OBS-001 [FROZEN] Destruction SHALL use authored state transition/mesh swap/prepared broken representation; runtime mesh fracture OUT_OF_SCOPE.
SRS-COMBAT-001 [FROZEN] Combat SHALL expose authoritative targeting/attack/damage/death semantics; animation/presentation SHALL NOT be gameplay authority.
SRS-BOSS-001 [FROZEN] Required final encounter: one phase, readable telegraphed attacks, army participates, no adds/multiple phases baseline.
SRS-RESULT-001 [FROZEN] Boss defeat SHALL produce victory/result exactly once; zero army SHALL produce defeat/result exactly once; post-result gameplay mutation stops.
SRS-UX-001 [FROZEN] Gates use symbol/value plus shape/border and never rely on color alone.
SRS-LOC-001 [FROZEN] Player-facing critical UI SHALL support ES+EN including required Spanish glyphs/overflow validation.
SRS-ART-001 [FROZEN] Baseline visual grammar is low-poly + toy-workshop/diorama with original Santa/helpers/enemies/boss/UI/level composition and mostly opaque/matte materials.

## Technical/non-functional
SRS-TECH-001 [FROZEN] Unity 6.3 LTS family + URP + Unity Input System; Android; landscape. Exact patch/packages/API/ABI/backend config = BOOTSTRAP_PIN.
SRS-PERF-001 [FROZEN] Acceptance baseline: stable 30 FPS on selected lower representative Android target device and no sustained thermal collapse in defined sustained test. 60 FPS NON_BLOCKING_STRETCH.
SRS-PERF-002 [MEASUREMENT_DERIVED] Max army, CPU/GPU budgets, memory ceiling and exact thermal/device thresholds derive from X46 evidence.
SRS-REUSE-001 [FROZEN] Runner/army/gates/combat/boss/level logic NEW code baseline. Unknown-license repositories DO_NOT_COPY/ADAPT.
SRS-ORIG-001 [FROZEN] No Grinch/distinctive third-party character, Top Lords identity/proprietary asset/UI, recognizable third-party composition or trade dress.


## Product-quality requirements resolved by Supervisor review 5370716635
SRS-VUX-001 [SUPERVISOR_ACCEPTED] Product-facing character, camera, HUD/result, animation, VFX/audio, typography/palette, environment-composition and onboarding/pacing requirements SHALL conform to `VISUAL_UX_CONTENT_SPECIFICATION.md` VUX-CHAR/CAM/UI/ANIM/FX/TYPE/ENV/PACE.
SRS-VUX-002 [SUPERVISOR_ACCEPTED] Product-quality acceptance SHALL use `QUALITY_ACCEPTANCE_SPECIFICATION.md` QA-VUX-* and the required VUX-EVID-* evidence bundle.
SRS-VUX-003 [FROZEN] Exact numeric tuning, performance/device results and exact external asset/code items are not created by these VUX requirements; BG-009/010 remain measurement-required and BG-011 remains provenance-required.
