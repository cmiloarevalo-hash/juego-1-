# Official Documentation Sources

Access date for Issue #20 sources: 2026-09-30.

## GH-001 — Triggering a workflow
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/how-tos/write-workflows/choose-when-workflows-run/trigger-a-workflow  
RELEVANT CLAIMS: `GITHUB_TOKEN`-generated events normally do not recursively trigger workflows; `workflow_dispatch` and `repository_dispatch` are documented exceptions.  
NOTES: Primary source used for dispatch-loop design.

## GH-002 — Events that trigger workflows
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/reference/workflows-and-actions/events-that-trigger-workflows  
RELEVANT CLAIMS: `repository_dispatch` and `schedule` require workflow presence on the default branch; schedules run on default branch, may be delayed/dropped under load, minimum interval five minutes, and scheduled workflows in public repositories can be disabled after 60 days inactivity.  
NOTES: Primary source used for activation/watchdog constraints.

## GH-003 — Control workflow/job concurrency
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/how-tos/write-workflows/choose-when-workflows-run/control-workflow-concurrency  
RELEVANT CLAIMS: concurrency groups serialize matching workflow/jobs; pending/running behavior is configurable.  
NOTES: Primary source for dispatcher serialization.

## GH-004 — REST API endpoints for labels
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/issues/labels  
RELEVANT CLAIMS: issue labels can be read and mutated; mutation requires Issues or Pull Requests write permission depending on endpoint/token.  
NOTES: Primary source for namespaced state labels.

## GH-005 — Use GITHUB_TOKEN for authentication
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official documentation  
URL: https://docs.github.com/en/actions/tutorials/authenticate-with-github_token  
RELEVANT CLAIMS: workflows can authenticate API requests using `GITHUB_TOKEN`; permissions should be explicitly scoped.  
NOTES: Primary source for workflow authentication.

## GH-006 — REST API workflow dispatch
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/actions/workflows  
RELEVANT CLAIMS: REST can create `workflow_dispatch` events for workflows configured for that trigger; fine-grained tokens require Actions write permission.  
NOTES: Primary source for external/manual re-dispatch capability.

## GH-007 — Create repository dispatch event
AUTHOR/OWNER: GitHub  
SOURCE TYPE: official REST documentation  
URL: https://docs.github.com/en/rest/repos/repos#create-a-repository-dispatch-event  
RELEVANT CLAIMS: external systems can emit `repository_dispatch`; fine-grained token requires Contents write; endpoint accepts event type and client payload.  
NOTES: This is a generic GitHub trigger, not evidence of a concrete ChatGPT worker launcher.

## Integration evidence gap
**UNKNOWN:** no repository artifact or verified official project-specific integration currently identifies an API/GitHub App/credential capable of launching the concrete research agent. No such integration is inferred from GitHub's generic dispatch APIs.

## TL-001 — Apple App Store: Top Lords
AUTHOR/OWNER: Apple storefront / publisher metadata from GAME SPARK PTE. LTD.  
SOURCE TYPE: primary storefront  
URL: https://apps.apple.com/us/app/top-lords/id6767834940  
DATE ACCESSED: 2026-09-30  
VERSION: current storefront listing at access time  
LICENSE: N/A — evidence reference only; no code reuse  
RELEVANT CLAIMS: strategy-runner positioning; swipe/dodge/charge; army growth; kingdom/resources/fiefs/taxes/heroes/griffin; current platform/store metadata.  
NOTES: Publisher claims are SOURCE CLAIM unless asserting storefront metadata itself.

## TL-002 — Google Play: Top Lords
AUTHOR/OWNER: Google Play storefront / GAME SPARK  
SOURCE TYPE: primary storefront  
URL: https://play.google.com/store/apps/details?id=com.gamespark.topking.gp  
DATE ACCESSED: 2026-09-30  
VERSION: package com.gamespark.topking.gp, current listing at access time  
LICENSE: N/A — evidence reference only; no code reuse  
RELEVANT CLAIMS: swipe/path choice, army growth, resources/territory, fiefs/taxes, heroes, griffin, strategy/4X/single-player descriptors.

## UNITY-001 — NavMesh Agent manual
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official documentation  
URL: https://docs.unity3d.com/Manual/class-NavMeshAgent.html  
DATE ACCESSED: 2026-09-30  
VERSION: current documentation route; exact target Unity version not yet selected  
LICENSE: documentation reference only  
RELEVANT CLAIMS: NavMeshAgent provides pathfinding/spatial reasoning and local avoidance parameters for moving characters.  
NOTES: API/package-version choice remains subject to a later Research Gate.

## UNITY-002 — Input System manual/package documentation
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official documentation  
URL: https://docs.unity3d.com/Manual/com.unity.inputsystem.html  
DATE ACCESSED: 2026-09-30  
VERSION: current documentation route; target package version UNKNOWN  
LICENSE: documentation reference only  
RELEVANT CLAIMS: Unity provides a package-based Input System intended as an extensible/customizable input alternative and supports touch/input devices.  
NOTES: This supports abstraction feasibility, not a package-version decision.

## UNITY-003 — Mobile optimization / profiling guidance
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official documentation  
URL: https://docs.unity3d.com/Manual/MobileOptimizationPracticalGuide.html  
DATE ACCESSED: 2026-09-30  
VERSION: documentation route contains historically versioned guidance  
LICENSE: documentation reference only  
RELEVANT CLAIMS: profile on target devices; CPU and GPU bottlenecks differ; optimization choices are workload/device dependent.  
NOTES: Used to prohibit unsupported performance winners and to require profiling experiments.

