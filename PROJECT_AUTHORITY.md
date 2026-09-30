# PROJECT AUTHORITY MAP — Christmas Android Prototype

Work Item: #57
Status: CANONICAL CURRENT CONTEXT / READY FOR COLD-HANDOFF VERIFICATION
Date: 2026-09-30

## Read this first
This document is the current-context authority map. Historical research remains evidence and is not silently rewritten. Where a later explicit Supervisor decision conflicts with older research/spec text, the later decision controls current product context until incorporated by SPEC FREEZE.

## Product — CONFIRMED by Supervisor
- Deliverable: **playable prototype**.
- Platform: **Android only**.
- Delivery target: **installable APK**.
- Play Store/commercialization: **DEFERRED** to a later commercial phase.
- Genre/base: **3D runner**.
- High-level loop: **run → army → gates/decisions → obstacles/interactions → combat → result**.
- Theme: **Christmas**.
- Protagonist: **Santa**.
- Army/crowd: **elves / Christmas helpers**.
- Languages: **Spanish + English**.
- Kingdom/metagame: **OUT_OF_SCOPE** for this prototype.
- Boss: **CONFIRMED = YES** by Supervisor reviews after research #42/#47.
- Identity: characters, visual expression, UI/composition and game-specific presentation must be original. External games are mechanical/engineering references only.

Authority: Issue #57 plus Supervisor reviews on PR #48/#51/#56. These decisions post-date PR #56 research HEAD.

## Current status vocabulary
CONFIRMED = explicit human product decision.
PROPOSED = researched recommendation, not approved.
PENDING = explicit human/technical decision remains.
UNKNOWN = evidence insufficient.
OUT_OF_SCOPE = excluded from this prototype.
DEFERRED = intentionally later phase.

## PENDING / UNKNOWN — do not implement silently
- final number of stages; duration; whether exactly 3;
- village/forest/ice-fortress as final scenario set;
- boss placement, mechanics, phases/adds/complexity;
- Santa health model and any HP/life count;
- exact defeat/victory semantics around Santa/army/boss;
- gate operations/values/caps/rounding/zero-army behavior;
- final tools/weapons;
- final art direction/assets/audio/VFX/font;
- crowd runtime backend;
- exact Unity/URP/Input/packages baseline;
- Android graphics API/device matrix;
- FPS/max units/CPU/GPU/memory/thermal budgets;
- any external code or asset import.

## Authoritative research batch
All below are open PRs and were SEMANTIC_ACCEPTED **as research only**, not merged/implementation-authorized:
- #39 / PR #48 @ `53b28c930a7963eb617271d2113dfcae233ab19e` — loop/gates/army.
- #40 / PR #49 @ `e41c7defe252c57128c47a20063de8dc97af9dbc` — tools/obstacles/destruction.
- #41 / PR #50 @ `e42590bd90ba6946a6d0ca691f105a376d401e5b` — stages/modular levels.
- #42 / PR #51 @ `6ddb0c40f8e24394e743eb5a917668e9c3566c3c` — characters/enemies/boss alternatives.
- #43 / PR #52 @ `f743b91abda1aa9ae28ac2e67de3af8daeb5d12a` — public code candidates.
- #44 / PR #53 @ `09ea1ac54c5163f34545540241eb20ee42ee1542` — assets/licenses.
- #45 / PR #54 @ `ac34ab9b6b69baa4e53403d33353684bcb591448` — visual/mobile legibility.
- #46 / PR #55 @ `a61c23e93edff60604e15c4872be14bb33fe6354` — Android/performance.
- #47 / PR #56 @ `21f8a8aa82cf0152fc3eefdd7bd71ba8454a3cfc` — consolidation.

Research acceptance does NOT mean merge, ADR acceptance, reuse/import approval, performance validation, or implementation authorization.

