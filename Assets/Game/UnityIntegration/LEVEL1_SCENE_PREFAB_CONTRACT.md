# Level 1 Scene / Prefab Integration Contract

This is preparatory authoring guidance. Nothing here is runtime evidence.

## Scene root
A future executable Level 1 scene should contain one `GameSessionBehaviour`, one Santa runner root, one `ContinuousRouteBehaviour`, one `RunnerCameraBehaviour`, one `ArmyFormationPresenter`, one `ChristmasEnvironmentPresenter`, trigger/presentation adapters, and one result presenter.

## Route modules
Author exactly eight ordered route-section roots matching `RouteSectionKind`: onboarding departure, growth, positive gates, obstacle/hammer, snowball combat, boss approach, boss arena, result. Sections are presentation/composition boundaries inside one continuous level; they are not additional levels or game states.

Each section prefab/root should expose an entry and exit transform so modules can be repositioned/replaced without changing domain code. Environment dressing may overlap section boundaries to preserve continuity.

## Gameplay adapter wiring
- Onboarding completion -> `GameSessionBehaviour.CompleteOnboarding`.
- Gate triggers -> only `ApplyAddGate` or `ApplyMultiplyGate` with stable ID and positive integer operand.
- Avoidable obstacle -> `HitObstacle`.
- Hammer interaction -> `UseHammer` through the existing breakable adapter/presentation.
- Snowball/combat -> existing combat adapters.
- Boss arena entry -> `StartBoss`; boss attacks and player/army attacks remain routed through existing boss APIs.
- Terminal result -> `ResultPresenterBehaviour`; no second result authority.

## Prefab contracts
Santa runner prefab: movement/input adapter, character visual/animator placeholder, collision root, optional camera target. No independent HP/hearts.

Elf visual prefab: presentation only. It must not own helper count, gate math, combat authority, or independent navigation state. `ArmyFormationPresenter` may render fewer visual elves than authoritative helpers for Android performance.

Gate prefab: sign/visual + collider/trigger + stable ID + positive operand. Variant is Add or Multiply only. No subtraction variant.

Obstacle prefab: avoidable collision representation. Hammer-breakable version uses authored intact/broken representations; no runtime fracture requirement.

Enemy/boss prefabs: visual/collider/animation adapters around existing domain state. Boss is one mandatory encounter and one phase only.

Environment modules: snowy/icy path, village dressing, mountain background and aurora sky are replaceable presentation assets. Side dressing cannot introduce mechanics.

## Android-first implementation notes
Prefer shared materials, static/batched scenery where practical, pooled elves/projectiles/effects, simple colliders, low component counts, conservative transparent particles and replaceable LOD/detail. Do not bake performance claims until measured on an executable target.

## NOT RUN
Unity serialization/import, prefab validity, scene references, camera feel, collisions, animation, lighting, VFX, compile, runtime playthrough, APK build, install/launch and Samsung validation remain NOT RUN until a compatible Unity environment exists.
