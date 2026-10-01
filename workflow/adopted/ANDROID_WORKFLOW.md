# Android Operational Workflow

STATUS: PROPOSAL — NOT CANONICAL

PLATFORM: ANDROID

GOVERNING WORK ITEM FOR THIS DOCUMENT:
Issue #8

ARCHITECTURE SEMANTICALLY ACCEPTED AT:
621d4e58eccbc697d42074e5f7eaa53a162a0582

DOCUMENT PURPOSE:
Standalone operational workflow for Android engineering work executed by Human + Supervisor + Implementer + GitHub/CI, with optional bounded external actors.

PRIMARY DESIGN RULE:

ANDROID_WORKFLOW.md = BASELINE FUNCIONAL + ADAPTACIÓN ANDROID JUSTIFICADA

This document is an operational workflow. It is not a research report, executive summary, Candidate 4 presentation, or replacement for the frozen baseline by implication.

No merge, canonical adoption, or product publication is authorized merely because this document exists or is semantically accepted as a proposal artifact.

---

## 0. Document status, authority, provenance, and source precedence

### 0.1 What this document is

This document defines how an authorized Android Work Item is created, bootstrapped, implemented, verified, handed off, independently reviewed, reworked, integrated, recovered across sessions, and prepared for Human publication when applicable.

It is designed so that a fresh authorized session can operate the normal lifecycle using:

- the repository;
- the active GitHub Issue / Work Item;
- this Android workflow;
- project documentation explicitly referenced by the Work Item.

Normal operation MUST NOT require reconstructing procedure from Issue #2 research outputs.

### 0.2 What this document is not

This document is not:

- a claim that Android must use one specific architecture, CI provider, device lab, IDE, coding agent, or cloud;
- a mandate to migrate an existing Java/View project to Kotlin/Compose;
- a release authorization;
- a merge authorization;
- a replacement for Human decisions on credentials, costs, accounts, or product publication;
- a timeless source for volatile Android SDK, Google Play, provider, pricing, or policy facts.

### 0.3 Source precedence

When sources appear to conflict, apply this precedence:

1. Current Human/Supervisor authority in the active governing Work Item.
2. This platform workflow for the normal Android operational lifecycle, once the active Work Item points to it.
3. Frozen functional baseline for inherited lifecycle semantics and non-regression.
4. Accepted Common Core / authority / external-actor controls from Issue #2.
5. Accepted Android evidence and Android platform deltas from Issue #2.
6. Research summaries, presentation briefs, or historical candidate artifacts only as evidence/provenance.

Rules:

- Current Work Item authority controls task scope.
- Evidence does not create authority.
- Technical capability does not create authority.
- A shorter summary cannot weaken a normative rule in this document.
- A later commit cannot inherit semantic acceptance from another SHA automatically.
- Volatile external facts are refreshed only through the Research/Freshness Gate when materially required.

### 0.4 Provenance used to produce this workflow

Frozen baseline:
- references/WORKFLOW_BASE_ORIGINAL.md
- baseline blob: fa6ce8e396e1ae422ce4feab3f97d7d37bb43f83

Accepted architecture package:
- Workflow Document Contract
- Android Baseline Adaptation Matrix
- ADR-001 — standalone baseline-derived platform workflows
- architecture accepted at 621d4e58eccbc697d42074e5f7eaa53a162a0582

Accepted Issue #2 evidence reused:
- Android Candidate 4 presentation
- Common governance core
- Optional external actor interface
- Platform deltas
- Adversarial contradiction audit
- Final Android workflow proposal

Issue #2 evidence is reused. The comparative research/scoring cycle is not repeated by this workflow.

---

## 1. Purpose, audience, and usage

### 1.1 Objective

The objective is to provide a complete Android engineering workflow that:

- preserves the full operational lifecycle of the functional baseline;
- adds Android-specific environment, build, verification, signing, and device constraints only where justified;
- remains provider-neutral where Android does not impose one provider;
- is recoverable across sessions;
- separates evidence from authority;
- scales verification according to technical risk;
- prevents accidental publication, merge, scope expansion, or authority transfer.

### 1.2 Audience

Primary audience:

- Human;
- Supervisor;
- Implementer / technical writer-engineer / coding agent;
- optional external actor when a concrete missing capability requires one.

Supporting systems:

- GitHub;
- CI;
- test infrastructure;
- Android emulator/device infrastructure;
- signing/build/release tooling.

Supporting systems produce state/evidence. They do not issue semantic decisions.

### 1.3 When to use this workflow

Use this workflow for Android Work Items involving:

- application code;
- Android libraries/modules;
- Gradle/build configuration;
- UI;
- data/domain layers;
- Android framework behavior;
- tests;
- CI;
- emulator/device verification;
- signing-related technical work;
- release artifact preparation;
- Android-specific documentation;
- Android workflow maintenance under explicit authority.

For a non-Android task, use the appropriate workflow or governing repository instructions.

---

## 2. Fundamental principles

The following rules are always active unless a higher Human/Supervisor authority explicitly changes the governing workflow through a separate decision process.

### 2.1 GitHub is durable memory

The repository, Issue, branch/ref, commits, PR, evidence, CI, and Supervisor decisions are durable state.

Prior chat transcript is not an authority source.

### 2.2 Work Item before substantial work

A sufficiently important task must exist as a bounded GitHub Issue / Work Item.

### 2.3 Two independent scopes

Semantic Scope controls what behavior/change is authorized.

Path Scope controls which files/modules may be changed.

PATH PERMISSION != SEMANTIC PERMISSION.

Both must pass.

### 2.4 Exact-SHA review

Supervisor semantic review applies only to the exact reviewed SHA.

A later commit creates a new HEAD and requires a new semantic decision for that HEAD.

### 2.5 Evidence is not approval

CI/TEST PASS != SEMANTIC_ACCEPTED.

Build success, lint success, device success, metrics, actor output, artifact generation, or store upload capability remain evidence only.

### 2.6 Capability is not authority

TECHNICAL CAPABILITY != WORKFLOW AUTHORITY.

A technical actor may possess source access, credentials, signing keys, upload capability, device access, or cloud access and still lack authority to use them for an operation.

### 2.7 Semantic acceptance is not merge eligibility

SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.

Merge requires separate integration checks and appropriate authority.

### 2.8 Product publication is Human action

PUBLISH = HUMAN ACTION.

Build, sign, upload, stage, deploy, or store access does not transfer publication authority to Implementer, CI, or external actor.

### 2.9 Baseline non-regression is a HARD VETO

Any unexplained loss, weakening, substitution, or reinterpretation of a protected baseline function is a HARD VETO.

A HARD VETO cannot be compensated by:

- score;
- CI success;
- test success;
- automation;
- portability;
- cost;
- convenience;
- provider capability;
- external-actor capability.

### 2.10 Android capability boundaries are explicit

HOST BUILD CAPABILITY != EMULATOR/DEVICE CAPABILITY.

ANDROID SIGNING/UPLOAD CAPABILITY != PRODUCT PUBLICATION AUTHORITY.

A host that compiles Android is not assumed to run an emulator.

A passing emulator is not assumed to prove all physical-device behavior.

A physical-device result is not assumed to authorize publication.

---

## 3. Roles, responsibilities, and authority

## 3.1 Human

### MUST

The Human MUST:

- define product intent and priorities;
- decide material changes in product direction;
- decide material architecture/Workflow changes when reserved to Human authority;
- provide or authorize credentials, MFA, account access, signing access, and material provider permissions when needed;
- decide material costs or paid provider commitments unless explicitly delegated;
- perform product publication.

### MAY

The Human MAY:

- set risk tolerance;
- approve a device-lab budget;
- define release timing;
- define supported Android versions/form factors;
- approve exceptional trade-offs;
- explicitly change Work Item intent or architecture through a persisted decision.

### MUST NOT be treated as

The Human MUST NOT be treated as:

- routine implementer;
- substitute for durable evidence;
- implicit approver of an operation merely because credentials exist.

### Reserved decisions

Reserved to Human unless a governing decision says otherwise:

- product intent;
- material product scope change;
- credentials/MFA;
- paid-service commitments;
- production/store publication.

### Required evidence/output

A material Human decision that changes scope, permission, cost, credential use, provider commitment, or publication state must be persisted in GitHub.

---

## 3.2 Supervisor

### MUST

The Supervisor MUST:

- interpret Human intent;
- create or validate a bounded Work Item;
- verify Objective, Acceptance Criteria, Authorized Scope, Relevant Sources, Verification, and Base;
- distinguish Semantic Scope from Path Scope;
- define required evidence;
- inspect exact HEAD;
- independently review implementation, tests, documentation, CI, and relevant Android evidence;
- issue only the formal semantic decisions:
  - SEMANTIC_ACCEPTED
  - REWORK
  - HOLD
  - ESCALATE
- verify merge eligibility separately.

### MAY

The Supervisor MAY:

- authorize bounded local or external technical activities;
- request targeted fresh research;
- define a device evidence matrix when needed;
- narrow or clarify verification;
- merge only where the governing Workflow and repository authority separately allow it and merge eligibility passes.

### MUST NOT

The Supervisor MUST NOT:

- treat CI/test PASS as semantic acceptance;
- infer publication authority from technical capability;
- silently expand Human intent;
- treat an old reviewed SHA as acceptance of a new SHA.

### Required evidence/output

Supervisor decisions must persist:

- Work Item;
- reviewed SHA;
- evidence basis;
- decision;
- blockers or required corrections;
- next authority/action when applicable.

---

## 3.3 Implementer

### MUST

The Implementer MUST:

- bootstrap from GitHub before editing;
- verify repository, Work Item, role, authority, Base, branch/PR target, Semantic Scope, Path Scope, and required verification;
- read the minimum necessary context;
- implement only the authorized objective;
- use project-native Android tooling;
- run required verification;
- inspect the complete diff;
- persist exact commit/PR evidence;
- report unexpected findings;
- stop on authority/scope/base contradiction.

### MAY

The Implementer MAY:

- choose bounded implementation details consistent with existing architecture;
- add or update tests inside authorized scope;
- use an emulator/device if required and available under authority;
- invoke an authorized external actor through the durable activity protocol;
- perform REPOSITORY_PUBLICATION when explicitly allowed by the Work Item.

