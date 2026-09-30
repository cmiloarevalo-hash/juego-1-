# RG-XMAS-04 — Android / Performance

Issue #62
Access date: 2026-09-30
Status: PARTIAL; benchmarks BLOCKED_BY_IMPLEMENTATION_SPIKE.

## Mutable primary evidence refresh
**VERIFIED FACT — Unity:** Unity 6.3 LTS (6000.3) is current LTS and supported to Dec 2027; Unity 6.0 LTS support runs to Oct 2026. Unity states LTS is suitable when locking production.
Source: Unity 6 release support / Unity 6.3 LTS official pages.

**RECOMMENDATION / PENDING SUPERVISOR:** baseline a new prototype on **Unity 6.3 LTS latest patch**, not 6.0, unless package/device compatibility evidence requires otherwise. Exact patch must be pinned at project creation; not selected here.

**VERIFIED FACT — current Unity Android manual:** Android support baseline is Android 6.0 / API 23+; Vulkan and OpenGL ES 3.x are supported. This is engine capability, not our product minimum-device decision.

**VERIFIED FACT — Unity Input System docs:** Input System is the extensible package alternative to classic input; package version must match selected editor stream. Existing research observed 1.17.0 for 6000.0 docs; **UNKNOWN** exact recommended version for the eventual 6000.3 patch until project Package Manager lock is created.

URP exact package version: **UNKNOWN until editor/project manifest is pinned**. Use URP candidate due #45 visual/performance direction, but do not fabricate version.

## Android baseline decisions still PENDING
Product min Android/API; Vulkan vs GLES3 ordering/fallback; architecture/ABI; orientation; device tier; graphics quality; frame target; memory/thermal criteria.

## Representative device method
Select physical devices only after audience/min-OS decision. Matrix should span at least the lower intended tier and a representative mid-tier device, recording model/SoC/GPU/RAM/OS/API/graphics backend/build/thermal start. This is methodology, not a device recommendation.

## Experiment readiness
There is no executable product/performance spike in repository authority state. Therefore:
| Experiment | Status | Minimal future prerequisite |
|---|---|---|
| X46-01 crowd update | BLOCKED_BY_IMPLEMENTATION_SPIKE | Unity 6.3 project; synthetic crowd scene; A/B/C backends; scripted path/count sweep; physical Android build + Profiler |
| X46-02 render/animation | BLOCKED_BY_IMPLEMENTATION_SPIKE | representative unit mesh/rig/material; fixed camera/positions; toggles for Animator/culling/LOD/batching; GPU-capable profiling |
| X46-03 physics/destruction | BLOCKED_BY_IMPLEMENTATION_SPIKE | synthetic obstacle scene; proxy/per-unit collider variants; swap/prefracture candidate; fixed collision script |
| X46-04 lifecycle/pooling | BLOCKED_BY_IMPLEMENTATION_SPIKE | synthetic army mutation harness; prealloc/UnityEngine.Pool/Instantiate variants; reset assertions |
| X46-05 thermal | BLOCKED_BY_IMPLEMENTATION_SPIKE + DEVICE_SELECTION | representative sustained loop from above + selected physical devices + thermal capture |
| X46-06 asset/load | BLOCKED_BY_IMPLEMENTATION_SPIKE + ASSET_SELECTION | approved representative assets/stage fixture + cold/warm load harness |

No experiment is RUN. No benchmark result exists.

## Minimal spike boundary
Future authorized **performance spike**, not production gameplay:
- empty/purpose-built Unity project at pinned 6.3 LTS patch;
- no branded/final assets;
- synthetic capsules/meshes and generated counts;
- instrumentation/profiler markers;
- Android Development Build;
- deterministic scripted workload;
- raw captures under analysis/experiments/X46-*;
- no gameplay/content polish.
Creating this spike is NOT authorized by #62; it is the prerequisite to be separately authorized after audit/gate decision.

## Gate result
**RG-XMAS-04 = PARTIAL / BLOCKED_BY_IMPLEMENTATION_SPIKE for measurement.**
Technical recommendation: Unity 6.3 LTS latest patch at project creation; exact packages/API/device/performance budgets remain PENDING.
