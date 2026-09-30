# RG-XMAS-01 — Gameplay / Loop

Issue #59
Status: PARTIAL — human-observable decisions remain PENDING.
Boss existence: CONFIRMED YES (Supervisor). This gate does not reopen yes/no.

## Santa health comparative evidence
### Pattern C — crowd as survival resource
**SOURCE CLAIM — Count Masters official App Store:** player grows warriors through gates, clashes with opposing crowd and defeats a final King/boss; storefront emphasizes crowd size and final battle, but does not establish a separate protagonist HP model.
**SOURCE CLAIM — Join Clash 3D official Google Play:** player gathers a crowd, obstacles can eliminate members, final clash/boss/castle follows. Storefront does not establish separate hero HP.
**INFERENCE:** crowd-runner references support a model where preserving crowd is the dominant survival/combat resource. They do not prove that Santa should have no health.

### A — hearts/lives
No primary comparable crowd-runner evidence found in this pass establishing hearts as the relevant protagonist model. **UNKNOWN** for direct genre precedent.
Pros: discrete/readable; easy recovery pickup. Risks: introduces a second resource beside army; each heart value would be arbitrary until authored/tested.

### B — health bar
General action-game convention; no direct primary crowd-runner evidence in this pass requiring it. **HYPOTHESIS:** useful for boss telegraph/damage readability if Santa personally fights. Risks: duplicates army attrition and creates tuning/recovery semantics.

### C — army protects Santa
Directly aligned with observable crowd preservation in Count Masters/Join Clash. Candidate semantics: ordinary hazards/combat remove helpers first; Santa becomes vulnerable only at zero helpers or in explicitly authored boss attacks.
Pros: one dominant resource; reinforces gates. Risks: zero-army state/solo recovery must be defined; Santa can feel visually consequence-free.

### D — hybrid
Candidate: army absorbs normal attrition; Santa has a small discrete life/health layer for direct boss/hazard attacks.
Pros: supports boss-specific threat while preserving crowd loop. Risks: two resources/HUD/tuning and ambiguous damage routing.

## Recommendation
**RECOMMENDATION / PENDING HUMAN DECISION:** choose **C (army protection)** as simplest baseline unless boss design requires direct Santa damage; then evaluate **D hybrid**. Do not invent HP/hearts. This changes observable behavior and therefore cannot be promoted to CONFIRMED by this agent.

## Damage/defeat/victory alternatives
PENDING choice:
- normal obstacle/enemy damage: helpers-first vs Santa-direct vs authored damage channel;
- zero army: immediate defeat vs Santa solo vulnerable state vs recovery window;
- Santa direct lethal condition: only if B/D selected;
- victory: boss defeated + result emitted exactly once (boss existence confirmed);
- defeat: selected Santa/army condition, exactly once.
Recommendation: boss defeat is final victory condition for the prototype stage containing boss; placement still PENDING.

## Boss structure
Boss must exist. Alternatives:
1. **single-phase telegraphed boss:** small attack set + clear vulnerability windows; lowest content/state complexity.
2. multi-phase boss: stronger demonstration, additional animation/VFX/QA.
3. boss + adds: directly exercises army combat but adds target/query/readability load.
4. hybrid phase/adds.
**RECOMMENDATION / PENDING:** single-phase telegraphed boss with army participation as baseline; add phase/adds only if RG-XMAS-02 content budget justifies it. Placement = final authored encounter of whichever scope is approved, not necessarily “level 3”.

## Gates
Operations remain PENDING. Research baseline from #39/#7: additive and multiplicative are easiest candidates to compare. Required before implementation:
- exact allowed operations;
- integer domain;
- rounding for any non-integer operation;
- min/max/cap/overflow;
- zero handling;
- duplicate trigger idempotency;
- simultaneous gate/death ordering.
No numeric values selected.

## Tools/weapons
PENDING. #40 candidates remain alternatives. Recommendation: select at most one combat tool + one obstacle-breaking verb for first implementation tranche; exact items require human decision and art gate.

## Combat/result
Confirmed high-level combat/result exists. Domain requirements retained from #8/#13: explicit authoritative damage/death, deterministic target/tie behavior, idempotent death/result. Exact target policy and damage numbers PENDING/technical after observable semantics.

## Decision table
| Decision | Status |
|---|---|
| boss exists | CONFIRMED YES |
| Santa health model | PENDING; recommend C, D fallback |
| numeric HP/hearts | UNKNOWN / do not invent |
| damage routing | PENDING |
| zero-army behavior | PENDING |
| boss placement | PENDING; final encounter of approved scope recommended |
| boss complexity | PENDING; single phase recommended |
| boss adds/phases | PENDING |
| victory | PARTIAL: boss defeat required in boss encounter; result semantics pending spec freeze |
| gate ops/rounding/caps | PENDING |
| tool/weapon set | PENDING |

## Verification to carry forward
Unit/domain tests for gate arithmetic boundaries/idempotency; damage routing; zero-army; simultaneous lethal; boss phase/vulnerability; exactly-once victory/defeat/result. Playtests for health-model comprehension and boss telegraph readability.

## Gate result
**RG-XMAS-01 = PARTIAL / PENDING HUMAN DECISIONS.**
No gameplay implementation authorized.
