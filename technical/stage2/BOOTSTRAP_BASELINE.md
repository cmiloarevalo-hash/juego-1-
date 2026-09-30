> **DOCUMENTATION CLASSIFICATION: CURRENT_SUPPORTING / EXECUTION SUSPENDED BY ISSUE #83.**
> This is Stage 2 evidence/status, not product authority. Do not continue or retest it until Supervisor issues `DOCUMENTATION_GATE_ACCEPTED` and applicable technical authorization is active.

# Stage 2A Bootstrap Baseline — Issue #73
Status: PARTIAL / BLOCKED_BY_UNITY_ENVIRONMENT
Date: 2026-09-30
Frozen spec: 09061b4ba372de41fb142ab4c43f1b4302f58083

## Verified external facts
- Unity 6.3 is the accepted LTS family. Unity official release page shows 6000.3.25f1 released 2026-09-24; this is the current 6.3 LTS patch verified from Unity official release evidence on 2026-09-30.
- Input System official package docs identify 1.17.0.
- Unity compatibility index maps Unity 6000.3 to URP 17.2 family. The exact URP patch is intentionally UNPINNED until Unity Package Manager/installed-editor evidence resolves it; no patch number is inferred.
- Current Unity Android docs support Android 6.0/API 23+ and Vulkan/OpenGL ES 3.x. Exact project min/target API, ABI and graphics order remain execution pins.

## Files intentionally bootstrapped
ProjectVersion.txt pins editor request to 6000.3.25f1.
manifest.json pins only verified Input System 1.17.0. URP 17.2 family is required, but its exact patch is intentionally not written until UPM/official package resolution verifies it.
packages-lock.json is deliberately NOT fabricated.

## Required execution to complete #73
On a machine with Unity Hub/Editor:
1. Install Unity 6000.3.25f1 with Android Build Support + SDK/NDK/OpenJDK modules.
2. Open project and let UPM resolve manifest. Persist generated packages-lock.json and verify resolved URP/Input versions.
3. Record editor changeset/module versions from installed editor.
4. Configure Android landscape; IL2CPP; ARM64 baseline unless pinned editor/device evidence requires adjustment.
5. Disable Auto Graphics API and configure Vulkan first, OpenGLES3 fallback; verify editor accepts both.
6. Pin min/target API from installed supported SDK/toolchain and intended smoke device; do not invent unavailable API.
7. Create BootstrapScene and SyntheticTestScene using primitives only.
8. Add instrumentation/profiler-marker harness only.
9. Produce editor/import logs and configuration evidence.

## Environment finding
The execution environment used for this checkpoint has no Unity Editor or Unity Hub executable. Therefore package resolution, Android module presence, PlayerSettings serialization and compilation are NOT VERIFIED.

## Sources
Unity official release 6000.3.25f1; Unity 6 support/LTS; Unity Input System 1.17 docs; Unity URP compatibility docs; Unity Android requirements/Player Settings. URLs are recorded in sources/official-documentation.md by this work item.

## Supersession note
The earlier 6000.3.24f1 checkpoint was superseded after a fresh official-source refetch found 6000.3.25f1 released 2026-09-24. Historical commits remain unchanged; current branch pin is 6000.3.25f1.

## Local execution environment probe
Observed 2026-09-30: Unity Editor absent; Unity Hub absent; adb absent; sdkmanager absent. System Java exists at /usr/bin/java but is not evidence of Unity's bundled Android OpenJDK/toolchain. Therefore Android toolchain remains unverified.