### MUST NOT

The Implementer MUST NOT:

- expand Objective or Acceptance Criteria;
- expand Semantic Scope or Path Scope;
- modify architecture/Workflow without authority;
- edit frozen baseline/reference material when forbidden;
- self-approve;
- issue SEMANTIC_ACCEPTED;
- issue MERGE_ELIGIBLE;
- merge by inference;
- publish the product;
- use credentials/account access merely because technically available;
- invent current Android/Play/provider facts.

### Required evidence/output

At handoff the Implementer must provide:

- Work Item;
- branch/PR;
- exact HEAD;
- changed paths;
- verification commands/results;
- CI status;
- device evidence when required;
- artifact/run references when applicable;
- unexpected findings;
- unresolved risks;
- state.

---

## 3.4 GitHub

GitHub is the persistent control plane for:

- Work Item authority;
- branch/ref;
- commits;
- PR;
- changed files;
- evidence links;
- CI;
- Supervisor decisions;
- external-actor activity records;
- recovery across sessions.

GitHub does not make semantic decisions by itself.

---

## 3.5 CI

CI:

- runs reproducible mechanical checks;
- associates evidence with a commit;
- may build, test, lint, and collect artifacts;
- may execute authorized device jobs;
- may prepare technical release artifacts if authorized.

CI MUST NOT:

- issue SEMANTIC_ACCEPTED;
- issue MERGE_ELIGIBLE;
- merge unless a separately governed automation explicitly has that authority;
- publish product by inference.

CI/TEST PASS != SEMANTIC_ACCEPTED.

---

## 3.6 Optional external actor

An external actor is optional.

Examples:

- physical-device lab operator;
- managed-device/cloud device runner;
- signing-support operator;
- accessibility specialist;
- specialized Android technical tool;
- bounded external platform mutation operator.

No external actor is included by symmetry or preference alone.

It must supply a concrete missing capability and operate under the protocol in section 30.

---

## 4. Terminology, states, and notation

### 4.1 Formal Supervisor semantic decisions

Only:

- SEMANTIC_ACCEPTED
- REWORK
- HOLD
- ESCALATE

No Android-specific decision state may replace these.

### 4.2 Lifecycle/integration states

Operational states may include:

- READY_FOR_REVIEW
- MERGE_ELIGIBLE
- MERGED
- CLOSED

These are not semantic decisions.

### 4.3 CI/evidence states

Use:

- PASS
- FAIL
- PENDING
- NOT CONFIGURED

### 4.4 Document status

Until explicit canonical adoption:

PROPOSAL — NOT CANONICAL.

### 4.5 Repository publication vs product publication

REPOSITORY_PUBLICATION means:

- commit;
- push;
- opening/updating a PR;
- making proposed repository changes available for review.

The Implementer MAY perform REPOSITORY_PUBLICATION when the Work Item authorizes it.

PUBLISH / PRODUCT_PUBLICATION means:

- externally observable release or store publication;
- production rollout;
- publication to Google Play or another product distribution channel.

PUBLISH = HUMAN ACTION.

The two terms MUST NOT be conflated.

### 4.6 Baseline adaptation vocabulary

For maintenance/traceability:

- PRESERVE
- ADAPT
- EXTEND
- NOT_APPLICABLE_WITH_JUSTIFICATION

These are coverage classifications, not workflow decisions.

### 4.7 Notation

A → B means ordered lifecycle transition.

A != B means explicit non-equivalence.

MUST / MUST NOT are normative.

SHOULD / MAY are recommendations or options.

Exact SHA means immutable commit identity used for review/evidence.

---

## 5. Work Item contract

Every substantial Android task MUST have a Work Item with six explicit fields.

No field may be silently grouped away.

### 5.1 Objective

Defines what must be achieved.

The Objective:

- is outcome-oriented;
- must be testable through Acceptance Criteria;
- does not grant authority outside Authorized Scope;
- cannot be silently changed by the Implementer.

### 5.2 Acceptance Criteria

Defines observable conditions for success.

Android Acceptance Criteria SHOULD identify relevant evidence such as:

- unit/JVM behavior;
- lint/static checks;
- build/assemble result;
- emulator/device behavior;
- artifact identity;
- documentation updates;
- release-boundary checks.

Acceptance Criteria do not authorize unrelated changes.

### 5.3 Authorized Scope

Defines authorized files/modules and permitted operation boundaries.

It should identify:

- allowed repository paths;
- allowed Android modules;
- allowed configuration files;
- whether tests/docs are included;
- whether external systems are in scope;
- whether credentials or technical staging are permitted.

Authorized Scope MUST NOT be interpreted as Semantic Scope expansion.

### 5.4 Relevant Sources

Defines what the Implementer should read.

Typical priority:

1. this Android workflow;
2. repository AGENTS.md / PROGRAM.md or more specific instructions;
3. affected module/project docs;
4. architecture docs relevant to changed code;
5. accepted evidence explicitly cited by the Work Item;
6. fresh external sources only if Research/Freshness Gate activates.

Issue #2 research is provenance/evidence, not a mandatory normal-operation reading set.

### 5.5 Verification

Defines required proof.

Examples:

- relevant local/JVM tests;
- Android lint;
- affected compile/assemble/build;
- emulator/device checks if risk requires them;
- release-variant build if the change affects release packaging;
- exact artifact hashes;
- CI checks;
- documentation checks.

The Work Item should specify the smallest evidence set that proves the change while respecting risk.

### 5.6 Base

Defines the exact starting branch/ref/commit.

The Implementer MUST verify the Base before editing.

Wrong Base is STOP.

Technical capability cannot compensate for Base mismatch.

### 5.7 Work Item template

~~~markdown
## Objective

...

## Acceptance Criteria

- ...

## Authorized Scope

- Semantic Scope:
- Path Scope:
- Allowed external operations:
- Forbidden operations:

## Relevant Sources

- ...

## Verification

- ...

## Base

- branch/ref:
- exact SHA when required:
~~~

---

## 6. Semantic Scope + Path Scope

### 6.1 Semantic Scope

Semantic Scope authorizes intended behavior/change.

Examples:

- fix a specific crash;
- add one bounded feature;
- update one Android workflow section;
- add a test for one behavior.

Semantic Scope does not automatically authorize every implementation path.

### 6.2 Path Scope

Path Scope authorizes files/modules.

Examples:

- app/src/main/...
- feature/login/...
- build.gradle.kts for one module;
- tests under a specified path.

Path Scope does not authorize unrelated behavior change.

### 6.3 Required rule

Both constraints must pass independently.

PATH PERMISSION != SEMANTIC PERMISSION.

If a correct implementation requires a path outside Path Scope or a behavior outside Semantic Scope:

STOP → report → Supervisor decision.

Do not “temporarily” expand scope.

---

## 7. End-to-end lifecycle

Normal Android lifecycle:

Human intent
→ Supervisor analysis
→ GitHub Work Item
→ Implementer bootstrap
→ environment/context reconstruction
→ bounded implementation
→ host verification
→ Android risk classification
→ device/emulator evidence when required
→ evidence bundle
→ REPOSITORY_PUBLICATION
→ Implementer handoff
→ Supervisor exact-SHA review
→ SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE
→ if accepted, integration target checks
→ MERGE_ELIGIBLE only if separately satisfied
→ merge only under separate authority
→ product publication only by Human action
→ CLOSED when governing conditions are complete.

A shorter path is valid only when steps are genuinely not applicable, not because they are inconvenient.

---

## 8. Human intent and Work Item creation

## 8.1 Human intent

Before creating the Work Item, the Supervisor should identify:

- desired product outcome;
- Android surface affected;
- user impact;
- architecture impact;
- security/privacy impact;
- device/framework dependence;
- signing/release impact;
- current-fact uncertainty;
- credential/cost/provider needs.

## 8.2 Work Item creation

The Supervisor persists:

- Objective;
- Acceptance Criteria;
- Authorized Scope;
- Relevant Sources;
- Verification;
- Base.

Prefer:

ONE OBJECTIVE → ONE BRANCH → ONE PR

unless the governing repository explicitly uses another model.

## 8.3 Android-specific planning questions

When material, determine:

- which Gradle module(s) are affected;
- whether app, library, test, plugin, build logic, or tooling is involved;
- whether Android framework behavior is involved;
- whether UI behavior needs device/emulator proof;
- whether lifecycle/configuration/permissions/services are affected;
- whether database/framework semantics require Android runtime evidence;
- whether hardware/vendor/API/form-factor behavior matters;
- whether release artifact/signing behavior changes;
- whether Play/store policy or another current external rule is material;
- whether provider/device cost needs Human authority.

---

## 9. Implementer start and bootstrap

The start prompt SHOULD be short and pointer-based.

Example:

~~~text
ROLE: IMPLEMENTER
REPOSITORY: owner/repo
WORK ITEM: #123
Read ANDROID_WORKFLOW.md and the Work Item.
Verify authority/base/scope before editing.
Implement only the authorized objective.
Persist evidence/handoff.
STOP on mismatch.
~~~

The prompt is not the durable task definition. GitHub is.

### 9.1 Mandatory bootstrap questions

Before edits, answer from GitHub/repository evidence:

1. REPOSITORY MATCH?
2. CURRENT ROLE?
3. GOVERNING WORK ITEM?
4. CURRENT AUTHORITY?
5. EXACT BASE / HEAD?
6. TARGET BRANCH / PR MODEL?
7. OBJECTIVE?
8. ACCEPTANCE CRITERIA?
9. SEMANTIC SCOPE?
10. PATH SCOPE?
11. REQUIRED SOURCES?
12. REQUIRED VERIFICATION?
13. ANDROID ENVIRONMENT FACTS KNOWN?
14. DEVICE/EMULATOR CAPABILITY REQUIRED?
15. CREDENTIAL/COST/PROVIDER ACTION REQUIRED?
16. PRODUCT PUBLICATION AUTHORIZED TO TECHNICAL ACTOR? Expected answer: NO.
17. UNRESOLVED HOLD/REWORK/ESCALATE?
18. MISMATCH CHECK: PASS | FAIL?

If any material answer is UNKNOWN and cannot be safely reconstructed:

STOP → report blocker → Supervisor.

