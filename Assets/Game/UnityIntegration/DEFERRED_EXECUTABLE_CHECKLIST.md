# Deferred executable integration checklist

Status at authoring: STATIC PREPARATION ONLY. Nothing in this file is runtime evidence.

When a compatible Unity 6.3 LTS environment becomes available:

1. Open the `dev/application-completion` lineage and allow package resolution. Record exact source SHA and Unity/package state.
2. Verify C# compilation. Correct only compile/API/serialization defects that preserve frozen semantics.
3. Author/wire the single continuous Level 1 scene using the existing domain plus `UnityIntegration` adapters and `LEVEL1_SCENE_PREFAB_CONTRACT.md`:
   - `GameSessionBehaviour` composition root;
   - Santa player object/tag and existing `RunnerInputController`;
   - `ContinuousRouteBehaviour` with exactly eight ordered sections: onboarding/departure -> growth -> positive gates -> obstacle/hammer -> snowball/combat -> boss approach -> boss arena -> result;
   - `RunnerCameraBehaviour` targeting Santa;
   - `ArmyFormationPresenter` driven by authoritative helper count; visual cap is presentation-only;
   - `ChristmasEnvironmentPresenter` with snowy/icy path, Christmas village, snowy mountains and aurora layers;
   - onboarding exit and boss-arena entry progression triggers;
   - only positive +N and xN `GateTriggerBehaviour` instances with stable IDs; no -N variant;
   - one or more avoidable obstacle compositions and hammer breakable with authored intact/broken visuals;
   - ordinary enemies + snowball attack adapters;
   - mandatory boss encounter, one phase, no adds;
   - `ResultPresenterBehaviour` and ES/EN language selection.
4. Verify serialized scene/prefab references and route ordering. Treat missing references as executable integration defects, not product decisions unless they expose a real semantic conflict.
5. Perform Unity runtime playthroughs for success and zero-helper defeat. Verify exactly-once result and no post-terminal mutation.
6. Configure/verify Android PlayerSettings and build a Development APK. Record exact source SHA, build configuration, logs and artifact hash.
7. Install/launch via ADB on an available Android target. Label emulator evidence as EMULATOR. Do not substitute it for the final Samsung check.
8. Fix only endpoint-blocking defects, rebuild and rerun invalidated evidence.
9. Hand the uniquely identified APK to the Human for physical Samsung install/test.

Still NOT RUN until actual execution: Unity import/package resolution, compile, scene/prefab serialization/reference validation, camera feel, animation/VFX/lighting, runtime playthrough, APK build, Android install/launch, performance/thermal claims, and physical Samsung validation.
