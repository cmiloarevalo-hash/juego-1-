# Android Unity/Game Operational Profile

STATUS: OPTIONAL OPERATIONAL PROFILE — NON-CANONICAL DEVELOPMENT ARTIFACT
PLATFORM: ANDROID / UNITY GAME
GOVERNING WORK ITEM FOR THIS PROFILE: Issue #8
ACTIVITY AUTHORITY: Issue #8 comment 5920041972
PARENT WORKFLOW: workpacks/workflow-operationalization-01/ANDROID_WORKFLOW.md
PARENT WORKFLOW STARTING SOURCE: 8a2b03061da73b3d5b41e7ad72e8f9ccf40b56e3

This profile is a derived operational extension of the Android Workflow.

`ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW`

`ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW`

`ANDROID_UNITY_GAME_PROFILE DOES NOT OVERRIDE AUTHORITY`

`PROFILE ACTIVATION != NEW WORKFLOW AUTHORITY`

It is not a second standalone governance workflow and is not a new canonical baseline.

---

## 0. Governing chain and profile identity

When a Work Item materially targets a Unity-based Android game/project, use this chain:

1. current Human/Supervisor authority;
2. active Work Item;
3. `ANDROID_WORKFLOW.md`;
4. current project/game engineering specifications;
5. this Unity/Game profile for applicable operational deltas;
6. accepted evidence or fresh external research only when the Android Research/Freshness Gate activates.

If this profile conflicts with `ANDROID_WORKFLOW.md` on authority, lifecycle, exact-SHA semantics, merge, publication, scope, recovery, or semantic decision states:

`ANDROID_WORKFLOW.md` governs and the conflict MUST be reported.

If current project/game specifications are missing, ambiguous, contradictory, stale, or insufficient in a material way, return to the specification/document gates in Android Workflow section 9. Do not invent game behavior.

This profile MUST NOT redefine:

- Human authority;
- Supervisor authority;
- Implementer authority;
- Semantic Scope / Path Scope;
- formal semantic decisions;
- exact-SHA review;
- merge authority;
- canonical adoption;
- product publication.

Formal Supervisor decisions remain only:

- `SEMANTIC_ACCEPTED`;
- `REWORK`;
- `HOLD`;
- `ESCALATE`.

---

## 1. Activation and scope

Activate this profile only when the Work Item materially targets Unity/Game execution on Android.

Typical triggers:

- Unity project/source changes;
- Unity package/configuration changes;
- Unity Android build or device execution;
- gameplay/runtime verification;
- profiler/performance measurement;
- physical-device game testing;
- formal playtest evidence;
- game-specific regression or maturity validation.

Do not activate by symmetry or because the repository contains Unity files unrelated to the active Work Item.

A non-Unity Android Work Item uses `ANDROID_WORKFLOW.md` without this profile.

Profile rules apply only where material to the Work Item.

---

## 2. Unity project identity

Record only identity needed to reconstruct the relevant project state.

Suggested fields:

~~~text
UNITY_PROJECT_IDENTITY

UNITY_PROJECT_ROOT:
UNITY_EDITOR_VERSION_SOURCE:
PROJECT_VERSION_REF:
PROJECT_SETTINGS_REF:
PACKAGES_MANIFEST_REF:
PACKAGES_LOCK_REF:
SERIALIZATION_POLICY_REF:
BUILD_PROFILE / BUILD_TARGET:
ANDROID_BUILD_PATH:
UNITY_DIRECT | EXPORTED_GRADLE | PROJECT_DEFINED
~~~

Rules:

- prefer repository/project pointers over copied values when the pointer is durable and unambiguous;
- do not hard-code a universal Unity Editor version in this profile;
- do not infer a current version from a stale screenshot, local cache, or chat memory;
- where exact Editor/tool compatibility is material and not established by project evidence, use Android Workflow Research/Freshness + readiness rules.

---

## 3. Source-controlled vs generated state

### 3.1 Assets and .meta integrity

Treat tracked Unity asset identity as source/project state.

