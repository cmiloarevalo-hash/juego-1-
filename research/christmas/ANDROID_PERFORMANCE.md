# Investigación Android — crowd, render, animación, física y presupuesto

Work Item: #46

## Evidencia heredada
#9 ya documenta profiling, pooling/GC, rendering, animation, physics, thermal methodology y EXP-PERF-001..007. REP-002..007 aportan estructuras de crowd pero no benchmarks del producto.

## Evidencia primaria nueva
**VERIFIED FACT (Unity):** para métricas realistas se debe perfilar el Player en la plataforma/dispositivo objetivo; Android puede conectarse al Profiler por red/ADB.
**VERIFIED FACT (Android Developers):** thermal throttling puede reducir frecuencias CPU/GPU; Thermal API expone estado/headroom según versión.
**VERIFIED FACT:** Android Frame Pacing/Swappy está integrado en Unity y Optimized Frame Pacing puede habilitarse en Player settings.
**VERIFIED FACT:** Android Performance Class existe desde Android 12 y describe capacidades por clase, pero no sustituye una matriz real de dispositivos.
Fuentes consultadas 2026-09-30:
- https://docs.unity.com/en-us/engine/6000.0/manual/platform-specific/android/developing/testing-and-debugging/profile-on-an-android-device
- https://developer.android.com/games/optimize/adpf/thermal
- https://developer.android.com/games/sdk/frame-pacing
- https://developer.android.com/topic/performance/performance-class

## Arquitectura de crowd
Comparar:
A. GameObjects/MonoBehaviours por unidad;
B. manager central + datos/Transforms;
C. Jobs/Burst para movement/formation;
D. Entities/DOTS sólo tras gate de versión/beneficio.
Neighbor lookup: ninguno si slots sin avoidance; all-pairs; grid/hash; Physics queries.
**RECOMENDACIÓN:** comportamiento primero independiente del backend; medir A/B/C antes de adoptar D.

## Lifecycle/pooling
Comparar preallocation fija, UnityEngine.Pool/otro pool, Instantiate/Destroy. Medir mutation spike, allocations/GC, memoria retenida, reset correctness. XREP-006 no se adopta hasta compararlo con API Unity.

## Rendering
Factores: visible units, mesh/material count, skinned vs static, shadows, lights, transparency/overdraw, VFX.
GPU instancing puede reducir draw calls para meshes/materiales compatibles; no asumir compatibilidad con representación skinned elegida.
Probar SRP Batcher/instancing según Unity/URP fijados.

## Animación/rig
Comparar Animator por unidad; culling; update throttling/LOD; shared/retarget clips; alternativa GPU/vertex sólo si crowd lo exige.
Medir Animator CPU, skinning, GPU, memory. Santa/boss pueden conservar mayor fidelity que crowd.

## LOD/materiales/sombras
Diseñar tiers cualitativos (near/mid/far/offscreen) pero no distancias inventadas. Evaluar shadows: hero-only, near units, blob/contact proxy, none for crowd. Nieve/hielo deben evitar shaders transparentes complejos por defecto hasta profiling.

## Física
Comparar:
- colliders por unidad;
- proxy collider por army/encounter;
- custom spatial contact;
- rigidbody debris sólo en subset.
Layer filtering y fixed timestep se miden junto a correctness. Destruction EXP-XMAS-OBS-001 se integra aquí.

## Memoria/carga
Medir meshes/textures/animation clips/Animator/pools/native+managed heap, scene/load spikes. Assets #44 de alta resolución deben tener import settings móviles; no usar resolución fuente como runtime por defecto.

## Presupuesto
FPS target: **UNKNOWN**.
Max units: **UNKNOWN**.
CPU/GPU frame budget: **UNKNOWN**.
Memory ceiling: **UNKNOWN**.
Thermal acceptance: **UNKNOWN**.
Target mid-range Android device(s): **UNKNOWN**.
No número se propone hasta decisión humana/dispositivo y medición.

## Experimentos reproducibles
### X46-01 Crowd update sweep — NOT RUN
ENV: exact Unity/URP/package commit/build + physical Android model/SoC/RAM/OS/API/graphics backend/thermal start.
SCENE: same unit mesh/animation disabled initially; same path/formation.
ALTERNATIVES: A/B/C above.
SWEEP: counts chosen after target capacity hypothesis; record each exact count.
METRICS: CPU main/worker, GC alloc, frame-time distribution, correctness.
RAW: `analysis/experiments/X46-01/`.

### X46-02 Rendering/animation matrix — NOT RUN
Same positions/camera. Toggle static vs skinned/Animator; culling/LOD; batching/instancing-compatible representation.
METRICS: CPU render/animation, GPU frame, batches/draws/setpass where profiler exposes, triangles/verts, memory.
RAW X46-02.

### X46-03 Physics/destruction — NOT RUN
Compare no per-unit collision/proxy/per-unit; obstacle swap/prefracture/XREP-004 prebaked fracture if approved.
METRICS: Physics CPU, active bodies/colliders, GC, frame spikes, visual correctness.
RAW X46-03.

### X46-04 Pool/lifecycle burst — NOT RUN
Identical army mutation sequence. Compare preallocated/Unity pool/Instantiate; optionally XREP-006.
METRICS: CPU spike, alloc/GC, retained memory, reset failures.
RAW X46-04.

### X46-05 Sustained thermal — NOT RUN
Run representative loop continuously on each selected device; record thermal state/headroom where supported, CPU/GPU/frame-time over elapsed time, battery/power indicators available, memory growth. Duration is set in test protocol before run; not invented here.
RAW X46-05.

### X46-06 Asset/load — NOT RUN
Load each candidate stage/asset tier from cold/warm conditions; record load time, peak memory, texture/mesh/animation footprint. Compare import resolutions/LOD.
RAW X46-06.

## Research Gate RG-XMAS-ANDROID-001 — DRAFT
DECISION POINT: supported Unity/URP/Input/animation/performance package versions + Android graphics API/device matrix.
NEED: mutable platform/package behavior and all performance experiments depend on exact versions.
CURRENT EVIDENCE: #9 RG-PERF-001 + current official Unity/Android docs.
PROPOSED APPROACH: immediately before implementation experiment spike, refresh supported versions, pin them, select at least representative lower/mid target devices from actual product audience constraints.
SUPERVISOR VERIFICATION: PENDING.

## Decisiones humanas
target Android OS/device tier; performance target; crowd capacity hypothesis; visual fidelity priority; whether true fracture/boss is in scope. Technical winner follows experiments, not preference.