### 9.2 Bootstrap output

A compact persisted or handoff-ready summary may be:

~~~text
BOOTSTRAP
REPOSITORY:
ROLE:
WORK ITEM:
AUTHORITY:
BASE:
BRANCH/PR:
OBJECTIVE:
SEMANTIC SCOPE:
PATH SCOPE:
VERIFICATION:
ANDROID ENVIRONMENT:
DEVICE EVIDENCE REQUIRED: YES | NO | UNKNOWN
EXTERNAL ACTION REQUIRED: YES | NO
MISMATCH CHECK: PASS | FAIL
STATE: READY | BLOCKED
~~~

### 9.3 Specification sufficiency gate

Before **substantial implementation**, the Implementer MUST verify that enough current engineering/product specification exists to make the Objective and Acceptance Criteria executable and testable.

This gate is lightweight. It does not require exhaustive documentation for a bounded task.

Classify a material gap as one of:

- `TECHNICAL_UNKNOWN`;
- `PRODUCT_GAME_DESIGN_UNKNOWN`;
- `SPECIFICATION_AMBIGUITY`;
- `SPECIFICATION_ABSENCE`;
- `STALE_SPECIFICATION`.

If material specification is missing, ambiguous, contradictory, stale, or insufficient:

`STOP IMPLEMENTATION`.

The Implementer MUST NOT invent product/game intent or silently select a preferred interpretation.

Persist:

~~~text
SPECIFICATION_GAP_REPORT

WORK_ITEM:
ACTIVITY_ID:
TARGET_IMPLEMENTATION:
CURRENT_SPEC / SPEC_REF:
GAP_TYPE:
MISSING_INFORMATION:
QUESTIONS_REQUIRING_HUMAN_DIRECTION:
TECHNICAL_QUESTIONS_RESEARCHABLE:
WHY_IMPLEMENTATION_CANNOT_SAFELY_CONTINUE:
PROPOSED_RESEARCH_SCOPE:
EXPECTED_RESEARCH_OUTPUT:
NEXT_ACTOR:
STATE: BLOCKED_FOR_SPECIFICATION
~~~

Rules:

- product/game-design intent that cannot be inferred safely returns to Supervisor/Human;
- technical research requires a separately persisted bounded authority;
- `RESEARCH AUTHORITY != IMPLEMENTATION AUTHORITY`;
- `RESEARCH RESULT != SPECIFICATION AUTHORITY`;
- specification resolution precedes a new substantial implementation task.

### 9.4 Document consistency gate

Activate `DOCUMENT_CONSISTENCY_GATE` when substantial work depends on multiple normative specifications, architecture/project rules, workflow documents, or technical instructions.

Use progressive disclosure:

1. inspect the documents directly relevant to the Work Item;
2. follow their normative references;
3. expand only when evidence reveals conflict, ambiguity, superseded dependency, or authority uncertainty.

Classify each material document as:

- `CURRENT`;
- `SUPERSEDED`;
- `HISTORICAL`;
- `PROVENANCE_ONLY`;
- `NON_NORMATIVE`;
- `UNKNOWN_STATUS`.

Use the source-precedence rules in section 0.3 and current Work Item authority. If applicable precedence remains materially ambiguous, STOP.

Check for:

- materially contradictory instructions;
- duplicate or competing normative instructions;
- superseded/stale references;
- obsolete material SHAs;
- unresolved TODO/TBD that affects implementation;
- two sources appearing to independently authorize incompatible actions;
- insufficient collective coverage to execute Acceptance Criteria without inventing behavior.

Duplicate instructions may be classified as:

- `CONSISTENT_DUPLICATION`;
- `REDUNDANT_DUPLICATION`;
- `CONFLICTING_DUPLICATION`;
- `AMBIGUOUS_DUPLICATION`.

`MULTIPLE SOURCES != MULTIPLE AUTHORITIES`.

If a material conflict or unknown current source can change implementation behavior:

`STOP IMPLEMENTATION`.

Persist:

~~~text
DOCUMENT_CONSISTENCY_GAP_REPORT

WORK_ITEM:
ACTIVITY_ID:
TARGET_IMPLEMENTATION:
DOCUMENTS_REVIEWED:
CURRENT_DOCUMENT_CANDIDATES:
SUPERSEDED_DOCUMENTS:
CONFLICT_TYPE:
CONFLICTING_INSTRUCTIONS:
AUTHORITY_AMBIGUITY:
AFFECTED_REQUIREMENTS:
IMPLEMENTATION_RISK:
QUESTIONS_REQUIRING_HUMAN_DECISION:
QUESTIONS_RESEARCHABLE:
PROPOSED_RESOLUTION_SCOPE:
NEXT_ACTOR:
STATE: BLOCKED_FOR_DOCUMENT_CONSISTENCY
~~~

Do not perform a full repository documentation audit by default.

### 9.5 Persistent Work Readiness

Run `PERSISTENT_WORK_READINESS` before substantial/persistent work when material uncertainty, multi-session execution, long import/build/test cycles, external/local capability, device access, credentials/cost, or similar foreseeable dependencies can block or invalidate execution.

Do not apply the full readiness gate to trivial/bounded work that is safely executable without it.

Check only material items:

1. authority;
2. Objective and executable Acceptance Criteria;
3. Semantic Scope and Path Scope;
4. exact Base/SHA;
5. required current specifications;
6. document consistency where triggered;
7. volatile technical facts;
8. required tools/capabilities;
9. credentials/accounts/cost authority;
10. physical-device or external-actor need;
11. build/environment/dependencies;
12. unresolved product decisions;
13. expected evidence/output;
14. foreseeable blockers;
15. checkpoint/recovery viability through GitHub.

Allowed readiness states:

- `READY`;
- `READY_WITH_KNOWN_RISKS`;
- `NOT_READY_RESEARCH_REQUIRED`;
- `NOT_READY_DECISION_REQUIRED`;
- `NOT_READY_CAPABILITY_REQUIRED`.

These are readiness/evidence states only. They do not replace Supervisor semantic decisions.

A material specification gap or material document conflict MUST NOT be downgraded to `READY_WITH_KNOWN_RISKS`.

`PERSISTENCE != BLIND START`.

---

## 10. Reading and context policy

Use progressive disclosure.

### 10.1 Read first

1. Active Work Item.
2. This Android workflow.
3. AGENTS.md / PROGRAM.md and any more specific repository instructions.
4. Affected code/module/build files.
5. Tests adjacent to the changed behavior.
6. Project docs directly relevant to the task.

### 10.2 Read only when needed

- architecture docs;
- Android build docs in the repository;
- release/signing docs;
- accepted Issue #2 evidence;
- external official docs activated by Research/Freshness Gate.

### 10.3 Do not reconstruct history unnecessarily

Normal operation must not require reading the full Issue #2 Workpack.

Issue #2 exists as accepted provenance/evidence.

### 10.4 Avoid irrelevant context

Do not load:

- unrelated modules;
- old candidate comparisons;
- unrelated issue threads;
- entire repository docs by default;
- external sources not needed by the task.

Context size is not evidence quality.

### 10.5 Optional Unity/Game profile activation

If the active Work Item materially targets a Unity-based Android game/project, load:

`ANDROID_WORKFLOW.md + ANDROID_UNITY_GAME_PROFILE.md + CURRENT PROJECT/GAME SPECIFICATIONS`.

Rules:

- `ANDROID_WORKFLOW.md` remains the governing standalone Android platform workflow;
- `ANDROID_UNITY_GAME_PROFILE.md` is an optional subordinate operational profile;
- profile activation does not create new authority;
- profile rules apply only where relevant to the active Unity/Game Work Item;
- concrete game behavior, targets, scenes, budgets, and product decisions come from current project/game specifications and the Work Item;
- non-Unity Android Work Items do not require the Unity/Game profile.

`ANDROID_UNITY_GAME_PROFILE EXTENDS ANDROID_WORKFLOW`.

`ANDROID_UNITY_GAME_PROFILE DOES NOT REPLACE ANDROID_WORKFLOW`.

`PROFILE ACTIVATION != NEW WORKFLOW AUTHORITY`.

---

## 11. Android environment contract

Each Android project should define or allow reconstruction of an environment contract.

The workflow does not freeze current versions.

### 11.1 Required environment facts

Record where materially relevant:

- Gradle wrapper version;
- Android Gradle Plugin compatibility;
- JDK/toolchain version;
- Android SDK / compileSdk / targetSdk / minSdk;
- Kotlin version and configuration;
- UI stack relevant to the task, such as Compose or Views;
- version catalog/build logic strategy when used;
- required SDK components;
- project modules/variants relevant to verification;
- deterministic install/build/test/lint commands;
- network/dependency policy;
- CI execution environment;
- emulator/device capability if required.

### 11.2 Environment facts are project facts

Do not encode “latest AGP,” “latest SDK,” “latest Kotlin,” or “current Play rule” as timeless Workflow constants.

When current facts matter, use the Research/Freshness Gate.

### 11.3 Greenfield architecture guidance

For greenfield native Android, accepted Issue #2 evidence supports starting from:

- Kotlin-first;
- Compose for new UI where appropriate;
- unidirectional state flow;
- state-holder separation;
- host-testable domain/data logic where practical.

This is guidance, not an authority to migrate an existing Java/View project.

Existing project architecture remains authoritative unless the Work Item explicitly changes it.

---

## 12. Implementation discipline

### 12.1 Minimal authorized change

Implement the smallest change that satisfies the Work Item.

Avoid:

- opportunistic refactors;
- dependency upgrades not required by the task;
- build-system rewrites;
- broad architecture migrations;
- unrelated cleanup;
- provider adoption not required by the task.

### 12.2 Respect project architecture

Before adding new structure, identify:

- existing module boundaries;
- state/data patterns;
- dependency injection approach;
- navigation approach;
- test conventions;
- build conventions.

New work should fit the current architecture unless the Work Item explicitly authorizes architectural change.

### 12.3 Keep logic host-testable where practical

When design permits, isolate business/data logic from Android runtime concerns so that fast host/JVM tests can prove behavior.

This reduces unnecessary device dependence but does not eliminate device evidence when Android semantics matter.

### 12.4 Never hide required Android behavior behind host-only success