When assets are moved, renamed, imported, or generated:

- preserve the corresponding `.meta` identity where the project requires it;
- inspect the complete tracked diff;
- do not silently accept missing/recreated metadata when it can change references;
- do not treat local import success as proof that repository identity is intact.

### 3.2 ProjectSettings

Treat material tracked `ProjectSettings` as project source/configuration state.

A Unity Editor operation that changes tracked ProjectSettings is a repository change and must remain inside Semantic + Path Scope.

### 3.3 Package dependency state

Where present, use project package manifest/lock files as dependency state.

Do not duplicate the full package list into this profile.

If package resolution differs materially from the tracked/current state:

- capture evidence;
- classify the cause;
- STOP if accepting the new resolution would require an unauthorized repository/configuration change.

### 3.4 Library / Temp / generated cache

`Library`, `Temp`, and equivalent generated/cache state are non-authoritative by default unless the project has an explicit current rule stating otherwise.

Do not commit generated cache merely to make recovery faster.

Recovery must be possible from repository state + required project/tool facts, not from hidden local cache.

### 3.5 Import side effects

When opening/importing the project can mutate tracked state:

1. bind execution to exact TARGET_SHA;
2. perform the authorized import/open operation;
3. inspect repository diff;
4. separate generated/cache effects from tracked source/configuration changes;
5. STOP if tracked changes are outside authority or cannot be explained.

Do not force an unrelated serialization-policy migration.

---

## 4. Unity Android environment

Record only material environment facts.

~~~text
UNITY_ANDROID_ENVIRONMENT

UNITY_EDITOR:
ANDROID_BUILD_SUPPORT:
PRESENT | ABSENT | UNKNOWN

SDK_SOURCE / VERSION:
NDK_SOURCE / VERSION:
JDK_SOURCE / VERSION:
GRADLE_PATH / MODEL:
UNITY_GENERATED | EXPORTED_PROJECT | PROJECT_DEFINED

API_LEVELS:
ABI:
GRAPHICS_BACKEND:
SCRIPTING_BACKEND:
BUILD_PROFILE / VARIANT:
OUTPUT:
APK | AAB | EXPORTED_GRADLE | OTHER
~~~

Rules:

- versions are project/current facts, not timeless Workflow constants;
- compatibility is freshness-gated when material;
- do not apply native-Android Gradle/AGP assumptions blindly to Unity-generated builds;
- distinguish Unity-direct build from exported Gradle;
- APK vs AAB depends on Work Item/project maturity/channel;
- signing/publication remains governed by Android Workflow section 25.

---

## 5. Local Execution Agent

The local execution capability is:

`EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT`.

It is a profile of Android Workflow section 30, not a new authority class.

Possible explicitly authorized capabilities:

- open/import Unity project;
- resolve packages;
- inspect Editor/tool versions;
- execute Unity tests/builds;
- generate APK/AAB;
- execute project-required SDK/NDK/JDK/Gradle operations;
- adb install/run/log collection;
- physical-device execution;
- profiler capture;
- CPU/GPU/frame-time/memory/GC/render/loading/thermal measurement;
- screenshots/video;
- interactive test protocol;
- project-defined playtest protocol.

Default:

`REPOSITORY_WRITE = NO`

unless a separate persisted activity explicitly authorizes repository writes.

If source/config correction is required:

`REPOSITORY_CHANGE_REQUIRED: YES`
→ return to Supervisor/Implementer
→ do not mutate source by implication.

The Local Execution Agent MUST NOT acquire:

- semantic approval;
- scope authority;
- merge authority;
- canonical-adoption authority;
- publication authority.

`LOCAL CAPABILITY != WORKFLOW AUTHORITY`.

---

## 6. Implementation Task extension

Do not duplicate the full Work Item.

Optional thin fields:

~~~text
IMPLEMENTATION_TASK_EXTENSION

