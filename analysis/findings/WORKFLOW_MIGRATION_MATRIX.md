# WORKFLOW MIGRATION MATRIX — Issue #85

Status: PREPARATION_ONLY
Allowed migration classes: PRESERVE / ADAPT / EXTEND / NOT_APPLICABLE_WITH_JUSTIFICATION.

| Material domain | Current project workflow | ANDROID_WORKFLOW / Unity profile | Class | Migration requirement |
|---|---|---|---|---|
| Human authority | Product intent, priorities, exceptional decisions, publication | Human retains product/material/cost/credential/publication authority | PRESERVE | No authority transfer. |
| Supervisor authority | Defines/scopes/reviews; exact-SHA semantic decision; project-specific merge authority after checks | Same semantic authority; generic workflow requires separate merge authority | PRESERVE | Carry existing project merge authority explicitly; do not infer it from generic workflow. |
| Implementer | Reads bounded context, implements/tests/commits/pushes/PR; no self-approval | Same; stronger Android/readiness evidence rules | EXTEND | Add proportional Android/profile evidence duties when triggered. |
| Six-field Work Item | Objective, Acceptance Criteria, Authorized Scope, Relevant Sources, Verification, Base | Same six fields | PRESERVE | Keep as governing task contract. |
| Semantic Scope | Behavior authority | Explicit semantic boundary | PRESERVE | PATH PERMISSION != SEMANTIC PERMISSION. |
| Path Scope | File/module boundary | Explicit path boundary | PRESERVE | No path-only authority inference. |
| Exact-SHA review | Review applies only to reviewed SHA | Explicit exact-SHA invalidation | PRESERVE | Later SHA requires new semantic review. |
| REWORK continuity | Same objective continues same Issue/branch/PR normally | Same, with scope-changing rework STOP | PRESERVE | Preserve history; focused correction and new review. |
| Semantic decisions | SEMANTIC_ACCEPTED / REWORK / HOLD / ESCALATE | Same four states only | PRESERVE | No Android/profile semantic states. |
| CI/evidence | CI PASS is evidence, not approval | Same; build/device/actor output also evidence only | EXTEND | Add runtime evidence without semantic authority. |
| Merge eligibility | Separate from semantic acceptance | Same | PRESERVE | SEMANTIC_ACCEPTED != MERGE_ELIGIBLE. |
| Project-specific merge executor | Supervisor executes after eligibility under current authority | Generic workflow allows merge only under governing authority | ADAPT | Preserve this project-specific authority in project overlay/authority record at activation. |
| Product publication | Human action | Human action | PRESERVE | PUBLISH = HUMAN ACTION. |
| Research gate | RESEARCH_GATE + STRATEGIC_RATIONALE for mutable material facts | Research/Freshness Gate, proportional and material-only | ADAPT | Keep material-current-fact trigger; avoid broad research by default. |
| Recovery | GitHub/repo/Issue/branch/PR/docs, not chat | Expanded exact-SHA/environment/external-actor recovery tuple | EXTEND | Add only material Android/profile state. |
| Handoff | Brief exact branch/HEAD/PR/evidence/status | Structured Implementer handoff + optional profile additions | EXTEND | Use compact material fields; do not duplicate specs. |
| GitHub persistence | Repository is durable memory | Same | PRESERVE | GITHUB STATE > SESSION MEMORY. |
| AI_STUDIO_OPERATOR generic authority | Subordinate, no write, exceptional fallback | External actor is optional and capability-bound | ADAPT | Treat AI Studio as one possible actor-specific adapter, not governance class. |
| Historical AI Studio Issue #53 compatibility state | Current workflow contains project/history-specific handling | ANDROID_WORKFLOW explicitly does not import that historical state as general Android rule | NOT_APPLICABLE_WITH_JUSTIFICATION | Keep only as historical project evidence; reusable safety functions are covered generically. |
| AI Studio preview/materialization/request modes | Provider-specific operational protocol | Not required for generic external actor/local agent | NOT_APPLICABLE_WITH_JUSTIFICATION | Retain only if that provider is later invoked under separate authority. |
| External actor model | AI Studio-specific fallback plus project Astra practice | Generic EXTERNAL_ACTOR_ACTIVITY | ADAPT | Use one bounded activity per concrete missing capability. |
| Astra role | Local executor; no source decisions/writes; exact-SHA packets/results | EXTERNAL_ACTOR / LOCAL_EXECUTION_AGENT | ADAPT | No new authority class. |
| ASTRA_LOCAL_TEST_PACKET | Existing project-specific compact packet | LOCAL_TEST_PACKET | ADAPT | Rename/map fields; preserve exact SHA/test/protocol/evidence constraints. |
| Astra result | PASS/FAIL/BLOCKED + evidence | LOCAL_RESULT with PASS/FAIL/BLOCKED/NOT_RUN/STALE_RESULT/DUPLICATE_RESULT | EXTEND | Add materialized SHA/build/hash/change-required fields when material. |
| Failure taxonomy | Project uses blocker/result descriptions | Profile supplies diagnostic classes | EXTEND | Diagnostic class never becomes semantic decision automatically. |
| Stale evidence | Exact SHA already prevents silent carry-forward | Explicit STALE_RESULT | EXTEND | Mark stale when material identity changed. |
| Duplicate evidence | Project instruction says do not rerun valid evidence without cause | Explicit DUPLICATE_RESULT | EXTEND | Reuse durable equivalent evidence when tuple is unchanged. |
| Unity project identity | Project pins editor/config refs in Stage 2 | Profile adds explicit project identity pointers | EXTEND | Reference tracked ProjectVersion/ProjectSettings/packages; no universal editor pin in workflow. |
| Assets + .meta | #73 established required meta integrity | Profile makes tracked asset/.meta identity explicit | EXTEND | Preserve GUID identity; inspect tracked diff. |
| ProjectSettings | Stage 2 technical configuration source | Tracked project source/config state | EXTEND | Editor mutations remain scoped repository changes. |
| Package manifest/lock | Stage 2 requires manifest + generated/resolved lock | Profile treats them as dependency state | EXTEND | Exact resolution comes from project evidence, not profile constants. |
| Library/Temp/cache | No authority intended | Non-authoritative generated/cache by default | EXTEND | Do not commit caches merely for recovery. |
| Import side effects | Local execution can generate state | Profile requires exact SHA + diff inspection | EXTEND | Separate cache from tracked source/config change. |
| Android Build Support | Stage 2 bootstrap prerequisite | Environment fact, not timeless workflow constant | EXTEND | Record material installed state/version. |
| SDK/NDK/JDK | Stage 2 evidence pins | Environment facts with freshness gate | EXTEND | Project facts only; no copied universal versions. |
| Gradle/build path | Not yet fully resolved in Stage 2 | UNITY_DIRECT / EXPORTED_GRADLE / PROJECT_DEFINED | EXTEND | Record actual build path when execution resumes. |
| Local repository writes | Astra currently no-write | Local agent default REPOSITORY_WRITE=NO | PRESERVE | Repository correction returns to Implementer. |
| Device evidence | #74/#76 triggered only by actual needs | Physical device trigger is materiality/risk based | PRESERVE | No device requirement for every change. |
| Performance evidence | #75/#76 have explicit X46 requirements | Triggered by spec/AC/risk/maturity | PRESERVE | Project's 30 FPS/device criteria remain project specs, not workflow. |
| Playtest evidence | VUX future evidence where required | Triggered when experiential evidence is material | EXTEND | Project VUX requirements remain source of concrete criteria. |
| Build maturity | Current project has prototype/technical tranche semantics | Optional maturity labels | EXTEND | Labels choose evidence; do not create semantic state. |
| Prototype anti-bottleneck | Current Stage 2 avoids irrelevant work/reruns | Explicit anti-bottleneck rules | EXTEND | Do not inherit release-grade controls by default. |
| Santa/gates/boss/level | Project specifications | Profile explicitly excludes concrete game mechanics | NOT_APPLICABLE_WITH_JUSTIFICATION | Never migrate into workflow/profile. |
| 30 FPS / thermal acceptance | Project performance specification | Profile has no universal FPS/device threshold | NOT_APPLICABLE_WITH_JUSTIFICATION | Keep in project specs. |
| Device tier/budgets | MEASUREMENT_REQUIRED project state | Profile only defines evidence mechanics | NOT_APPLICABLE_WITH_JUSTIFICATION | Keep measurement-derived project facts. |
| VUX/content/UX | Current VUX/QA specifications | Profile explicitly excludes game/product UX | NOT_APPLICABLE_WITH_JUSTIFICATION | Keep current project/game specifications. |
| Current #73 evidence | Exact-SHA repository + review evidence | Compatible with exact-SHA/local-result model | PRESERVE | Do not discard/rerun unless source/material test identity changes. |
| Current #74 blocker | Exact-SHA accepted blocker | Compatible with external/device evidence model | PRESERVE | Resume only after prerequisites/authority. |
| Current #75 protocol | Accepted protocol, NOT_RUN | Compatible with performance evidence model | PRESERVE | Execute later; no old metrics exist. |
| Current #76 blocker | Device-selection blocker | Compatible with DEVICE_REQUIRED | PRESERVE | No emulator substitution by implication. |
| Current #77 blocker | Provenance/asset-selection blocker | Compatible with PROVENANCE_REQUIRED | PRESERVE | Profile cannot bypass provenance. |
| #83/#84 documentation gate | Exact-SHA DOCUMENTATION_GATE_ACCEPTED at f63b70a | Workflow document-consistency/readiness model | PRESERVE | No rerun merely due adoption preparation. |

## Astra-specific transition

PRESERVED:
- execution-only role;
- exact-SHA target;
- no architecture/product decision;
- no semantic approval;
- no git write by default;
- repository corrections return to Implementer;
- compact evidence and causal failure.

ADAPTED:
- ASTRA_LOCAL_TEST_PACKET -> LOCAL_TEST_PACKET;
- result schema -> LOCAL_RESULT;
- explicit EXTERNAL_ACTOR_ACTIVITY record;
- diagnostic failure class;
- TARGET_SHA/MATERIALIZED_SHA distinction where offline materialization is used.

SUPERSEDED-BY-PROFILE effect (implemented through ADAPT classification):
- ad-hoc local-result vocabulary where the profile supplies PASS/FAIL/BLOCKED/NOT_RUN/STALE_RESULT/DUPLICATE_RESULT;
- actor naming as a unique project authority notion. Astra becomes an instance of LOCAL_EXECUTION_AGENT, not a governance class.

DECISION_LATER:
None required for authority/lifecycle adoption. Future per-activity authorization is still required normally.

## Conflict check

No unresolved conflict was found in authority, lifecycle, exact-SHA semantics, merge eligibility, publication or formal semantic-state vocabulary.

ARCHITECTURE_DECISION_REQUIRED: NO.
