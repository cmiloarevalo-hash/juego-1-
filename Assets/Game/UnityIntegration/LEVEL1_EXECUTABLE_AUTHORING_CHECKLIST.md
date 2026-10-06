# Level 1 Executable Authoring Checklist

Purpose: make the next Unity-capable session mechanical and bounded. This checklist is NOT execution evidence.

## Scene composition
- Create/choose the single Level 1 scene.
- Add one GameSession composition root and wire the existing domain adapters.
- Build one continuous route with eight ordered `RouteSectionBehaviour` roots.
- Place Santa at onboarding departure and keep forward travel continuous through result.
- Attach third-person `RunnerCameraBehaviour` to the scene camera and assign Santa target.
- Attach `ArmyFormationPresenter`; assign session, Santa transform and replaceable elf visual prefab.
- Attach `ChristmasEnvironmentPresenter`; assign snowy path, village, mountains and aurora roots.

## Route authoring
- Onboarding/departure: readable starting lane and movement instruction.
- Growth: visually establish Santa + elf army without adding new mechanics beyond frozen growth semantics.
- Gates: author only positive `+N` and `xN` gate prefabs; unique stable IDs; no `-N` assets/adapters.
- Obstacle/hammer: provide avoidable lane geometry and authored intact/broken obstacle visuals.
- Combat: place snowball/enemy adapters using existing domain authority.
- Boss approach: environmental anticipation only; no new mechanic.
- Boss arena: mandatory one-phase encounter, continuous with Level 1 route.
- Result: connect the existing exactly-once result presenter; no duplicate terminal authority.

## Android-first presentation
- Prefer shared materials and repeated modular scenery.
- Keep elf visuals presentation-only and cap rendered representatives independently of authoritative helper count.
- Prefer simple colliders and authored swaps over runtime destruction/fracture.
- Treat snowfall/aurora/VFX as scalable decoration; they may be disabled/reduced without changing gameplay.
- Avoid per-decoration Update loops and per-elf autonomous AI/navigation.

## First executable verification when Unity becomes available
1. Import/serialize without missing scripts or references.
2. Clean compile.
3. Verify route contract/order and all required references.
4. Play from onboarding through result in editor; exercise both gate operations and defeat/victory.
5. Confirm result fires once and zero helpers defeat immediately.
6. Build Android Development APK from exact SHA.
7. Install/launch on available Android target and capture logs/provenance.

Until those steps are actually executed, report them as NOT_RUN rather than PASS.
