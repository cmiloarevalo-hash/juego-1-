# Investigación navideña — código público reutilizable y referencias

Work Item: #43
Access date: 2026-09-30

## Repositorios previos reutilizados
REP-001..REP-007 permanecen válidos con sus SHAs/licencias de #4/#5/#14. Ninguno se reclasifica sin nueva evidencia: REP-003/004 MIT REFERENCE_ONLY; REP-005 GPL-3.0 REFERENCE_ONLY; REP-001/002/006/007 UNKNOWN_LICENSE.

## Nuevos candidatos inspeccionados
### XREP-001 — sunsided/unity-endless-runner
URL: https://github.com/sunsided/unity-endless-runner
REF/SHA: master @ `0a05298545f3b46ea40dd35cd03c24193eba4f3b`
LICENSE: MIT, LICENSE verificado en repo.
STRUCTURE: Assets/Project/Scripts, Prefabs/Platforms, Packages/ProjectSettings.
CODE OBSERVATION: `GenerateWorld.RunDummy()` obtiene plataforma de `Pool.Singleton.GetRandomItem()`, posiciona según plataforma anterior/dirección y activa; `PlayerController`, `Scroll` y prefabs de platform sections forman runner/world recycling.
README SOURCE CLAIM: usa pooling, blended animation, particle systems y colliders/physics inicialmente desactivada para muro destructible.
COUPLING: proyecto runner completo antiguo + assets/frameworks terceros; no aislar assets sin provenance.
PERFORMANCE: pooling reduce churn conceptualmente; no aceptar benchmarks del repo como nuestros.
PROBLEM/SAVINGS: referencia concreta para recycling de tramos y destrucción prearmada; ahorro potencial MEDIUM como diseño, no código necesario.
CLASSIFICATION: **REFERENCE_ONLY** pese a MIT: versión antigua, acoplamiento de proyecto y no necesitamos identidad/assets.

### XREP-002 — lxndrblz/Unity-Endless-Runner
URL: https://github.com/lxndrblz/Unity-Endless-Runner
REF/SHA: master @ `bc619fd885134e892a8c1b3e5b8816e0635f01e6`
LICENSE: MIT file present.
PATHS: `Scripts/EndlessRunner.cs`, `ObjectPool.cs`, `TouchGestures.cs`, `PlayerScript.cs`; `Editor/PlaceObjectInspector.cs`.
CODE OBSERVATION: `EndlessRunner` models Forward/Corner/Fork/Stairway, prebuilds parts, tracks visited cells and deactivates obsolete pieces; `PlaceElement` obtains pooled object. `TouchGestures.Update` reads legacy `Input.GetTouch` and rotates runner on swipe-like delta.
LIMITATIONS: 2015-era APIs; monolithic `EndlessRunner`; `GameObject.Find`; gesture calculation is tightly coupled to transform movement and should not be adopted.
PROBLEM/SAVINGS: fork/recycling authoring reference; LOW-MEDIUM conceptual savings.
CLASSIFICATION: **REFERENCE_ONLY**.

### XREP-003 — williambl/unity-destruction
URL: https://github.com/williambl/unity-destruction
REF/SHA: master @ `2132640a5e0e84f5988387a808b8aeca6307eb55`
LICENSE: MIT (GitHub license metadata/repository).
PATH: `Destruction/Assets/Scripts/Destruction.cs`; example scene documented as `Destruction/main.unity`.
CODE OBSERVATION: `Destruction` manages intact/broken state, Rigidbody/Collider fragments, collision threshold/momentum option, support raycasts, audio/particles; public Break/BreakWithExplosiveForce described by project.
COUPLING/PERF: Rigidbody fragment arrays + raycasts can be expensive at scale; repo is old and no Android benchmark.
PROBLEM/SAVINGS: proves prebroken-fragment destruction pattern. MEDIUM reference savings.
CLASSIFICATION: **REFERENCE_ONLY**; prefer simpler authored swap unless #46 justifies physics.