WORK_ITEM:
AUTHORITY_COMMENT:
ACTIVITY_ID:
BASE_SHA:
BRANCH / PR:
PROFILE: ANDROID_UNITY_GAME
BUILD_MATURITY:
PERSISTENT_ACTIVITY:
MATERIAL_SPEC_REFS:
LOCAL_AGENT_REQUIRED:
ADDITIONAL_EXPECTED_EVIDENCE:
RETURN_FORMAT:
~~~

Prefer pointers to current GitHub authority/specification over copied normative text.

If copied text diverges from the Work Item, the Work Item/current authority governs and the divergence is a document-consistency issue.

---

## 7. Local Test Packet

Create a packet only when local/external runtime execution is required.

Only material fields are mandatory.

~~~text
LOCAL_TEST_PACKET

WORK_ITEM:
ACTIVITY_ID:
TARGET_SHA:
TEST_ID:
TEST_PROTOCOL:
PASS_CRITERIA:
ENVIRONMENT_REQUIREMENTS:
DEVICE_REQUIREMENTS:
SOURCE_MATERIALIZATION:
EXPECTED_ARTIFACTS:
EXPECTED_LOGS:
EXPECTED_HASHES:
RETURN_FORMAT: LOCAL_RESULT
~~~

Guidance:

- TARGET_SHA and TEST_ID are normally required;
- SOURCE_MATERIALIZATION is required only when the materialization path can affect reproducibility;
- device fields are required only when a device is used;
- hashes are required when cross-actor/artifact identity or integrity matters;
- do not force runtime metadata onto documentation-only or host-only work.

---

## 8. Local Result

~~~text
LOCAL_RESULT

TARGET_SHA:
MATERIALIZED_SHA:
TEST_ID:
STATUS:
RESULT:
ENVIRONMENT:
TOOL_VERSIONS:
BUILD_ID:
BUILD_HASH:
DEVICE:
ARTIFACTS:
LOGS:
MEASUREMENTS:
FIRST_CAUSAL_FAILURE:
REPOSITORY_CHANGE_REQUIRED:
LIMITATIONS:
TIMESTAMP:
~~~

Allowed evidence/execution states:

- `PASS`;
- `FAIL`;
- `BLOCKED`;
- `NOT_RUN`;
- `STALE_RESULT`;
- `DUPLICATE_RESULT`.

These are not Supervisor semantic decisions.

`LOCAL_VALIDATED != SEMANTIC_ACCEPTED`.

`PASS != SEMANTIC_ACCEPTED`.

---

## 9. Failure classification and routing

Failure classification is diagnostic only.

| Class | Meaning | Likely next path | Minimum evidence | Stop implementation? |
|---|---|---|---|---|
| REPOSITORY_DEFECT | ref/layout/repository state prevents valid execution | Implementer if in scope; otherwise Supervisor | exact ref/path/diff/error | YES if execution identity is invalid |
| CODE_DEFECT | implemented behavior fails | Implementer focused correction | failing test/log/reproduction | normally YES for affected objective |
| CONFIGURATION_DEFECT | project/build/runtime configuration fails | Implementer if authorized | config ref + error/effect | YES when required execution cannot proceed |
| DOCUMENTATION_DEFECT | required instruction/spec is wrong/incomplete | Supervisor scopes resolution | exact doc/ref + defect | YES when material |
| TOOLING_DEFECT | Unity/SDK/NDK/JDK/Gradle/tool failure | bounded diagnosis/research path | tool versions + causal error | YES when blocking |
| ENVIRONMENT_DEFECT | required host/runtime prerequisite unavailable | environment/Local Agent path | environment + missing/broken prerequisite | YES when blocking |
| DEVICE_REQUIRED | current environment cannot prove required behavior | authorized device activity | rationale + required fidelity | YES for that unproven criterion |
| MEASUREMENT_REQUIRED | claim needs measurement | authorized measurement protocol | claim + missing measurement | YES for that criterion |
| PROVENANCE_REQUIRED | required source/origin/license evidence absent | provenance/decision path | affected asset/source | YES when requirement is material |
| PRODUCT_DECISION_REQUIRED | product/game choice unresolved | Supervisor → Human | exact unresolved question | YES |
| TEST_PROTOCOL_ISSUE | protocol cannot validly evaluate criterion | Supervisor/protocol correction | protocol + ambiguity/failure | YES for affected evidence |

