# PROJECT AUTHORITY MAP — Christmas Android Prototype
Current specification authority: Issue #64 freeze branch. Human freeze decision: Issue #57 comment 5914691381 (2026-09-30), which supersedes earlier PENDING/PROPOSED RG-XMAS-01..05 alternatives where conflicting.

## Frozen product
Playable Android-only installable-APK 3D Christmas runner prototype. Santa leads elf/Christmas helpers. ES+EN. One original Santa village/workshop vertical-slice stage: onboarding/control → army growth → +/× gate choice → avoidable obstacle → toy-maker hammer break → combat/snowball → one-phase final boss → exactly-once result.

Santa has no independent baseline HP/hearts: helpers protect him; ordinary damage removes helpers first; zero helpers = immediate defeat and no solo-Santa baseline. Boss is mandatory final encounter, one phase, telegraphed, army participates, no adds/multiphase.

Gates baseline: positive-integer +N and ×N, non-negative integer army domain, at-most-once per gate/run. Subtraction/percent/conditional/fractional gates OUT_OF_SCOPE. Technical army cap is MEASUREMENT_DERIVED.

Visual baseline: low-poly + toy-workshop/diorama; original Santa/helpers/enemies/boss/UI/composition; mostly opaque/matte. Gates use symbol/value + shape/border, never color alone. Grinch/distinctive third-party identity, proprietary Top Lords assets/UI and recognizable trade dress DO_NOT_REUSE.

## Technical baseline
Unity 6.3 LTS family, URP, Unity Input System, Android, landscape. BOOTSTRAP_PIN: exact stable patch, package versions/lock, min/target API, ABI, graphics backend order. Prefer Vulkan when validated; GLES3 fallback if supported.

Performance acceptance: stable 30 FPS on selected lower representative Android target device and no sustained thermal collapse under defined test. 60 FPS is non-blocking stretch. Max army/CPU/GPU/memory/exact thermal thresholds are MEASUREMENT_DERIVED. X46-01..06 are AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN.

## Scope exclusions/deferred
Kingdom/metagame/strategic economy OUT_OF_SCOPE. Stage 2/3, snow forest, ice fortress, Play Store/commercialization DEFERRED. Stage duration and tuning numbers derive from playtest, not arbitrary freeze values. Runtime mesh fracture OUT_OF_SCOPE.

## Reuse
Game-specific runner/army/gates/combat/boss/level logic NEW. unity-mesh-fracture and SST pooling REFERENCE_ONLY. Prefer Unity pooling absent evidence. Kenney Holiday Kit and Poly Haven CC0 ADAPT-eligible only after exact snapshot/provenance/originality review. Mixamo only after applicable terms/repository handling are pinned compliant. Quaternius/Freesound/OpenGameArt require exact item/license. Unknown-license repositories DO_NOT_COPY/ADAPT. No import occurs in Stage 1.

## Architecture
Frozen boundaries: Input, Run, Army Domain, Formation/Movement, Gate, Obstacle/Tool, Combat, Boss, Result, Presentation, Localization, optional minimal Settings, Instrumentation. Crowd representation/backend remains measurement-driven and replaceable without changing domain semantics.

## Canonical implementation specification
Read docs/specifications/SOFTWARE_REQUIREMENTS_SPECIFICATION.md, GAMEPLAY_SPECIFICATION.md, SOFTWARE_ARCHITECTURE.md, TECHNICAL_SPECIFICATION.md, PERFORMANCE_SPECIFICATION.md, DATA_AND_PROGRESSION_SPECIFICATION.md, VERIFICATION_SPECIFICATION.md and SPEC_FREEZE_MATRIX.md at the exact #64 frozen HEAD recorded in handoff/audit.

Historical #39–#47 and RG-XMAS-01..05 remain evidence. The Supervisor decision comment is later authority. Historical files are not erased.

## Current authorization boundary
Stage 1 permits documentation/spec freeze/audit only. If #65 returns GO, GO means sufficient definition to begin a separately authorized Unity/Android Bootstrap + non-production performance/architecture spike. It does NOT itself authorize product gameplay, production level, asset/code import, APK release, merge, or self-approval.
