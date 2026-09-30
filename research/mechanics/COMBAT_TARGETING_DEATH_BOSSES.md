# Combat, Targeting, Death and Bosses

Work Item: #8

## Observable evidence boundary
**SOURCE CLAIM (TL-001/TL-002):** publisher storefronts state swipe-to-dodge/charge, army growth, instant annihilation wording for enemies, heroes with distinct roles/abilities, and a griffin. They do not expose damage equations, targeting algorithms, boss state machines, aggro rules or death implementation.

**UNKNOWN:** exact Top Lords combat tick, target priority, damage formula, boss mechanics and victory calculation. Secondary web guides discovered during research make detailed claims but are not treated as verified primary evidence because their provenance/method is insufficient.

## Army-vs-army engagement models
### Contact/front-line attrition
Units engage when opposing envelopes/fronts overlap; nearest/front-most pairs resolve attacks.
- predictable runner readability;
- requires congestion/slot rules;
- can avoid global target search if pairing is local.

### Radius-based autonomous targeting
Each attacker queries candidates within acquisition range and selects by policy.
- supports melee/ranged roles;
- query structure dominates scaling; physics overlap/spatial partition/direct lane lists are alternatives.

### Lane/slot pairing
Targeting is constrained by lane/front slot.
- deterministic and cheap structurally;
- less organic; lane semantics are not verified for Top Lords.

### Aggregate army resolution
Logical army-vs-army state computes attrition while visuals represent outcomes.
- potentially scalable for very large counts;
- individual combat readability/hero abilities need separate presentation.
- **HYPOTHESIS**, not yet selected.

## Target-selection policies
Candidates for comparison: nearest distance; nearest-forward; current-target stickiness; lowest health; role priority; deterministic slot opponent; boss override. Product policy must specify tie-breakers and retarget conditions.

**INFERENCE:** target stickiness/hysteresis is desirable to prevent oscillation when multiple enemies have nearly equal priority, but its threshold is unmeasured.

## Attack/damage lifecycle candidate
`acquire -> validate range/state -> windup -> attack event -> damage -> health/state transition -> death -> release target/slot -> retarget`.

Candidate correctness requirements:
- one authoritative health/damage state;
- dead units cannot receive new targets/attacks;
- attack cancellation semantics defined for target death/out-of-range;
- damage event ordering deterministic enough for reproducible tests;
- presentation animation must not be sole authority for damage;
- death releases formation/combat occupancy exactly once.

## Death representation alternatives
1. immediate deactivate/return-to-pool;
2. death presentation then pool return;
3. lightweight corpse/ragdoll replacement;
4. aggregate disappearance for distant/large crowds.

No option is selected. Ragdoll/physics cost belongs to #9.

## Boss encounter model alternatives
A. single high-health target + telegraphed attacks;
B. phased boss state machine;
C. boss + adds/waves;
D. endpoint army-strength check with boss presentation.

**UNKNOWN:** which, if any, matches Top Lords. Storefront evidence only establishes enemies/heroes/griffin, not boss internals.

Candidate boss contract (**INFERENCE**): encounter owns phase/state; attacks expose telegraph/active/recovery windows; damageability and victory conditions are explicit; army deaths continue through normal death lifecycle; boss-specific logic does not bypass authoritative result accounting.

## Victory/result alternatives
- all required enemies dead;
- boss dead;
- army reaches endpoint with survivors;
- objective state satisfied.

Result must snapshot survivors/reward inputs once and prevent post-result combat mutation. Exact target rule is UNKNOWN until level/progression research.

## Candidate requirements
COMBAT-CAND-001 Target acquisition SHALL define candidate query, priority, deterministic tie-break and invalidation.
COMBAT-CAND-002 Damage/health SHALL have a single authoritative model independent of animation.
COMBAT-CAND-003 Death SHALL be idempotent and release target/formation/lifecycle ownership once.
COMBAT-CAND-004 Result transition SHALL freeze/snapshot authoritative combat outcome once.
BOSS-CAND-001 Boss behavior, if used, SHALL expose explicit state/phase and victory semantics.
TEST-CAND-008 Simultaneous lethal damage, mutual kills, target death during windup, pooled-object reuse and result/death same-frame ordering require tests.

## Edge cases
- attacker and target die same simulation step;
- target leaves range during windup;
- pooled target instance reused while stale reference exists;
- multiple attackers kill same target;
- no valid target;
- target hidden/disabled;
- formation mutation during combat;
- gate and combat overlap;
- boss phase changes on lethal threshold;
- final unit and final enemy die together;
- pause/time-scale during telegraph;
- result emitted twice;
- reward computed before all death events settle.

## Proposed experiment EXP-COMBAT-001
QUESTION: target-query scaling for representative army-vs-army contact.  
ALTERNATIVES: physics overlap per unit; uniform spatial grid; front/lane candidate lists; aggregate pairing.  
MEASUREMENTS: CPU, allocations, candidates examined, target stability/correctness.  
COUNTS/THRESHOLDS: derive later; no invented numbers.  
CONCLUSION: PROPOSED / NOT RUN.

## Proposed experiment EXP-COMBAT-002
QUESTION: cost/readability of death representation.  
ALTERNATIVES: immediate pool return; timed animation then pool; ragdoll subset; aggregate presentation.  
MEASUREMENTS: CPU/physics/rendering/GC, active-object lifetime, visual correctness.  
CONCLUSION: PROPOSED / NOT RUN.