`FAILURE_CLASS != REWORK/HOLD/ESCALATE`.

A technical class may inform the Supervisor, but it does not issue a semantic decision.

---

## 10. Proportional traceability

Use the smallest trace that preserves evidence identity.

Simple/non-runtime:

`WORK_ITEM → IMPLEMENTATION_SHA → VERIFICATION → SUPERVISOR REVIEW`

Runtime build:

`WORK_ITEM → IMPLEMENTATION_SHA → BUILD_ID/HASH → TEST_ID → EVIDENCE → SUPERVISOR REVIEW`

Device/performance:

`WORK_ITEM → MATERIAL_SPEC_REF → IMPLEMENTATION_SHA → BUILD_ID/HASH → DEVICE/ENV → TEST_ID/PROTOCOL → EVIDENCE → SUPERVISOR REVIEW`

Do not force Build ID, device identity, hashes, or material specification refs where they are irrelevant.

---

## 11. Stale / duplicate evidence

Before consuming a local/runtime result, compare material identity:

- REPORTED/TARGET SHA;
- MATERIALIZED SHA;
- current required HEAD when applicable;
- last reviewed HEAD when relevant;
- Build ID/hash when material;
- Test ID/protocol version when material;
- device/environment identity when material.

Use:

`STALE_RESULT` when evidence no longer binds to the required source/configuration identity.

Use:

`DUPLICATE_RESULT` when equivalent durable evidence already exists for the same material execution tuple and rerun adds no required evidence.

Neither state creates semantic authority.

A stale result must not be silently reused as proof for a new SHA.

---

## 12. Performance evidence

Performance evidence is risk/maturity-triggered only.

Possible dimensions:

- CPU;
- GPU;
- frame time / frame pacing;
- memory;
- GC;
- rendering;
- animation;
- physics;
- loading;
- thermal/power when relevant.

Trigger when, for example:

- Acceptance Criteria contain a performance property;
- the change affects a performance-sensitive system;
- a measured regression is suspected;
- a Vertical Slice / QA / release milestone requires it;
- Editor/emulator evidence is insufficient;
- sustained device/thermal behavior matters.

Minimum reproducibility metadata when applicable:

~~~text
PERFORMANCE_EVIDENCE

TARGET_SHA:
BUILD_ID / HASH:
UNITY_EDITOR:
BUILD_CONFIG:
DEVICE:
ANDROID / API:
SOC / GPU:
GRAPHICS_API:
QUALITY / PERFORMANCE_PROFILE:
SCENE / TEST_ID:
PROTOCOL_VERSION:
WARMUP:
DURATION:
CAPTURE_TOOL:
THERMAL / BATTERY_START_STATE:
METRICS:
CAPTURE_REF:
LIMITATIONS:
~~~

Only material fields are mandatory.

No universal FPS, frame-time, memory, device, scene, or duration target belongs in this profile.

Concrete thresholds come from current project/game specifications or the Work Item.

`PERFORMANCE_PASS != SEMANTIC_ACCEPTED`.

---

## 13. Physical-device trigger

Use physical-device evidence only when real-device fidelity is material, including:

- hardware behavior;
- vendor-specific behavior;
- performance/frame pacing;
- thermal/power behavior;
- graphics/GPU behavior;
- permissions/OS integration not sufficiently proven elsewhere;
- representative release-critical gameplay.

Record only material metadata:

~~~text
GAME_DEVICE_EVIDENCE

BUILD:
SHA:
DEVICE_MODEL:
SOC:
GPU:
RAM:
OS:
ANDROID_API:
GRAPHICS_BACKEND:
TEST:
DURATION:
RESULT:
ARTIFACTS:
~~~

A physical device is not mandatory for every gameplay or prototype change.

