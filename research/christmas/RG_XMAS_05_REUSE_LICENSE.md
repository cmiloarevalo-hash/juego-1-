# RG-XMAS-05 — Reuse / License

Issue #63
Access date: 2026-09-30
Status: PARTIAL/PENDING. No import performed.

## Code decisions
### XREP-004 sinanata/unity-mesh-fracture
PINNED RESEARCH SHA: `dd04f3dc16d2dcc61d12d62258c84845e795ba4c`.
LICENSE: MIT, repository LICENSE/CITATION. Attribution/license notice required by MIT when copied.
MODIFICATION/BINARY/SOURCE: MIT permits use/copy/modify/distribute/sublicense/sell subject to notice.
DEPENDENCIES: runtime described as UnityEngine; URP material setup; current upstream now documents Unity 6000.x, tested 6000.0/6000.3 and pre-bake.
ANDROID RISK: synchronous fragmentation/main-thread cost if misused; physics fragments; memory/cache; must X46-03 profile.
VALUE: HIGH only if true mesh fracture is a confirmed visual mechanic; otherwise unnecessary.
DECISION: **REFERENCE_ONLY NOW; ADAPT ELIGIBLE LATER** only if destruction scope explicitly selects true fracture + compatibility/profile passes. No import authorization.

### XREP-006 SST-Systems/Pooling
PINNED SHA: `8dd93d340cf6f582ef8a6e0c3924b6b06ca6656a`.
LICENSE: MIT / LICENSE.md; attribution notice if copied.
UPSTREAM REQUIREMENT: Unity 2021.3+; generic C# Pool/MultiPool.
DEPENDENCIES: no material external dependency recorded.
ANDROID RISK: low intrinsic; correctness/reset remains our responsibility.
VALUE: LOW because Unity provides pooling facilities and bespoke lifecycle contract is small.
DECISION: **REFERENCE_ONLY** unless X46-04 proves a missing capability. Do not adopt by default.

### REP-001/002/006/007
UNKNOWN_LICENSE from pinned prior analysis → **UNKNOWN/BLOCKED / no copy-adapt**.

### REP-003/004
MIT verified but program prior decision REFERENCE_ONLY; no demonstrated need to import → **REFERENCE_ONLY**.

### REP-005
GPL-3.0; program avoids license-strategy coupling → **REFERENCE_ONLY / no baseline import**.

## Asset decisions
### Kenney Holiday Kit
ITEM: Holiday Kit v2.0 (page lists 2024-11-12 update), CC0.
ATTRIBUTION: not required by CC0.
MODIFICATION/BINARY/RAW redistribution: CC0 permits.
FORMAT/TECH: 3D, 100 files, animation advertised; exact downloaded files/poly/material metrics not inspected.
VALUE: HIGH prototype environment/props.
DECISION: **ADAPT ELIGIBLE, NOT IMPORT-AUTHORIZED** pending human asset shortlist/originality gate. Preserve provenance anyway.

### Poly Haven
SITE ASSETS: CC0; primary license explicitly permits commercial use, modification/redistribution and inclusion in sold product without attribution.
Exact candidates previously Snow 02 / Coated Pine; item/version/download hashes not pinned.
DECISION: **ADAPT ELIGIBLE, BLOCKED ON EXACT ITEM SNAPSHOT** before import.

### Adobe Mixamo
Official FAQ: characters/animations royalty-free for personal/commercial/non-profit projects including video games; bipedal humanoid service.
FAQ does not, in evidence reviewed here, establish permission to redistribute raw source files as a standalone asset library.
DECISION: **ADAPT ELIGIBLE FOR GAME OUTPUT / UNKNOWN-BLOCKED FOR RAW REPOSITORY REDISTRIBUTION** until applicable Adobe terms for downloaded files are pinned. Prefer animations applied to our original models if terms permit.

### Quaternius
Prior #44 records QAL v1.0 product-use/modification and standalone-asset redistribution restriction. Exact selected pack/item not fixed in #57 state.
DECISION: **REFERENCE_ONLY / BLOCKED ON EXACT PACK+CURRENT LICENSE SNAPSHOT** before any import.

### Freesound/OpenGameArt
Per-item licenses vary → **REFERENCE_ONLY DISCOVERY SOURCE** until exact item/license chosen.

## Adoption status vocabulary
No candidate is ADOPTED in this gate because Supervisor has not selected an import. “ADAPT ELIGIBLE” means license/evidence permits consideration, not authorization.

## Recommended clean baseline
Implement game-specific army/gates/combat/boss/level logic as NEW code from specifications. Use external code only when measured savings exceed dependency/provenance cost. Prefer CC0 modular environment/raw materials over complete themed templates; original hero/enemy/boss/UI expression remains NEW.

## Gate result
**RG-XMAS-05 = PARTIAL/PENDING.**
License blockers are explicit; no external code/assets imported.
