# M2 Static Integration Notes

Status vocabulary for this branch:
- IMPLEMENTED: source exists in the repository.
- STATICALLY_VERIFIED: source was inspected against frozen product contracts.
- RUNTIME_NOT_VERIFIED: Unity execution has not occurred.
- ANDROID_NOT_VERIFIED: Android build/install/launch has not occurred.

## Frozen loop represented in code
1. `GameSession` creates `RunCoordinator` and authoritative `ArmyState`.
2. Onboarding completes into traversal; `RunnerInputController` supplies continuous lateral intent.
3. `GateResolver` supports only positive-integer `+N` and `xN`, once per stable gate ID.
4. Avoidable obstacle damage removes helpers; `BreakableObstacle` provides idempotent hammer break with authored visual swap presenter.
5. `CombatResolver` owns snowball/army damage and idempotent enemy death.
6. `BossEncounter` is mandatory integration API, one lifecycle only, no adds/phases, and routes damaging attacks through helpers.
7. Zero helpers immediately terminate in Defeat; boss defeat terminates in Victory.
8. `RunCoordinator` and `GameSession` each guard terminal result capture so result is exactly once.
9. `Localizer` supplies ES/EN player-facing strings without baked critical text.

## Deferred executable integration
Unity scene/prefab authoring, component references, target-query backend, visual formation, collision layers/tags, animation/VFX/audio, tuning, clean compile, runtime playthrough, Android build/install/launch and physical Samsung validation remain NOT RUN. These are not claimed as PASS by this static implementation.