---

## 14. Playtest evidence

Formal playtest evidence is triggered only when experiential evidence is material.

Examples:

- gameplay/usability behavior is an Acceptance Criterion;
- a major mechanic decision depends on player observation;
- onboarding/comprehension is material;
- a selected Vertical Slice milestone requires it;
- builds must be compared reproducibly.

~~~text
PLAYTEST_RECORD

PLAYTEST_ID:
SOURCE_SHA:
BUILD_ID / HASH:
DEVICE:
PROTOCOL_ID:
OBJECTIVE:
PARTICIPANT_PROFILE:
OBSERVATIONS:
RESULTS:
ARTIFACTS:
LIMITATIONS:
~~~

Participant profile should contain only relevant/non-identifying information required by the protocol.

`PLAYTEST_RESULT != SEMANTIC_ACCEPTED`.

Exploratory informal testing remains allowed for early prototype iteration when formal evidence is unnecessary.

---

## 15. Vertical Slice

Vertical Slice is optional and maturity-triggered.

When explicitly adopted by the Work Item/project:

`VERTICAL_SLICE_IMPLEMENTATION`
→ `LOCAL_VALIDATION`
→ `PLAYTEST` when justified
→ `PERFORMANCE_VALIDATION` when justified
→ `SUPERVISOR REVIEW`

Do not require a Vertical Slice for every prototype or game project.

---

## 16. Regression / change impact

Select regression by affected systems and risk.

`CHANGE`
→ `AFFECTED_SYSTEMS`
→ `AFFECTED_SPECS`
→ `REQUIRED_REGRESSION`
→ `LOCAL/DEVICE TESTS` if triggered
→ `PERFORMANCE TESTS` if triggered
→ `PLAYTESTS` if triggered

Potential affected systems:

- gameplay;
- input;
- physics;
- animation;
- rendering;
- UI;
- save/persistence;
- networking;
- audio;
- asset/import pipeline;
- build/configuration;
- Android integration.

The Implementer identifies plausible impact and selects the smallest evidence set covering it.

`EVERY CHANGE → RUN EVERYTHING` is forbidden as a default.

---

## 17. Build maturity

Build maturity labels are optional evidence-selection labels, not semantic decision states.

### PROTOTYPE_BUILD

Normally sufficient:

- exact source/project identity;
- sufficient specification for the experiment;
- minimum build/run/smoke evidence relevant to the objective.

Not default:

- full device matrix;
- AAB;
- release signing;
- formal performance suite;
- formal playtest;
- release regression.

### GAMEPLAY_BUILD

Add representative gameplay/runtime evidence where material.

### VERTICAL_SLICE_BUILD

Add integrated validation and only the playtest/performance evidence required by the selected milestone.

### INTEGRATION_BUILD

Add selective cross-system regression and affected runtime/device evidence.

### QA_BUILD

Use stable build identity, defined regression/device set, and structured defect evidence as project QA requires.

### RELEASE_CANDIDATE

Use release-variant/channel evidence, signing boundaries, and project-required regression/device/performance checks.

Product publication remains Human action.

---

## 18. Large artifacts

Large runtime artifacts may include:

- APK/AAB;
- profiler captures;
- traces;
- screenshots/video;
- log bundles;
- generated reports.

Do not commit them to source control by default.

When material, retain a durable reference with:

- Work Item;
- source SHA;
- Build ID/hash;
- Test ID;
- device/environment;
- timestamp;
- artifact location/type;
- integrity hash where useful;
- retention/availability limitation.

Use an existing project/GitHub evidence facility when sufficient.

No paid artifact platform is required by this profile.

---

## 19. Game specification boundary

This profile defines **how** authorized Unity/Game Android work is executed.

It does NOT define the concrete game's:

- mechanics;
- balancing;
- progression;
- gameplay behavior;
- content;
- target FPS/frame-time/memory budgets;
- target device tiers;
- scenes;
- test scenarios;
- UX/product decisions.

Those belong to current project engineering/game specifications and Work Items.