## UNITY-004 — Mobile scripting optimization / object pooling guidance
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official documentation  
URL: https://docs.unity3d.com/Manual/MobileOptimizationPracticalScriptingOptimizations.html  
DATE ACCESSED: 2026-09-30  
VERSION: documentation route contains historically versioned guidance  
LICENSE: documentation reference only  
RELEVANT CLAIMS: frequent Instantiate/Destroy can increase allocation/GC work; pooling can shift creation cost but oversized pools also consume heap and can worsen collection costs.  
NOTES: Pooling is therefore a measured tradeoff, not a universal rule.

## UNITY-005 — Collider.OnTriggerEnter
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official Scripting API  
URL: https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html  
DATE ACCESSED: 2026-09-30  
VERSION: current route; target Unity version not fixed  
RELEVANT CLAIMS: trigger-overlap callback exists; physics configuration/timing constraints documented.  
NOTES: candidate gate detection mechanism only.

## UNITY-006 — UnityEngine.Pool.ObjectPool<T>
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official Scripting API  
URL: https://docs.unity3d.com/ScriptReference/Pool.ObjectPool_1.html  
DATE ACCESSED: 2026-09-30  
VERSION: current route; target Unity version not fixed  
RELEVANT CLAIMS: stack-based object pool exposes Get/Release and active/inactive counts; pool may create when empty and destroy on release when full.  
NOTES: exact API availability/version requires later Research Gate.

## UNITY-007 — Profiler overview
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official manual  
URL: https://docs.unity3d.com/Manual/Profiler.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: Unity Profiler exposes CPU/GPU/rendering/physics/memory modules; additional profiling tools can deepen analysis.  

## UNITY-008 — SRP Batcher / GPU instancing documentation
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official manual  
URLS: https://docs.unity3d.com/Manual/SRPBatcher.html ; https://docs.unity3d.com/Manual/GPUInstancing.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: SRP Batcher reduces CPU rendering state setup for compatible SRP shaders; GPU instancing targets repeated mesh/material draws; documented compatibility/priority varies by pipeline/version and must be profiled.  

## UNITY-009 — Animator culling/performance
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official manual/API  
URL: https://docs.unity3d.com/ScriptReference/AnimatorCullingMode.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: culling modes can suppress offscreen transform/animation evaluation to differing degrees.  

## UNITY-010 — Physics optimization: collision layers and fixed timestep
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official manual  
URLS: https://docs.unity3d.com/Manual/physics-optimization-cpu-collision-layers.html ; https://docs.unity3d.com/Manual/TimeFrameManagement.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: layer filtering reduces unnecessary collision work; lower fixed timestep increases physics update frequency/CPU cost while affecting precision.  

## UNITY-011 — ScriptableObject manual
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official manual  
URL: https://docs.unity3d.com/Manual/class-ScriptableObject.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: ScriptableObjects centralize asset data independently of GameObject instances; deployed builds use authored asset data but ScriptableObject is not itself a deployed save mechanism.  

## UNITY-012 — Cinemachine package manual
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official package manual  
URL: https://docs.unity3d.com/Manual/com.unity.cinemachine.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: Cinemachine provides follow/composition camera tooling; package/API versions differ across Unity generations.  

## UNITY-013 — Addressables package documentation
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official package manual  
URL: https://docs.unity3d.com/Manual/com.unity.addressables.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: Addressables provide address-based asynchronous asset/dependency loading.  
NOTES: availability is not evidence that target product requires it.

## UNITY-014 — PlayerPrefs
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official Scripting API  
URL: https://docs.unity3d.com/ScriptReference/PlayerPrefs.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: persists string/int/float preferences across sessions; local storage is not encrypted and should not hold sensitive data.  

## UNITY-015 — Application.persistentDataPath
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official Scripting API  
URL: https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: path intended for data retained between runs; mobile paths persist across app updates with stable bundle identifier, subject to user actions.  

## UNITY-016 — JsonUtility
AUTHOR/OWNER: Unity Technologies  
SOURCE TYPE: official Scripting API  
URL: https://docs.unity3d.com/ScriptReference/JsonUtility.html  
DATE ACCESSED: 2026-09-30  
RELEVANT CLAIMS: converts supported objects/fields to/from JSON using Unity serializer rules.  


## Stage 2A mutable technical sources — accessed 2026-09-30
- UNITY-S2-001 — Unity 6000.3.24f1 official release notes — https://unity.com/releases/editor/whats-new/6000.3.24f1 — VERIFIED FACT: released 2026-09-10; Android Build Support installer offered.
- UNITY-S2-002 — Unity 6 release support — https://unity.com/releases/unity-6/support — VERIFIED FACT: Unity 6.3 is LTS, supported through Dec 2027.
- UNITY-S2-003 — Input System 1.17.0 docs — https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html — VERIFIED FACT: package metadata identifies version 1.17.0.
- UNITY-S2-004 — URP compatibility docs/index — https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@17.2/manual/index.html — VERIFIED FACT: Unity docs expose URP 17.2 family for 6000.3; exact resolved patch awaits UPM lock evidence.
- UNITY-S2-005 — Android requirements — https://docs.unity3d.com/current/Manual/android-requirements-and-compatibility.html — VERIFIED FACT: Android 6.0/API 23+; Vulkan and OpenGL ES 3.x supported.
- UNITY-S2-006 — Android Player Settings — https://docs.unity3d.com/current/Manual/class-PlayerSettingsAndroid.html — VERIFIED FACT: manual graphics API ordering is available when Auto Graphics API is disabled.