HOST BUILD CAPABILITY != EMULATOR/DEVICE CAPABILITY.

A host-only test suite cannot prove behavior that depends on Android framework/runtime/device semantics.

---

## 13. Problems discovered during work

Classify discovered problems.

### 13.1 Related and inside scope

If the issue:

- is directly caused by the authorized change;
- is inside Semantic Scope;
- is inside Path Scope;
- can be fixed without authority expansion;

the Implementer MAY fix it and report it.

### 13.2 Related but outside scope

If it requires:

- new path;
- new module;
- expanded behavior;
- architecture change;
- new dependency/provider;
- credential/account action;
- material cost;

STOP and request Supervisor decision.

### 13.3 Unrelated defect

Do not fix it opportunistically.

Persist/report enough evidence for later triage.

### 13.4 Security or publication concern

If work reveals:

- exposed secret;
- signing-key risk;
- unauthorized account access;
- unintended publication capability;
- production-state mutation;

STOP immediately and escalate.

---

## 14. Android verification model

Verification is risk-tiered.

The Work Item defines the required minimum.

## 14.1 Base host verification

For ordinary implementation checkpoints, the base model is:

1. relevant local/JVM tests;
2. Android lint;
3. relevant compile/assemble/build task.

Use project-native commands from the environment contract.

Examples are illustrative only:

~~~text
./gradlew <relevant-test-task>
./gradlew <relevant-lint-task>
./gradlew <relevant-assemble-or-build-task>
~~~

Do not assume a specific module/variant/task name.

### 14.2 Release-affecting work

If the change affects release packaging, signing, shrinker/proguard/R8 behavior, manifest merging, release-only resources, or artifact generation, verify the relevant release variant without exposing production secrets unnecessarily.

The Work Item determines whether a signed artifact is required.

### 14.3 Device evidence risk classifier

Device/emulator evidence is required when the change materially affects:

- Compose/View behavior not sufficiently proven by host tests;
- Android framework integration;
- lifecycle behavior;
- configuration changes;
- permissions;
- intents;
- services;
- broadcast/foreground/background behavior;
- persistence behavior that depends on Android runtime semantics;
- hardware/sensors;
- camera;
- Bluetooth;
- vendor-specific behavior;
- API compatibility;
- form factor;
- release-critical user journey;
- performance or behavior where emulator fidelity is insufficient.

### 14.4 Device evidence is not automatically required for every change

Do not run a full device matrix by default.

Select the smallest matrix justified by risk.

Broader matrices MAY run:

- pre-release;
- nightly;
- on a dedicated validation branch;
- through an authorized device lab.

This must be an explicit project rule.

### 14.5 Physical-device trigger

Physical-device evidence should be considered when:

- emulator fidelity is insufficient;
- hardware behavior matters;
- vendor behavior matters;
- performance/thermal/battery behavior matters;
- permissions or OS integrations differ materially;
- release-critical behavior must be proven on representative real hardware.

### 14.6 Accessibility and UX

For material Android UI changes:

- run applicable automated accessibility checks when available;
- validate focus/navigation/content descriptions/semantics where relevant;
- require Human/design/accessibility review when qualitative judgment is needed.

Automation is evidence, not complete UX approval.

---

## 15. Provider-neutral Android device adapter

A device adapter is a capability boundary, not a mandatory provider.

### 15.1 Allowed implementations

Depending on project and authority:

- attached physical device;
- local Android emulator;
- Gradle Managed Device;
- authorized virtualized cloud runner;
- Firebase Test Lab;
- another authorized Android device farm.

Firebase/Test Lab is optional.

### 15.2 Required adapter inputs

When device evidence is required, record:

- governing Work Item;
- exact repository SHA;
- app/test artifact identity;
- artifact hashes when applicable;
- runner/test selection;
- device model/profile;
- API level;
- ABI where relevant;
- form factor;
- locale/orientation when relevant;
- retry/flaky policy;
- timeout;
- expected result.

### 15.3 Required adapter outputs

Return:

- pass/fail/skip;
- device/API metadata;
- run ID;
- logs/reports;
- screenshots/traces only when required and permitted;
- retry history;
- deviations;
- unresolved warnings;
- artifact references.

### 15.4 Adapter boundary

A provider result cannot issue:

- SEMANTIC_ACCEPTED;
- MERGE_ELIGIBLE;
- merge;
- product publication.

Device evidence remains evidence.

---

## 16. CI, evidence, and checkpoint discipline

### 16.1 CI goals

CI should provide reproducible evidence bound to exact SHA.

Typical Android CI may include:

- dependency/setup;
- relevant JVM/unit tests;
- lint;
- compile/assemble/build;
- selected integration tests;
- device/emulator job only when required;
- artifact collection;
- report retention.

### 16.2 CI exactness

The evidence must identify:

- commit SHA;
- workflow/job;
- relevant configuration;
- pass/fail state;
- artifact/run references.

### 16.3 CI failure

If required CI fails:

- do not ignore it;
- determine whether failure is caused by the change;
- fix within scope or report blocker;
- rerun only under allowed workflow operations.

### 16.4 CI absence

If CI is NOT CONFIGURED:

- do not claim CI PASS;
- run the required local/project-native verification;
- report CI: NOT CONFIGURED.

### 16.5 Checkpoints

Persist a checkpoint when:

- switching phase;
- context may be lost;
- external actor is invoked;
- material research changes rationale;
- a long-running verification boundary is crossed;
- Supervisor needs an intermediate decision.

A checkpoint should include exact SHA and state.

---

## 17. Repository publication procedure

This section corresponds to the inherited baseline repository-publication function.

REPOSITORY_PUBLICATION is not product publication.

### 17.1 Before commit

The Implementer MUST:

- review all changed paths;
- confirm Semantic Scope;
- confirm Path Scope;
- confirm no unintended files changed;
- run required verification;
- confirm secrets are not introduced;
- confirm no baseline/reference violation.

### 17.2 Commit

Use a focused commit.

The commit should:

- describe the bounded change;
- avoid unrelated edits;
- preserve traceability.

### 17.3 Push / branch

Push only to the authorized branch.

Wrong target is STOP.

### 17.4 Pull request

Open/update the authorized PR.

The PR should identify:

- Work Item;
- purpose;
- exact scope;
- verification;
- known risks;
- evaluation/merge status.

Opening a PR does not create semantic acceptance or merge eligibility.

---

## 18. Implementer handoff

After implementation and verification, publish a compact durable handoff.

Required fields:

~~~text
IMPLEMENTER_HANDOFF

WORK ITEM:
ROLE:
BRANCH:
PR:
HEAD:
BASE:

OBJECTIVE RESULT:
PASS | INCOMPLETE | BLOCKED

CHANGED PATHS:
- ...

VERIFICATION:
- command/check:
- result:

ANDROID ENVIRONMENT:
- relevant facts:

DEVICE EVIDENCE:
REQUIRED: YES | NO
ADAPTER:
RUN ID:
DEVICE/API:
ARTIFACT HASHES:
RESULT:

CI:
PASS | FAIL | PENDING | NOT CONFIGURED

EXTERNAL ACTOR:
USED: YES | NO
ACTIVITY REF:

UNEXPECTED FINDINGS:
- ...

RISKS / UNCERTAINTIES:
- ...

MISMATCH CHECK:
PASS | FAIL

STATE:
READY_FOR_REVIEW | BLOCKED
~~~

Rules:

- report facts, not self-approval;
- include exact HEAD;
- do not claim SEMANTIC_ACCEPTED;
- stop after handoff unless a later authority authorizes more work.

### 18.1 Profile-aware handoff additions

When the optional Unity/Game profile is active and the fields are material, the handoff MAY additionally include:

- profile activation;
- current game/engineering specification refs;
- document-consistency/readiness state;
- Local Execution Agent activity;
- Build ID/hash;
- local/runtime/device Test ID and evidence;
- pending game-specific verification.

Do not add irrelevant game/runtime metadata to documentation-only or host-only work.

---

## 19. Supervisor exact-SHA review

The Supervisor independently checks the exact PR HEAD.

### 19.1 Required review inputs

- governing Work Item;
- exact HEAD;
- branch/PR;
- diff;
- changed files;
- architecture compatibility;
- Acceptance Criteria;
- verification evidence;
- CI;
- device evidence when required;
- Android environment facts;
- documentation;
- external-actor records when used;
- unresolved warnings.

### 19.2 Review questions

1. Does the implementation satisfy Objective?
2. Does each Acceptance Criterion pass?
3. Did the Implementer stay inside Semantic Scope?
4. Did the Implementer stay inside Path Scope?
5. Are Android-specific verification decisions justified?
6. Was device evidence required and, if so, sufficient?
7. Is host success being incorrectly treated as device proof?
8. Are secrets/signing/account boundaries respected?
9. Did any technical capability become implicit authority?
10. Is product publication still Human-only?
11. Does the exact reviewed SHA match PR HEAD?
12. Are CI/test results evidence rather than approval?
13. Is any HARD VETO present?
14. Are unresolved findings acceptable or do they require REWORK/HOLD/ESCALATE?

### 19.3 New commit after review

If HEAD changes after review, the prior semantic decision does not automatically apply to the new SHA.

A new exact-SHA review is required.

---

## 20. Formal Supervisor decisions

Only four semantic decisions exist.

## 20.1 SEMANTIC_ACCEPTED

Meaning:

- the exact reviewed SHA satisfies the Work Item intent and Acceptance Criteria;
- no material semantic defect remains for that exact SHA.

It does NOT mean:

- MERGE_ELIGIBLE automatically;
- merged;
- canonical;
- product published.

## 20.2 REWORK

Meaning:

- correction is required;
- objective generally remains valid;
- same Work Item/branch/PR normally continues.

REWORK must identify:

- reviewed SHA;
- defect;
- required result;
- scope;
- evidence required.

## 20.3 HOLD

Meaning:

- the objective cannot currently progress because a blocker is unresolved.

Examples:

- required credential unavailable;
- required device/provider capability unavailable;
- external dependency prevents proof;
- Human decision pending.

HOLD is not failure by default.

## 20.4 ESCALATE

Meaning:

- Human/material decision is required.

Examples:

- objective/scope change;
- architecture decision;
- paid provider commitment;
- signing/account policy decision;
- publication decision;
- material risk trade-off.