### XREP-004 — sinanata/unity-mesh-fracture
URL: https://github.com/sinanata/unity-mesh-fracture
REF/SHA: main @ `dd04f3dc16d2dcc61d12d62258c84845e795ba4c`
LICENSE: MIT (repo metadata/CITATION.cff).
PATHS: `Assets/MeshFracture/Runtime/MeshFragmenter.cs`, `FragmentCache.cs`, `FractureBurst.cs`.
CODE OBSERVATION: `MeshFragmenter.Fragment` builds Voronoi-like cells by repeatedly clipping mesh against seed bisector planes, caps cut loops, emits exterior/cap submeshes; project docs state managed single-threaded implementation and pre-bake cache path. `FragmentCache` precomputes meshes/collider data; `FractureBurst` presents debris.
PERF: project documentation explicitly warns fracture computation is synchronous and recommends pre-bake; its own numeric timing claims are **SOURCE CLAIM**, not our benchmark.
DEPENDENCIES: current project states Unity 6 + URP and no runtime dependencies beyond UnityEngine; exact compatibility must be verified against our future pinned Unity.
PROBLEM/SAVINGS: runtime/prebaked 3D destruction could save HIGH implementation effort if true fracture is approved.
CLASSIFICATION: **ADAPT CANDIDATE** (MIT) subject to RG version compatibility, Android profiling, attribution and decision that true fracture is needed. Do not import yet.

### XREP-005 — richardlord/Unity-State-Machine
URL: https://github.com/richardlord/Unity-State-Machine
REF/SHA: master @ `5075a29c74416fa333100be216039a07a1fd6780`
LICENSE: README contains MIT license text; GitHub metadata does not identify SPDX license -> license source must be retained.
PATH: `Assets/StateMachine/StateMachine.cs`, Editor.
CODE OBSERVATION: `ChangeState` serializes/removes MonoBehaviours and reconstructs state components via JsonUtility/AddComponent.
LIMITATION: unusual component destruction/recreation, Unity 2017-era, allocations/serialization; poor fit for per-frame combatants.
PROBLEM/SAVINGS: state-machine concept only.
CLASSIFICATION: **REFERENCE_ONLY**.

### XREP-006 — SST-Systems/Pooling
URL: https://github.com/SST-Systems/Pooling
REF/SHA: main @ `8dd93d340cf6f582ef8a6e0c3924b6b06ca6656a`
LICENSE: MIT, `LICENSE.md`.
PATHS: `Runtime/Pool.cs`, `MultiPool.cs`, `Runtime/SST.Pooling.asmdef`, `package.json`.
CODE OBSERVATION: generic `Pool<T>` tracks free List + occupied HashSet; `Prewarm`, `Get`, `Release`, `Discard`, lifecycle callbacks; duplicate release is ignored by occupied-set check. Not thread-safe.
PROBLEM/SAVINGS: compact generic lifecycle utility; could replace bespoke pool bookkeeping.
CLASSIFICATION: **ADAPT CANDIDATE** (MIT), subject to package compatibility and comparison with UnityEngine.Pool already available in target Unity. Expected savings LOW because equivalent core API exists.

## Coverage matrix
Runner/input: XREP-001/002 + prior #6.
Crowd/formation: REP-002..007 remain deeper references; no new candidate found that beats provenance/analysis quality.
Gates/army: REP-001 reference only/UNKNOWN_LICENSE; original implementation remains safest.
Pooling/spawn: XREP-001/002/006 + UnityEngine.Pool.
Obstacles/destruction: XREP-003/004.
Combat/target/death: prior #8 contracts; no high-quality drop-in candidate selected.
Boss/state: XREP-005 concept only; original encounter state preferred.
Level authoring/camera/animation/mobile: prior #10/#9 + official Unity packages are higher-authority than template repos.

## Reuse recommendation
Potentially reusable code is intentionally narrow:
- XREP-004 ADAPT candidate only if true mesh fracture is approved and profiling passes.
- XREP-006 ADAPT candidate only if it offers value over UnityEngine.Pool.
Everything else REFERENCE_ONLY/UNKNOWN_LICENSE. No COPY candidate is justified.

## Research gaps
No public repo found in this pass provides a clean, licensed, current Unity implementation of the exact runner+army+gates+combat flow with acceptable provenance. **UNKNOWN** whether broader search would uncover one; absence from this search is not proof of absence.
