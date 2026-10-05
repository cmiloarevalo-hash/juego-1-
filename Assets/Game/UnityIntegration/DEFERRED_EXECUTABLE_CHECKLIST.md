# Deferred executable integration checklist

Status at authoring: STATIC PREPARATION ONLY. Nothing in this file is runtime evidence.

When a compatible Unity 6.3 LTS environment becomes available:

1. Open the application-completion lineage and allow package resolution. Record exact source SHA and Unity/package state.
2. Verify C# compilation. Correct only compile/API/serialization defects that preserve frozen semantics.
3. Author/wire one playable scene using the existing domain plus `UnityIntegration` adapters:
   - `GameSessionBehaviour` composition root;
   - player object/tag and `RunnerInputController`;
   - helper/army visual representation driven by authoritative helper count;
   - +N and xN `GateTriggerBehaviour` instances with stable IDs;
   - one avoidable `DamagingObstacleBehaviour`;
   - one `HammerBreakableBehaviour` with intact/broken authored visuals;
   - ordinary enemies + `SnowballAttackBehaviour`;
   - mandatory `BossEncounterBehaviour`, one phase, no adds;
   - `ResultPresenterBehaviour` and ES/EN language selection.
4. Perform Unity runtime playthroughs for success and zero-helper defeat. Verify exactly-once result and no post-terminal mutation.
5. Configure/verify Android PlayerSettings and build a Development APK. Record exact source SHA, build configuration, logs and artifact hash.
6. Install/launch via ADB on an available Android target. Label emulator evidence as EMULATOR. Do not substitute it for the final Samsung check.
7. Fix only endpoint-blocking defects, rebuild and rerun invalidated evidence.
8. Hand the uniquely identified APK to the Human for physical Samsung install/test.

Still NOT RUN until actual execution: Unity compile, scene serialization/reference validation, runtime playthrough, APK build, Android install/launch, performance/thermal claims, physical Samsung validation.