---

## 21. REWORK continuity

### 21.1 Same objective

When Objective and authorized contract remain valid:

- continue in the same Issue;
- continue same branch/PR unless Supervisor says otherwise;
- make one focused correction commit;
- rerun affected verification;
- publish a new handoff;
- obtain new exact-SHA review.

### 21.2 Exact-SHA invalidation

If SHA A received REWORK and the Implementer creates SHA B:

- SHA A remains historical evidence;
- SHA B is the new review target;
- no semantic status transfers automatically.

If SHA A was SEMANTIC_ACCEPTED and any new commit creates SHA B:

- SHA B is not semantically accepted until reviewed.

### 21.3 Scope-changing rework

If correction requires:

- new Objective;
- expanded Semantic Scope;
- expanded Path Scope;
- architecture change;
- new credential/provider commitment;
- changed publication authority;

STOP → Supervisor/Human decision.

Do not disguise scope expansion as REWORK.

---

## 22. Current-decision rule

The current valid semantic decision is:

the latest Supervisor decision explicitly associated with the current exact HEAD.

Do not use:

- an older decision for another SHA;
- a handoff as a decision;
- a CI status as a decision;
- an external actor result as a decision.

If current HEAD has no applicable decision:

state is not semantically accepted.

---

## 23. Integration and merge eligibility

After SEMANTIC_ACCEPTED, integration still requires separate checks.

Typical sequence:

READY_FOR_REVIEW
→ SEMANTIC_ACCEPTED
→ verify target branch/base state
→ verify required CI/evidence
→ verify no newer conflicting change
→ verify merge authority
→ MERGE_ELIGIBLE
→ merge
→ post-merge checks if required
→ CLOSED

### 23.1 Merge eligibility checks

As applicable:

- exact reviewed HEAD still equals PR HEAD;
- target branch remains expected;
- CI required checks pass;
- required approvals exist;
- no blocking HOLD/ESCALATE;
- no merge conflict or target divergence invalidates review assumptions;
- repository rules allow merge;
- merge authority is present.

SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.

---

## 24. Merge boundary

The Implementer MUST NOT self-merge.

An external actor MUST NOT gain merge authority from technical capability.

Where the governing Workflow authorizes Supervisor merge, the Supervisor may merge only after:

- exact-SHA semantic acceptance;
- merge-eligibility checks;
- target state verification.

If merge authority is not demonstrable:

STOP.

---

## 25. Product publication boundary

Product publication is distinct from repository publication.

PUBLISH = HUMAN ACTION.

### 25.1 Android technical pre-publication work

When authorized, technical work MAY include:

- building release artifacts;
- verifying release variant;
- generating/validating APK/AAB;
- signing-support operations;
- upload/staging support;
- retaining artifact/signing evidence;
- checking current Google Play / target API / account requirements through Research/Freshness Gate.

### 25.2 What technical actors cannot infer

The following do not grant publication authority:

- signing key access;
- upload key access;
- Play Console access;
- release-tool access;
- CI deploy credentials;
- successful AAB generation;
- successful upload;
- Work Item technical permission;
- external actor capability.

### 25.3 Signing boundary

Normal implementation/test contexts should not hold production signing material unless explicitly required.

If signing is required:

- use least privilege;
- identify artifact;
- identify signing context;
- do not expose secrets in logs/handoffs;
- persist only safe evidence;
- stop if credential handling would exceed authority.

### 25.4 Store rollout

Any actual store/product publication is performed by Human action under the governing product/release process.

---

## 26. Implementer session recovery

A fresh Implementer does not reconstruct state from prior chat.

Read GitHub.

### 26.1 Minimum recovery tuple

Recover:

- repository;
- active Work Item;
- role;
- current authority;
- branch/ref;
- exact HEAD;
- PR;
- Objective;
- Acceptance Criteria;
- Semantic Scope;
- Path Scope;
- Verification;
- latest applicable Supervisor decision;
- reviewed SHA;
- last evidence/checkpoint;
- Android environment contract;
- device evidence state;
- external-actor activity state;
- unresolved REWORK/HOLD/ESCALATE;
- next authorized action.

### 26.2 Recovery rule

If current HEAD differs from the SHA named in the latest semantic decision:

do not assume acceptance.

### 26.3 Recovery template

~~~text
IMPLEMENTER_RECOVERY

REPOSITORY:
WORK ITEM:
ROLE:
AUTHORITY:
BRANCH/REF:
HEAD:
PR:
OBJECTIVE:
SEMANTIC SCOPE:
PATH SCOPE:
VERIFICATION:
ANDROID ENVIRONMENT:
DEVICE EVIDENCE STATE:
LATEST SUPERVISOR DECISION:
REVIEWED SHA:
EXTERNAL ACTIVITY:
BLOCKER / REWORK:
NEXT AUTHORIZED ACTION:
MISMATCH CHECK: PASS | FAIL
~~~

### 26.4 Profile-aware persistent recovery

When the Unity/Game profile or substantial persistent work is active, recover additionally when material:

- profile activation;
- current specification refs/status;
- document-consistency state;
- persistent-work readiness state;
- current milestone;
- completed milestones;
- pending local/device/performance/playtest evidence;
- Local Execution Agent activity/result;
- next authorized action.

A new session MUST still reconstruct authority from GitHub, not from the prior session.

---

## 27. Supervisor session recovery

A fresh Supervisor also reconstructs from GitHub, not prior chat.

### 27.1 Minimum Supervisor recovery set

- Human intent/current governing Issue;
- active Work Item;
- exact PR HEAD;
- target branch;
- Work Item contract;
- relevant repository instructions;
- latest Implementer handoff;
- verification evidence;
- CI;
- Android environment facts;
- device evidence when required;
- external actor records;
- latest Supervisor decision/reviewed SHA;
- unresolved blocker/REWORK/HOLD/ESCALATE.

### 27.2 Supervisor mismatch rule

If repository, Work Item, actor, authority, target, or SHA mismatches:

STOP.

Do not reinterpret another project's task into the current one.

---

## 28. Human role

The Human is not merely an emergency fallback.

The Human owns decisions that require human product/account authority.

Typical Human-only or Human-reserved actions:

- credentials/MFA;
- account/security confirmation;
- material scope/product change;
- architecture/Workflow adoption where required;
- paid provider commitment;
- production-store decisions;
- PUBLISH / product publication.

The workflow should automate permitted technical work while minimizing Human interruption.

Do not ask the Human to perform routine mechanical work that an authorized technical actor can safely perform.

---

## 29. Research/Freshness Gate + Strategic Rationale

Issue #2 research is the accepted evidence library.

Do not repeat broad research by default.

### 29.1 When Research/Freshness Gate activates

Activate when a material decision depends on a current external fact, such as:

- Android Gradle Plugin/JDK compatibility;
- current Android SDK requirement;
- Google Play target/API policy;
- current Play account/submission rule;
- current device-lab capability;
- provider pricing/quota when cost authority matters;
- security guidance materially affecting implementation;
- deprecation/removal that changes feasible architecture.

Do not activate for curiosity.

### 29.2 Research behavior

When activated:

- prefer official/primary sources;
- record date/version scope;
- distinguish fact from inference;
- avoid timeless wording for volatile facts;
- cite evidence in the Work Item or rationale;
- stop if research reveals architecture/authority change requiring decision.

### 29.3 Evidence categories

Label material statements as appropriate:

- PROJECT FACT
- EXTERNAL VERIFIED FACT
- EMPIRICAL OBSERVATION
- INFERENCE
- RECOMMENDATION
- UNKNOWN

### 29.4 Supervisor verification

The Supervisor reviews whether:

- research was actually required;
- sources are appropriate;
- conclusions follow from evidence;
- authority remains unchanged.

### 29.5 Strategic Rationale

Persist a STRATEGIC_RATIONALE when a material technical choice affects architecture, risk, provider use, verification, or maintainability.

Template:

~~~text
STRATEGIC_RATIONALE

DECISION:
CONTEXT:
OPTIONS CONSIDERED:
PROJECT FACTS:
EXTERNAL FACTS:
INFERENCES:
WHY THIS OPTION:
RISKS:
FRESHNESS / VERSION SCOPE:
AUTHORITY IMPACT:
NONE | REQUIRES DECISION
~~~

Research informs authority decisions; it does not create authority.

### 29.6 Pre-work research rule

A material unknown discovered by bootstrap/readiness does not authorize the Implementer to begin an open-ended research phase.

Required flow:

`MATERIAL UNKNOWN`
→ classify
→ STOP implementation when necessary
→ persist the exact gap
→ Supervisor/Human path as applicable
→ separately authorized bounded research
→ persist result/evidence/remaining unknowns
→ resolve/update specification under proper authority if required
→ rerun applicable gates
→ new implementation authority.

Research only material unknowns that can:

- block execution;
- invalidate evidence;
- cause material rework;
- require unauthorized credentials/cost;
- materially redirect product or architecture.

Do not research "just in case".

`RESEARCH AUTHORITY != IMPLEMENTATION AUTHORITY`.

`RESEARCH RESULT != SPECIFICATION AUTHORITY`.

---

## 30. Optional external-actor protocol

An external actor exists only for a concrete missing capability.

Every invocation MUST have a durable GitHub activity record.

Required lifecycle:

request
→ authority
→ execution
→ evidence
→ result
→ stop/escalation

### 30.1 Required activity record

~~~text
EXTERNAL_ACTOR_ACTIVITY

ACTIVITY_ID:
GOVERNING_WORK_ITEM:
ACTOR_TYPE:
CAPABILITY:
OBJECTIVE:
PRECONDITIONS:
AUTHORIZED_OPERATIONS:
FORBIDDEN_OPERATIONS:
EXPECTED_BASELINE:
EVIDENCE_REQUIRED:
RESULT:
STOP_CONDITIONS:
ESCALATION_PATH:
STATUS:
~~~

### 30.2 Capability

Define one concrete capability, for example:

- physical-device matrix;
- emulator/cloud device execution;
- specialized Android build;
- signing-support operation;
- bounded non-publication provider configuration.

### 30.3 Preconditions

Include:

- governing Work Item;
- exact ref/SHA;
- artifact hashes when applicable;
- account/provider readiness;
- credential authority;
- cost/quota authority;
- environment/device matrix.

