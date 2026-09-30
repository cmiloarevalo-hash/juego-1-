> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Levels, Camera, Authoring and UX

Work Item: #10

## Observable reference
**SOURCE CLAIM (TL-001/TL-002):** Top Lords describes left/right swipe path choice, mechanisms that increase ranks, enemies, one-handed/simple-touch play, resource/territory progression and hero/griffin metagame.
**UNKNOWN:** exact level segment file format, camera rig, checkpoint system, obstacle taxonomy and internal authoring tools.

## Level composition model
Candidate runner level is modeled as ordered **segments** with explicit authored events rather than hidden scene-object behavior:
- traversal/path-choice segment;
- gate/mutation segment;
- obstacle/hazard segment;
- enemy/combat encounter;
- boss/end encounter if required;
- reward/result transition.

**INFERENCE:** segment metadata should define stable IDs, start/end markers, allowed lateral/path space, spawn/gate/encounter references, camera overrides and validation constraints. This supports deterministic verification and authoring without requiring one giant scene.

Alternatives:
1. scene-per-level with MonoBehaviour configuration;
2. scene geometry + ScriptableObject level definition;
3. modular segment prefabs + data graph/list;
4. fully procedural generation.

No evidence requires procedural generation. Option 4 remains out of target unless later product scope authorizes it.

## Authoring
**VERIFIED FACT (UNITY-011):** ScriptableObject assets can centralize project data independently of GameObjects and be referenced by scenes/assets.
Candidate data split:
- immutable design definition asset;
- scene/prefab presentation references;
- runtime state generated from definition;
- save/progression state stored separately (ScriptableObject is not runtime save persistence in deployed builds).

Validation needs:
- duplicate IDs;
- missing gate/enemy/prefab references;
- overlapping/invalid segment bounds;
- unreachable path;
- missing result/end marker;
- capacity beyond configured validation limits;
- camera framing test bounds.

## Camera alternatives
A. fixed-offset follow of army leader/centroid;
B. follow centroid with damped lateral/forward framing;
C. segment-authored camera zones/overrides;
D. Cinemachine follow/composition pipeline after package Research Gate.

**VERIFIED FACT (UNITY-012):** Cinemachine is Unity's camera package and current Unity 6 documentation lists Cinemachine 3.x, while older evidence uses 2.x. Exact API/version must be pinned before implementation.

Candidate camera behaviors (**INFERENCE**):
- forward look-ahead to show path choices;
- framing expands/offsets with crowd width only within readability constraints;
- transitions avoid obscuring gate labels/enemy telegraphs;
- boss/end zones can override framing through explicit segment data;
- camera state is presentation, not gameplay authority.

## UX/feedback
Observable storefront promise centers on simple one-hand input and consequential path choice. Candidate feedback:
- gate operation readable before commitment;
- immediate army-count change after mutation;
- clear damage/death/combat contact;
- result/reward transition;
- pause/retry affordances;
- hero/metagame UI separated from runner HUD.

Accessibility/open questions: text size, color-only gate encoding, haptics, motion sensitivity and localization require specification; no unsupported target values are asserted.

## Loading/content packaging
Addressables are an available Unity asset-loading system in documented versions, but **UNKNOWN** whether target needs remote/dynamic content. Do not adopt Addressables merely because available; package/version/content strategy belongs to Research Gate/ADR.

## Candidate requirements
LEVEL-CAND-001 Each authored level/segment SHALL have stable identity and validation.
LEVEL-CAND-002 Runtime mutable state SHALL be separated from immutable authoring definition.
CAM-CAND-001 Camera SHALL preserve visibility of upcoming decisions and active combat.
UX-CAND-001 Gate semantics SHALL not rely exclusively on color.
UX-CAND-002 Input and HUD SHALL support the one-hand/simple-control product intent.
AUTHOR-CAND-001 Authoring validation SHALL fail visibly on missing references/invalid ordering rather than silently accepting malformed content.

## Verification proposals
- editor validation tests for malformed definitions;
- deterministic play-through harness with scripted input;
- screenshot/reference framing tests at min/max supported formation extents;
- localization expansion checks;
- camera transition tests across gate/combat/end boundaries.
