# Persistent Research Protocol

## 1. Source of truth
Conversation is temporary. GitHub repository content, Issues, branches, commits, PRs, source records, `research/RESEARCH_STATE.md`, and `workflow/research/SESSION_HANDOFF.md` are persistent evidence.

## 2. Session bootstrap
At each session:
1. identify repository and default branch;
2. read Issue #1 and the active Work Item completely;
3. enumerate Issues #2–#18 and their dependency state;
4. inspect open PRs and active branch/HEAD;
5. read root/research/source indexes;
6. read RESEARCH_STATE and SESSION_HANDOFF;
7. inspect recent relevant commits;
8. identify the next authorized, dependency-satisfied Work Item.

Before research, reconstruct objective, Acceptance Criteria, Semantic Scope, Path Scope, base, relevant sources, prior work, dependencies, missing evidence, and required outputs. If a material element cannot be reconstructed, stop as BLOCKED.

## 3. Work-item execution
Work only inside the Issue's Authorized Scope. Research first; persist evidence and provenance; update authorized indexes/state/handoff; verify; commit/push through GitHub; open/update PR. Do not merge or self-approve.

## 4. Evidence labels
- **VERIFIED FACT** — directly established by primary evidence.
- **SOURCE CLAIM** — assertion made by a cited source, not independently established.
- **CODE OBSERVATION** — behavior/structure directly observed in pinned source code.
- **INFERENCE** — conclusion derived from evidence; derivation must be stated.
- **HYPOTHESIS** — testable proposition requiring validation.
- **UNKNOWN** — material fact not established by available evidence.

## 5. External source records
Record as applicable: SOURCE ID, TITLE, AUTHOR/OWNER, SOURCE TYPE, URL, DATE ACCESSED, VERSION, REPOSITORY, COMMIT SHA, PATH, CLASS, METHOD, LICENSE, RELEVANT CLAIMS, NOTES. Prefer original code, official repositories/docs/specifications/release notes/papers before secondary/community sources.

## 6. Repository analysis
README-only review never qualifies as repository analysis. Pin repository/ref/SHA; determine license; inspect tree/configuration/scenes/prefabs/scripts; read relevant classes/methods; reconstruct execution flow where applicable; record architecture, dependencies, algorithms, performance strategy, limitations, and reuse implications.

## 7. Licensing
GitHub availability is not reuse permission. Record license source and permissions/restrictions. If license cannot be verified, classify `UNKNOWN_LICENSE` and do not copy/adapt code as reusable material.

## 8. Research Gate
Before a material decision dependent on mutable external technology, create a DRAFT strategic rationale containing work item, decision point, need for current research, constraints, current evidence, options, proposed approach, rationale, risks/uncertainties, and `SUPERVISOR VERIFICATION: PENDING`. Never mark it approved autonomously.

## 9. Experiments
When evidence cannot resolve a technical alternative, specify a reproducible experiment rather than inventing results. Record question, hypothesis, alternatives, environment, Unity version, target/device, scene, unit counts, measurements, profiler, procedure, success criteria, raw-results location, and conclusion only after execution.

## 10. Verification and handoff
Check scope, links, provenance, evidence labels, licensing classifications, and dependency state. Record branch, base SHA, reviewed HEAD SHA, PR, changed files, sources, findings, open questions/blockers, next Work Item, and exact next action. A handoff's reviewed HEAD may be the parent of the final metadata-only handoff commit; the PR's head is authoritative for the latest branch SHA.