### 30.4 Authorized operations

Enumerate exact allowed operations.

Default deny outside the list.

### 30.5 Forbidden operations

At minimum, unless separately authorized:

- Workflow modification;
- Objective change;
- Acceptance Criteria change;
- Semantic Scope expansion;
- Path Scope expansion;
- baseline/reference modification;
- unrelated source changes;
- self-approval;
- SEMANTIC_ACCEPTED;
- MERGE_ELIGIBLE;
- merge;
- product publication;
- new paid-service commitment;
- credential/account mutation;
- unauthorized retries/workarounds.

### 30.6 Expected baseline / SHA gate

The activity must bind to:

- Work Item;
- exact SHA/ref;
- artifact hashes where applicable;
- toolchain/configuration;
- test/device matrix.

If baseline changes:

STOP or obtain renewed authority.

### 30.7 Evidence returned

Return only evidence required by the activity:

- run ID;
- environment/device metadata;
- pass/fail/skip;
- logs/reports/artifacts;
- retry/deviation history;
- unresolved warnings.

### 30.8 STOP conditions

STOP when:

- input SHA differs;
- required credential is unavailable;
- cost/provider permission is missing;
- operation exceeds scope;
- new architecture/Workflow decision is required;
- evidence is invalid/incomplete;
- behavior creates material contradiction;
- publication would be required;
- retry could create an unsafe/duplicate external effect.

### 30.9 Escalation

Return:

- blocker;
- evidence;
- exact requested decision;
- no unauthorized workaround.

### 30.10 Durable result and closure

Persist RESULT and STATUS.

A provider-only trace or chat-only trace is insufficient.

### 30.11 Bounded external platform mutation

If an Android external platform state must be changed, require:

- exact target;
- exact authorized scope;
- observable baseline;
- before/after evidence;
- rollback when applicable;
- STOP conditions;
- no code/repository/publication authority implied.

Examples might include bounded test-device/provider configuration under explicit authority.

### 30.12 Historical AI Studio Issue #53 compatibility rule

The frozen baseline contains a specific historical compatibility rule for an earlier Issue #53 / AI Studio quota state.

That historical state is NOT a reusable Android operational rule.

It is intentionally not imported into normative Android operation.

Its reusable safety functions are preserved through:

- HOLD;
- current-decision rule;
- external-actor gate;
- recovery;
- PUBLISH = HUMAN ACTION;
- TECHNICAL CAPABILITY != WORKFLOW AUTHORITY.

This is the only baseline area classified NOT_APPLICABLE_WITH_JUSTIFICATION by the accepted Android adaptation matrix.

### 30.13 Local Execution Agent profile

When a Unity/Game Work Item requires local Editor, device, profiler, or interactive capability that the primary Implementer environment cannot provide, the optional Unity/Game profile may specialize the existing external-actor contract as:

`EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT`.

This is a capability profile, not a new actor authority class.

The detailed Unity/Game capability, test/result, and evidence fields live in `ANDROID_UNITY_GAME_PROFILE.md`.

Default repository write authority for this profile is NO unless a separate persisted activity explicitly authorizes repository writes.

`LOCAL CAPABILITY != WORKFLOW AUTHORITY`.

---

## 31. Technical permission != Workflow authority

Exact invariant:

TECHNICAL CAPABILITY != WORKFLOW AUTHORITY.

### 31.1 Repository/product-code writes

An actor may write repository/product code only when the governing Work Item authorizes:

- the semantic change;
- the path;
- the operation.

A tool's ability to edit a file does not authorize the edit.

### 31.2 External actor escalation

Escalating a task to an external actor does not transfer:

- Supervisor authority;
- Human authority;
- semantic-decision authority;
- merge authority;
- publication authority.

### 31.3 Credentials

Possession of:

- signing key;
- Play Console role;
- cloud token;
- provider session;
- billing access;

does not imply permission to exercise every technical capability available.

### 31.4 Cost

Technical access to a paid provider does not authorize cost.

Material provider cost requires the governing permission.

---

## 32. Android-specific platform deltas

Android remains Android-specific.

Do not force iOS/Web symmetry.

### 32.1 Primary build boundary

Android:

- Gradle;
- JDK;
- Android SDK;
- project Android toolchain.

### 32.2 Host execution

Host execution can prove:

- JVM/unit behavior;
- lint;
- compilation;
- build/assemble;
- many static/integration properties.

Host execution does not imply emulator/device capability.

### 32.3 UI/device verification

Android runtime evidence may use:

- emulator;
- Gradle Managed Device;
- physical device;
- authorized cloud device lab.

### 32.4 Signing

Android signing has platform-specific semantics.

If Google Play App Signing is used, distinguish:

- upload key;
- app-signing key held/managed through the Play model.

Do not expose or broaden signing authority unnecessarily.

### 32.5 Release artifacts

Android artifacts may include:

- APK;
- AAB;
- test artifacts.

The concrete artifact is project/release-context specific.

### 32.6 Distribution

Possible channels may include:

- Google Play;
- another store;
- internal enterprise mechanisms;
- sideload/internal testing.

The workflow does not make one distribution channel mandatory.

### 32.7 Provider neutrality

Firebase Test Lab is optional.

No CI vendor, cloud provider, device lab, IDE automation provider, or coding-agent vendor is required by this workflow.

### 32.8 Android accessibility/UX

Android accessibility/device UX remains an Android-specific verification dimension.

It is not replaced by generic web WCAG/browser checks or iOS-specific accessibility tooling.

### 32.9 Greenfield vs existing applications

Greenfield guidance MAY use current Android architectural recommendations.

Existing applications remain valid without forced migration.

### 32.10 Optional Unity/Game profile boundary

Unity/Game mechanics are not universal Android requirements.

When section 10.5 activates the profile:

- this Android Workflow remains governing for authority, lifecycle, exact-SHA review, merge, publication, recovery, and Research/Freshness semantics;
- `ANDROID_UNITY_GAME_PROFILE.md` supplies only Unity/Game operational deltas;
- project/game specifications supply concrete mechanics, behavior, performance budgets, device tiers, scenes, protocols, and product decisions;
- Unity/SDK/NDK/JDK compatibility remains a current/project fact and is freshness-gated when material.

A native/non-Unity Android task remains fully operable from this document without opening the Unity/Game profile.

---

## 33. Operational Definition of Done

An Android Work Item governed by this workflow is ready for Supervisor review only when applicable checks are complete.

The Android workflow itself is operationally complete only if all tests in section 34 pass.

### 33.1 Work Item implementation DoD

For a normal Work Item:

- repository/Work Item/role/authority/Base match;
- Objective addressed;
- Acceptance Criteria evidenced;
- Semantic Scope respected;
- Path Scope respected;
- environment facts sufficient;
- implementation bounded;
- discovered issues handled correctly;
- required host verification complete;
- required device evidence complete;
- required CI state reported;
- secrets/credentials handled safely;
- external actor record complete if used;
- full diff reviewed;
- REPOSITORY_PUBLICATION correct;
- exact HEAD identified;
- handoff persisted;
- no self-approval;
- no product publication by technical actor.

### 33.2 Triggered pre-work/profile checks

For substantial work, before claiming readiness for implementation/review as applicable:

- specification sufficiency passed, or an exact gap report stopped the work;
- document consistency passed when multiple normative sources applied, or an exact conflict report stopped the work;
- Persistent Work Readiness ran only when its trigger applied;
- bounded research did not self-authorize;
- profile activation is explicit when Unity/Game rules are used.

For a Unity/Game Work Item, also confirm that concrete game/product targets come from current project specifications/Work Item rather than this workflow.

---

## 34. Acceptance tests for this workflow

These tests validate the document architecture and operational completeness.

## TEST A — Baseline coverage

Procedure:

1. Read the accepted Android Baseline Adaptation Matrix.
2. Verify all 71 classified rows have an implemented target in this document.
3. Verify all six Work Item child fields are explicit.
4. Verify only baseline 29.12 is NOT_APPLICABLE_WITH_JUSTIFICATION.
5. Verify no normative row is silently grouped away.

Expected result:

PASS.

Failure is HARD VETO.

## TEST B — Happy path

Representative scenario:

1. Human states bounded Android intent.
2. Supervisor creates six-field Work Item.
3. Implementer bootstraps and verifies Base/scope.
4. Implementer changes authorized Android code.
5. Relevant JVM tests, lint, and build pass.
6. Risk classifier says device evidence not required.
7. Implementer publishes commit/PR.
8. Implementer handoff names exact SHA.
9. Supervisor independently reviews exact SHA.
10. Supervisor issues SEMANTIC_ACCEPTED.
11. Integration checks separately establish MERGE_ELIGIBLE.
12. Authorized merge occurs.
13. Product publication, if any, remains Human action.

Expected result:

The lifecycle can be executed from this document without reading Issue #2.

## TEST C — REWORK exact-SHA invalidation

Scenario:

1. Supervisor reviews SHA A.
2. Supervisor issues REWORK.
3. Implementer fixes same objective in same Issue/branch/PR.
4. New HEAD is SHA B.
5. Prior review of SHA A does not apply to SHA B.
6. Verification reruns as required.
7. New handoff names SHA B.
8. Supervisor reviews SHA B.

Expected result:

No acceptance automatically carries across SHA change.

## TEST D — Authority adversarial

Cases:

1. Implementer has Play Console credentials.
   Expected: cannot product-publish.

2. External actor can upload an AAB.
   Expected: cannot product-publish or self-approve.

3. CI is green.
   Expected: CI cannot issue SEMANTIC_ACCEPTED.

4. Implementer can edit a file in an authorized path.
   Expected: cannot make unrelated semantic change.

5. External actor can sign an artifact.
   Expected: signing capability does not create Workflow authority.

6. Supervisor issued SEMANTIC_ACCEPTED.
   Expected: merge eligibility still checked separately.

All cases must resolve safely.

## TEST E — STOP / escalation

Cases:

- wrong repository;
- wrong Work Item;
- wrong Base;
- wrong PR target;
- missing Path Scope;
- implementation requires new architecture;
- required credential unavailable;
- paid device provider required but cost not authorized;
- current Play policy is material but unknown;
- external actor baseline does not match;
- publication would require a technical actor to exceed authority.