If material specification is absent, ambiguous, contradictory, stale, or insufficient:

return to Android Workflow section 9.3.

If multiple applicable normative documents conflict or have unresolved status/precedence:

return to Android Workflow section 9.4.

Do not invent game behavior.

---

## 20. Prototype anti-bottleneck rules

For a normal prototype, these are NOT mandatory by default:

- full device matrix;
- profiler on every change;
- performance suite on every change;
- formal playtest on every gameplay edit;
- Vertical Slice;
- AAB;
- release signing;
- release validation;
- full regression;
- full repository documentation audit;
- exhaustive trace chain;
- checkpoint per edit;
- research "just in case".

Controls activate only from one or more of:

- Work Item Acceptance Criteria;
- technical risk;
- evidence need;
- project specification;
- build/project maturity;
- unresolved material unknown.

A prototype must not inherit release-grade controls merely because the project is a game.

---

## 21. Profile-aware handoff and recovery

When this profile is active, handoff/recovery MAY reference only material additional state:

- PROFILE: ANDROID_UNITY_GAME;
- current material specification refs;
- readiness/document-consistency state;
- Local Execution Agent activity/result;
- Build ID/hash;
- pending local/device/performance/playtest evidence;
- maturity label when used.

The Android Workflow section 18 handoff and sections 26–27 recovery remain governing.

---

## 22. Cross-document consistency and non-regression

Required non-regression:

1. `ANDROID_WORKFLOW.md` remains understandable and operational for non-game Android work without this profile.
2. Unity/Game Work Items activate this profile explicitly.
3. This profile does not redefine Human, Supervisor, Implementer, semantic decisions, merge authority, publication authority, exact-SHA semantics, or Work Item authority.
4. Duplicated wording defers to `ANDROID_WORKFLOW.md` on conflict.
5. No cyclic dependency requires this profile to define Android authority while Android Workflow requires this profile to define the same authority.
6. The accepted 71/71 Android baseline adaptation remains intact.
7. Unity-specific mechanics do not become universal native-Android requirements.
8. Project specifications retain concrete game/product requirements.

---

## 23. Profile Definition of Done

For a profile-activated Work Item, apply only relevant items:

- parent Android Workflow authority/bootstrap passed;
- material project/game specification is sufficient;
- document consistency passed where triggered;
- Persistent Work Readiness passed where triggered;
- Unity project identity is sufficient;
- source/generated-state boundary respected;
- Unity Android environment facts are sufficient;
- Local Agent activity is durable if used;
- required local/device/performance/playtest evidence is complete;
- stale/duplicate evidence is not misused;
- regression selection is proportional;
- prototype anti-bottleneck rules are preserved;
- exact-SHA handoff is ready;
- no profile evidence state is treated as semantic approval.

---

# Result

For Unity/Game Android work:

`ANDROID_WORKFLOW + ANDROID_UNITY_GAME_PROFILE + CURRENT PROJECT SPECS`

For non-Unity Android work:

`ANDROID_WORKFLOW`

The profile adds Unity/Game operational detail without creating a second governance system.

Core invariants:

`TECHNICAL CAPABILITY != WORKFLOW AUTHORITY`

`LOCAL CAPABILITY != WORKFLOW AUTHORITY`

`PATH PERMISSION != SEMANTIC PERMISSION`

`CI/TEST PASS != SEMANTIC_ACCEPTED`

`LOCAL_VALIDATED != SEMANTIC_ACCEPTED`

`PLAYTEST_RESULT != SEMANTIC_ACCEPTED`

`PERFORMANCE_PASS != SEMANTIC_ACCEPTED`

`SEMANTIC_ACCEPTED != MERGE_ELIGIBLE`

`PUBLISH = HUMAN ACTION`

`GITHUB STATE > SESSION MEMORY`

`PERSISTENCE != BLIND START`

`DOCUMENT CONSISTENCY PRECEDES SUBSTANTIAL IMPLEMENTATION`

`ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW`

`ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW`
