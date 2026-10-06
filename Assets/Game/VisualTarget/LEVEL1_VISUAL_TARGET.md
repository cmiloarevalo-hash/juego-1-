# Level 1 Visual Target — Human-selected reference authority

Status: HUMAN PRODUCT DECISION / durable implementation target.

## Scope boundary
This document translates the Human-selected reference into an implementation target. It does not add mechanics, levels, metagame, monetization, or progression systems. Frozen gameplay semantics remain authoritative.

## Visual target
Level 1 is one continuous 3D Christmas route, not a static backdrop. Santa/Viejo Pascuero and the elf army advance on foot along a central snowy/icy path. The side environment reads as a living Christmas village, with snow-covered mountains forming the distant silhouette and an aurora borealis providing the primary sky identity.

The environment should communicate forward travel through parallax, changing roadside composition and landmark progression. Prefer low-cost authored modules, pooled/reused decoration, baked/static lighting where practical, and replaceable presentation components suitable for Android.

## Route progression
The single route evolves in this order without scene-level semantic branching:
1. Onboarding / village departure.
2. Growth corridor where helper/army representation becomes legible.
3. Positive gate corridor using only `+N` and `xN`.
4. Avoidable obstacle + hammer interaction corridor.
5. Snowball/combat corridor.
6. Boss approach / visual compression and anticipation.
7. Mandatory one-phase boss arena.
8. Terminal result presentation.

No `-N`, percentage, fractional or conditional gate is authorized.

## Spatial language
- Central traversal ribbon: snow/ice, readable lateral movement space, high contrast against roadside props.
- Village edges: cabins, warm windows, lamps, trees, fences, gifts/signage as replaceable dressing; they must not create new gameplay rules.
- Distant layer: snowy mountains and aurora; presentation only.
- Route landmarks should make progress visually obvious without requiring a minimap or metagame.
- Boss arena remains part of the same continuous Level 1 route and must visually close the forward corridor rather than imply a second level.

## Character presentation
- Santa is the forward-moving player anchor, on foot.
- Elves are the authoritative army's visual representation and also move on foot.
- Visual formation follows `ArmyState.Count`; presentation may cap rendered representatives for Android while preserving the authoritative integer count. Any cap is visual-only and cannot alter gate/combat/boss math.
- Formation should remain readable behind/around Santa and avoid expensive per-elf autonomous gameplay logic.

## Camera target
Third-person runner framing, forward-biased, with enough lateral visibility to read gate choices and avoidable obstacles. Camera behavior is presentation-only: smooth follow/look-ahead, bounded lateral composition, no camera mechanic.

## Android-first constraints
Use simple/reversible components: repeated route modules, lightweight colliders, shared materials, pooled visual representatives/effects where useful, no runtime mesh fracture, no requirement for expensive dynamic simulation, and no visual implementation that changes frozen domain semantics.

## Executable integration boundary
Unity authoring must later instantiate the route modules/prefabs, wire trigger adapters, camera, army presenter, environment dressing and boss arena. Exact transforms, materials, lighting, animation, VFX, performance tuning and device validation remain executable work and are not statically proven by this document.