Expected result:

STOP / HOLD / ESCALATE as appropriate.
No inference.

## TEST F — Session recovery

Fresh Implementer:

- reconstructs Issue, branch/ref, HEAD, PR, scope, evidence, latest decision, Android environment, and next action from GitHub.

Fresh Supervisor:

- reconstructs Human intent, exact HEAD, evidence, latest handoff, prior decision SHA, blockers, and review target from GitHub.

Expected result:

No prior chat transcript required.

## TEST G — External actor durability

Create a representative device-lab activity.

Verify GitHub records:

request
→ authority
→ execution
→ evidence
→ result
→ stop/escalation.

Expected result:

A future authorized session can reconstruct exactly what happened and why.

## TEST H — Android platform delta

Cases:

1. Host build succeeds but no emulator capability exists.
   Expected: do not claim device proof.

2. Emulator test passes but physical hardware behavior is material.
   Expected: obtain justified physical-device evidence or report blocker.

3. Firebase Test Lab unavailable.
   Expected: workflow remains valid; provider is optional.

4. Build/sign/upload succeeds.
   Expected: product publication remains Human-only.

5. Existing Java/View app.
   Expected: no forced Compose migration.

## TEST I — Standalone use

Remove Issue #2 research artifacts from the normal execution scenario.

Provide only:

- repository;
- active Work Item;
- this document;
- project docs explicitly referenced by the Work Item.

Expected result:

Implementer and Supervisor can run the normal lifecycle.

Issue #2 remains provenance, not procedure dependency.

## TEST J — Summary regression

Create a short summary/checklist from this workflow.

Verify that the summary does not become the normative source and does not weaken:

- six-field Work Item;
- Semantic Scope + Path Scope;
- exact-SHA review;
- decision vocabulary;
- REWORK continuity;
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE;
- PUBLISH = HUMAN ACTION;
- session recovery;
- HARD VETO;
- TECHNICAL CAPABILITY != WORKFLOW AUTHORITY;
- device capability boundaries;
- external-actor durability.

If any invariant disappears or weakens:

REWORK / HARD VETO.

## TEST K — Specification and document safety

Scenario:

A substantial Work Item lacks a material current specification, or two current-looking normative documents conflict.

Expected:

- implementation stops;
- the appropriate gap report identifies the exact missing/conflicting material;
- the Implementer does not invent product intent or choose a preferred authority source;
- technical research requires separate bounded authority;
- implementation resumes only after proper resolution and new authority.

## TEST L — Persistent readiness proportionality

Scenario A:
A short bounded host-only change has clear authority, scope, environment, and verification.

Expected:
No full Persistent Work Readiness ceremony is required.

Scenario B:
A multi-session Unity/Android activity depends on project specs, toolchain compatibility, local device capability, and long-running verification.

Expected:
Persistent Work Readiness records the material readiness state before substantial execution.

## TEST M — Unity profile non-regression

Scenario A:
A non-Unity Android Work Item is executed.

Expected:
This Android Workflow is sufficient without loading the Unity/Game profile.

Scenario B:
A Unity/Game Work Item activates `ANDROID_UNITY_GAME_PROFILE.md`.

Expected:
The profile extends operational mechanics but cannot redefine Human/Supervisor/Implementer authority, exact-SHA semantics, merge authority, or publication authority.

---

## 35. Execution templates and checklists

## 35.1 Supervisor Work Item checklist

~~~text
WORK ITEM CREATION

HUMAN INTENT:
OBJECTIVE:
ACCEPTANCE CRITERIA:
AUTHORIZED SEMANTIC SCOPE:
AUTHORIZED PATH SCOPE:
ALLOWED EXTERNAL OPERATIONS:
FORBIDDEN OPERATIONS:
RELEVANT SOURCES:
ANDROID ENVIRONMENT FACTS:
VERIFICATION:
DEVICE EVIDENCE TRIGGER:
CI REQUIREMENT:
CREDENTIAL/COST REQUIREMENT:
BASE:
BRANCH/PR MODEL:
STOP CONDITIONS:
~~~

## 35.2 Implementer bootstrap checklist

~~~text
IMPLEMENTER BOOTSTRAP

REPOSITORY MATCH: YES | NO
WORK ITEM MATCH: YES | NO
ROLE MATCH: YES | NO
AUTHORITY VERIFIED: YES | NO
BASE VERIFIED: YES | NO
TARGET VERIFIED: YES | NO
OBJECTIVE UNDERSTOOD: YES | NO
SEMANTIC SCOPE VERIFIED: YES | NO
PATH SCOPE VERIFIED: YES | NO
SOURCES LOADED: YES | NO
VERIFICATION UNDERSTOOD: YES | NO
ANDROID ENVIRONMENT SUFFICIENT: YES | NO | UNKNOWN
DEVICE EVIDENCE REQUIRED: YES | NO | UNKNOWN
CREDENTIAL/COST ACTION REQUIRED: YES | NO
PRODUCT PUBLISH AUTHORITY FOR TECHNICAL ACTOR: NO
MISMATCH CHECK: PASS | FAIL
STATE: READY | BLOCKED
~~~

## 35.3 Android environment contract template

~~~text
ANDROID ENVIRONMENT CONTRACT

PROJECT/MODULE:
GRADLE WRAPPER:
AGP:
JDK/TOOLCHAIN:
COMPILE SDK:
TARGET SDK:
MIN SDK:
KOTLIN:
UI STACK:
REQUIRED SDK COMPONENTS:
VARIANT(S):
BASE TEST COMMAND:
LINT COMMAND:
BUILD/ASSEMBLE COMMAND:
DEVICE TEST COMMAND:
CI ENVIRONMENT:
NETWORK/DEPENDENCY POLICY:
NOTES / UNKNOWN:
~~~

Unknown values are allowed if not material to the task.
Do not invent them.

## 35.4 Risk classifier template

~~~text
ANDROID RISK CLASSIFIER

CHANGE AFFECTS:
[ ] pure host-testable logic only
[ ] Android framework
[ ] UI/runtime behavior
[ ] lifecycle/configuration
[ ] permissions/intents/services
[ ] persistence/runtime semantics
[ ] hardware/vendor behavior
[ ] API/form-factor compatibility
[ ] accessibility/device UX
[ ] release-critical journey
[ ] signing/release artifact
[ ] current Play/store policy

HOST VERIFICATION SUFFICIENT:
YES | NO

DEVICE EVIDENCE REQUIRED:
YES | NO

PHYSICAL DEVICE REQUIRED:
YES | NO

RATIONALE:
...
~~~

## 35.5 Device evidence template

~~~text
ANDROID DEVICE EVIDENCE

WORK ITEM:
SHA:
ARTIFACT:
ARTIFACT HASH:
ADAPTER:
RUN ID:
DEVICE / PROFILE:
API:
ABI:
FORM FACTOR:
TEST SELECTION:
RETRY POLICY:
RESULT:
LOG/REPORT REF:
RETRIES/DEVIATIONS:
UNRESOLVED WARNING:
~~~

## 35.6 Implementer handoff template

Use section 18 template.

## 35.7 Supervisor review template

~~~text
ANDROID_SUPERVISOR_REVIEW

WORK ITEM:
PR:
REVIEWED SHA:
BASE:
DIFF/SCOPE: PASS | FAIL
ACCEPTANCE CRITERIA: PASS | FAIL
HOST VERIFICATION: PASS | FAIL | N/A
DEVICE EVIDENCE: PASS | FAIL | N/A
CI: PASS | FAIL | PENDING | NOT CONFIGURED
ANDROID ENVIRONMENT: SUFFICIENT | INSUFFICIENT
AUTHORITY BOUNDARIES: PASS | FAIL
PUBLICATION BOUNDARY: PASS | FAIL
EXTERNAL ACTOR RECORD: PASS | FAIL | N/A
HARD VETO: NONE | PRESENT
FINDINGS:
DECISION:
SEMANTIC_ACCEPTED | REWORK | HOLD | ESCALATE
~~~

## 35.8 REWORK template

~~~text
ANDROID_REWORK

WORK ITEM:
REVIEWED SHA:
PROBLEM:
REQUIRED RESULT:
SCOPE:
SEMANTIC SCOPE CHANGED: NO | YES -> ESCALATE
PATH SCOPE CHANGED: NO | YES -> AUTHORITY REQUIRED
EVIDENCE REQUIRED:
NEXT EXPECTED HEAD:
STOP CONDITIONS:
~~~

## 35.9 Recovery template

Use sections 26 and 27 recovery templates.

## 35.10 External actor template

Use section 30.1 activity template.

## 35.11 Specification gap template

Use section 9.3 `SPECIFICATION_GAP_REPORT`.

## 35.12 Document consistency gap template

Use section 9.4 `DOCUMENT_CONSISTENCY_GAP_REPORT`.

## 35.13 Persistent Work Readiness template

~~~text
PERSISTENT_WORK_READINESS

WORK_ITEM:
ACTIVITY_ID:
BASE_SHA:
SUBSTANTIAL/PERSISTENT TRIGGER:
AUTHORITY: CLEAR | NOT_CLEAR
OBJECTIVE/AC: EXECUTABLE | NOT_EXECUTABLE
SEMANTIC/PATH SCOPE: CLEAR | NOT_CLEAR
REQUIRED SPECIFICATIONS: SUFFICIENT | GAP
DOCUMENT CONSISTENCY: READY | NON_BLOCKING_REDUNDANCY | NOT_READY | N/A
VOLATILE FACTS: CURRENT_ENOUGH | RESEARCH_REQUIRED | N/A
TOOLS/CAPABILITIES: AVAILABLE | CAPABILITY_REQUIRED
CREDENTIAL/ACCOUNT/COST: READY | DECISION_REQUIRED | N/A
DEVICE/EXTERNAL ACTOR: READY | CAPABILITY_REQUIRED | N/A
BUILD/ENV/DEPENDENCIES: READY | NOT_READY
UNRESOLVED PRODUCT DECISION: NO | YES
EXPECTED EVIDENCE: KNOWN | UNKNOWN
FORESEEABLE BLOCKERS:
CHECKPOINT/RECOVERY: VIABLE | NOT_VIABLE

