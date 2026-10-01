# PROJECT WORKFLOW OVERLAY

Status: PROJECT-SPECIFIC OPERATIONAL RULES TO PRESERVE THROUGH ADOPTION  
Applies with the project workflow authority. It does not replace ANDROID_WORKFLOW and does not grant new authority.

## 1. Implementer checkout / bootstrap / recovery

During normal Implementer bootstrap or recovery:

- reuse the existing checkout/workspace supplied by the authorized implementation channel;
- verify repository cwd;
- verify expected origin;
- verify git status;
- verify current HEAD;
- verify current branch;
- verify required Base;
- git fetch origin may be used to refresh remote refs;
- git clone is NOT normal bootstrap or recovery;
- do not create a second clone by initiative;
- do not reconstruct, copy, or move the repository into another workspace by initiative;
- do not work from an alternate or unverified origin.

If no usable/verifiable checkout exists:

STOP → Supervisor

RESULT:
BLOCKED

CLASSIFICATION:
IMPLEMENTER_ENVIRONMENT

REASON:
CANONICAL_CHECKOUT_UNAVAILABLE

Exceptional clone recovery requires explicit Supervisor authorization after determining that no usable/verifiable checkout exists.

This rule is PRESERVED from the current canonical project workflow and must remain durable independently of that workflow later becoming historical.

## 2. Project merge semantics

- Supervisor semantic review is exact-SHA.
- SEMANTIC_ACCEPTED != MERGE_ELIGIBLE.
- Implementer cannot merge.
- Merge execution remains governed by existing project authority and only after eligibility/integration checks.
- Generic ANDROID_WORKFLOW does not itself grant project merge authority.
- A later commit after semantic review requires a new exact-SHA semantic decision before it can inherit acceptance.
- Product publication remains Human action.

## 3. Scope

This overlay preserves project-specific operational deltas only.

It does not:
- override Human/Supervisor authority;
- override the active Work Item;
- override ANDROID_WORKFLOW lifecycle semantics;
- override current project/game specifications;
- activate ANDROID_UNITY_GAME_PROFILE by itself;
- grant local/external actor authority;
- authorize Stage 2, gameplay, merge, or publication.