## Research Gates — current
- **RG-XMAS-01 GAMEPLAY/LOOP — PARTIAL/PENDING.** Boss YES confirmed. Santa health, damage/defeat/victory, gate semantics, tool/weapon set, boss structure remain PENDING.
- **RG-XMAS-02 CONTENT SCOPE — PENDING.** Stage count/duration/scenarios/progression/onboarding/difficulty/content minimum unresolved.
- **RG-XMAS-03 ART/ORIGINALITY — PENDING.** Originality constraint confirmed; final direction/character/boss/environment/HUD/VFX assets unresolved.
- **RG-XMAS-04 ANDROID/PERFORMANCE — PENDING/BLOCKED FOR BENCHMARKS.** No numeric targets/backend accepted.
- **RG-XMAS-05 REUSE/LICENSE — PENDING.** Candidates researched; no import authorized.

## Experiments
X46-01 crowd update; X46-02 rendering/animation; X46-03 physics/destruction; X46-04 lifecycle/pooling; X46-05 thermal; X46-06 asset/load: **NOT RUN** as of PR #55. If executable project/device prerequisites are absent, next gate must mark exact tests **BLOCKED_BY_IMPLEMENTATION_SPIKE**, not fabricate results.
LOOP-001/002, OBS-001/002, VIS-001..005: NOT RUN.

## External code candidates
Research only; see PR #52 and `research/christmas/PUBLIC_CODE_CATALOG.md`.
- XREP-004 sinanata/unity-mesh-fracture @ `dd04f3dc16d2dcc61d12d62258c84845e795ba4c`: MIT research candidate, ADAPT only after exact compatibility/license/profiling gate.
- XREP-006 SST-Systems/Pooling @ `8dd93d340cf6f582ef8a6e0c3924b6b06ca6656a`: MIT research candidate; compare UnityEngine.Pool before any adoption.
- other XREP/REP classifications remain REFERENCE_ONLY/UNKNOWN_LICENSE as recorded.
No external code is approved for import.

## Asset candidates
See PR #53 and `research/christmas/ASSET_LICENSE_MATRIX.md`.
Kenney/Poly Haven CC0 candidates; Mixamo/Quaternius conditional candidates; Freesound/OpenGameArt item-specific discovery sources. **No asset is approved for import.** Exact item provenance/license/redistribution/compatibility must be pinned before use.

## ADRs/specifications
`decisions/adr/` ADR-001..007 are historical **PROPOSED/PENDING**, not Supervisor-accepted architecture.
`docs/specifications/` are pre-Christmas baseline specifications from #13. They are useful inputs but **NOT current frozen product specs**. Known superseded/misaligned items include metagame/progression requirements and boss OPTIONAL wording. A later SPEC FREEZE must update them after Research Gates.

## Originality gate
DO_NOT_REUSE: Grinch or other distinctive third-party characters; proprietary Top Lords assets/code/UI/content; recognizable third-party composition/trade dress.
Required before production art: original Santa/helper/enemy/boss expression, side-by-side originality review, per-file provenance, and mobile legibility validation.

## What an agent may do now
- execute #57 documentation/handoff;
- create/execute separate persistent Research Gate work items;
- research Santa health patterns and boss semantics;
- update evidence, matrices, gates, specifications only within their Issues;
- design experiments and identify exact implementation-spike prerequisites.

## Not authorized
- gameplay/product code;
- production levels;
- APK generation;
- importing external code/assets;
- accepting ADRs autonomously;
- inventing performance results/budgets;
- merging/self-approving PRs;
- modifying workflow.

## Next persistent tranche
After #57: separate Issues for RG-XMAS-01..05 in parallel. Then SPEC FREEZE after sufficient gate decisions; then independent PREIMPLEMENTATION AUDIT. Implementation starts only after audit + Supervisor authorization.

## Core authority pointers
- workflow: `workflow/research/ORCHESTRATION.md`
- protocol: `workflow/research/RESEARCH_PROTOCOL.md`
- current research consolidation: `analysis/findings/CHRISTMAS_PROTOTYPE_CONSOLIDATION.md` (historical as of PR #56 HEAD; boss status superseded by later Supervisor decision)
- state/handoff: `research/RESEARCH_STATE.md`, `workflow/research/SESSION_HANDOFF.md`
- specs: `docs/specifications/` (not frozen for Christmas prototype)
- reuse: `reuse/REUSE_MATRIX.md` + PR #52/#53 Christmas catalogs