STATE:
READY |
READY_WITH_KNOWN_RISKS |
NOT_READY_RESEARCH_REQUIRED |
NOT_READY_DECISION_REQUIRED |
NOT_READY_CAPABILITY_REQUIRED
~~~

This template is triggered, not universal.

---

## 36. Provenance, maintenance, and lossless derivation

### 36.1 This document is derived, not invented from scratch

The document preserves the functional baseline and applies Android adaptations justified by accepted evidence.

### 36.2 Maintenance rule

When this workflow changes:

1. identify governing Work Item;
2. state whether the change is PRESERVE / ADAPT / EXTEND / NOT_APPLICABLE_WITH_JUSTIFICATION relative to current accepted architecture;
3. verify baseline functions remain covered;
4. verify Android platform deltas remain valid;
5. activate Research/Freshness Gate only for material volatile facts;
6. run acceptance tests;
7. obtain exact-SHA Supervisor review.

### 36.3 Lossless derivation rule

No later:

- synopsis;
- handoff;
- checklist;
- presentation;
- README excerpt;
- generated prompt;

may silently replace this document as the normative Android workflow.

A summary MAY point to this document.

A summary MUST NOT weaken it.

### 36.4 Architecture changes

If maintaining Android requires changing:

- Workflow Document Contract;
- baseline adaptation classifications;
- ADR decision;
- role authority model;
- state vocabulary;
- publication boundary;

STOP platform work and return to architecture authority.

Do not patch architecture defects only inside Android.

### 36.5 Current facts

Do not hardcode volatile platform facts into Workflow semantics.

Keep current versions/policies in:

- project configuration;
- Work Item;
- evidence;
- Strategic Rationale;
- release checklist;

as appropriate.

### 36.6 Unity/Game profile maintenance

`ANDROID_UNITY_GAME_PROFILE.md` is a subordinate extension of this workflow.

Maintenance rules:

- this document remains standalone for non-Unity Android work;
- the profile MUST defer to this workflow on authority/lifecycle conflict;
- profile changes MUST NOT weaken any baseline or accepted Android adaptation;
- game-specific mechanics MUST NOT leak into universal native-Android requirements without separate justification;
- concrete project/game behavior remains outside the profile and belongs to current project specifications/Work Items.

---

# Appendix A — Baseline implementation trace

This appendix demonstrates implementation of the accepted Android Baseline Adaptation Matrix.

The matrix remains the authoritative section-by-section adaptation record.
This appendix is an execution cross-check, not a second matrix authority.

| Baseline item | Classification | Implemented here |
|---|---|---|
| Document header / status / provenance | ADAPT | §0 |
| Estado de procedencia | EXTEND | §0, §36 |
| 1. Objetivo | ADAPT | §1 |
| 2. Principio fundamental | PRESERVE | §2 |
| 3. Responsabilidades | PRESERVE | §3 |
| 3.1 Chat Web GPT | PRESERVE | §3.2 Supervisor |
| 4. Agente implementador | EXTEND | §3.3 |
| 5. GitHub | PRESERVE | §3.4 |
| 6. Documentación del proyecto | ADAPT | §10 |
| 7. Unidad de trabajo: GitHub Issue | PRESERVE | §5 |
| Objective | PRESERVE | §5.1 |
| Acceptance Criteria | EXTEND | §5.2 |
| Authorized Scope | PRESERVE | §5.3 |
| Relevant Sources | ADAPT | §5.4 |
| Verification | ADAPT | §5.5 |
| Base | PRESERVE | §5.6 |
| 8. Dos tipos de scope | PRESERVE | §6 |
| Semantic Scope | PRESERVE | §6.1 |
| Path Scope | PRESERVE | §6.2 |
| 9. Flujo completo | ADAPT | §7 |
| Fase A — intención | PRESERVE | §8.1 |
| Fase B — creación del Work Item | PRESERVE | §8.2 |
| 10. Inicio del Agente implementador | PRESERVE | §9 |
| 11. Bootstrap del Agente implementador | EXTEND | §9.1–9.2 |
| 12. Política de lectura | ADAPT | §10 |
| 13. Implementación | EXTEND | §12 |
| 14. Problemas descubiertos durante el trabajo | PRESERVE | §13 |
| 15. Verificación local | ADAPT | §14–15 |
| 16. Publicación | ADAPT | §17 REPOSITORY_PUBLICATION |
| 17. Handoff del Agente implementador | EXTEND | §18 |
| 18. Revisión de Chat Web GPT | EXTEND | §19 |
| 19. Significado de las decisiones | PRESERVE | §20 |
| SEMANTIC_ACCEPTED | PRESERVE | §20.1 |
| REWORK | PRESERVE | §20.2 |
| HOLD | PRESERVE | §20.3 |
| ESCALATE | PRESERVE | §20.4 |
| 20. REWORK | PRESERVE | §21 |
| 21. Decisión vigente | PRESERVE | §22 |
| 22. CI | ADAPT | §16 |
| 23. Integración | PRESERVE | §23 |
| 24. Merge | PRESERVE | §24 |
| 25. Cambio de sesión del Agente implementador | EXTEND | §26 |
| 26. Cambio de sesión de Chat Web GPT | EXTEND | §27 |
| 27. Rol del humano | EXTEND | §28 |
| 28. Reglas esenciales | EXTEND | §2 |
| 29. AI_STUDIO_OPERATOR fallback | ADAPT | §30 optional external actor |
| 29.1 Permission Matrix | ADAPT | §30.4–30.5 |
| 29.2 Gate universal de escalamiento | ADAPT | §30.2–30.3 |
| 29.3 Inicio / request / modos | ADAPT | §30.1–30.4 |
| 29.4 SHA Gate y evidencia | EXTEND | §30.6–30.7 |
| 29.5 Ventana única de intervención | ADAPT | §30 lifecycle / bounded activity |
| 29.6 Clasificación, seguridad y recuperación | ADAPT | §30.7–30.10 |
| 29.7 Publicación — exclusiva del Humano | PRESERVE | §25 |
| 29.8 RESEARCH_GATE / SPIKE_READ_ONLY | ADAPT | §29 |
| 29.9 Regla de no escritura | ADAPT | §30.5 |
| 29.10 REPORT / STOP | ADAPT | §30.7–30.10 |
| 29.11 Fallback de mutación externa | ADAPT | §30.11 |
| 29.12 Compatibilidad inmediata Issue #53 | NOT_APPLICABLE_WITH_JUSTIFICATION | §30.12 provenance-only rationale |
| 30. RESEARCH_GATE + STRATEGIC_RATIONALE | PRESERVE | §29 |
| 30.1 Cuándo se activa | ADAPT | §29.1 |
| 30.2 Investigación y evidencia | ADAPT | §29.2–29.3 |
| 30.3 Verificación del Supervisor | PRESERVE | §29.4 |
| 30.4 STRATEGIC_RATIONALE | PRESERVE | §29.5 |
| 30.5 Aplicación por rol/límites | PRESERVE | §29.5 and §31 |
| 31. TECHNICAL PERMISSION != WORKFLOW AUTHORITY | PRESERVE | §31 |
| 31.1 Escritura de repositorio/product-code | PRESERVE | §31.1 |
| 31.2 Escalación AI Studio | ADAPT | §31.2 / generic external actor |
| Resultado | ADAPT | §7 lifecycle + this operational document |
| Apéndice A — Provenance de mejoras consolidadas | ADAPT | §0, §36, Appendix B |
| Apéndice B — Handover canónico | ADAPT | §0 status / §36 maintenance |
| Apéndice C — Matriz completa de trazabilidad | EXTEND | Appendix A + accepted matrix |

Coverage:

- accepted matrix rows: 71;
- rows represented in this trace: 71;
- missing rows: 0;
- silently grouped normative Work Item fields: 0;
- NOT_APPLICABLE_WITH_JUSTIFICATION: exactly 1, baseline 29.12 historical Issue #53 compatibility rule.

---

# Appendix B — Accepted Android evidence provenance

This appendix preserves provenance without making Issue #2 an execution dependency.

Accepted evidence used conceptually includes:

1. Android Candidate 4
   - risk-tiered portable Android workflow;
   - host verification;
   - Android environment contract;
   - device evidence risk classifier;
   - provider-neutral device adapter;
   - signing/release separation.

2. Common Governance Core
   - six-field Work Item;
   - Semantic Scope + Path Scope;
   - exact-SHA Supervisor review;
   - formal decision vocabulary;
   - same-objective REWORK;
   - SEMANTIC_ACCEPTED != MERGE_ELIGIBLE;
   - PUBLISH = HUMAN ACTION;
   - GitHub recovery;
   - HARD VETO.

3. External Actor Interface
   - TECHNICAL CAPABILITY != WORKFLOW AUTHORITY;
   - durable GitHub activity;
   - request → authority → execution → evidence → result → stop/escalation;
   - actor does not self-approve, merge, or publish.

4. Platform Deltas
   - Gradle/JDK/Android SDK build boundary;
   - emulator/physical-device verification;
   - Android signing;
   - APK/AAB/store distribution;
   - Firebase/Test Lab optional;
   - no forced iOS/Web symmetry.

5. Adversarial Audit
   - publication-authority false negative history preserved;
   - exact Human publication invariant restored;
   - evidence cannot override authority.

6. Architecture package accepted in Issue #8
   - standalone document requirement;
   - source precedence;
   - lossless derivation;
   - complete baseline matrix;
   - Android-first exemplar;
   - short BUILD → REVIEW → focused REWORK closure loop.

---

# Result

This workflow operationalizes Android using the full inherited lifecycle plus Android-specific justified adaptation.

Normal execution is:

Human
→ Supervisor
→ bounded GitHub Work Item
→ Implementer bootstrap
→ Android environment/context reconstruction
→ bounded implementation
→ host verification
→ device/emulator evidence when risk requires
→ evidence bundle
→ REPOSITORY_PUBLICATION
→ Implementer handoff
→ Supervisor exact-SHA review
→ SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE
→ separate MERGE_ELIGIBLE checks
→ merge only with authority
→ PUBLISH only by Human action
→ durable recovery from GitHub

The document remains:

PROPOSAL — NOT CANONICAL

until a separate authorized adoption decision changes that status.
