# Gates, Spawning and Army Mutation

Work Item: #7

## Evidence
**SOURCE CLAIM (TL-001/TL-002):** Top Lords storefronts describe path choices that can grow the army. Exact proprietary gate algorithm is not exposed.

**CODE OBSERVATION (REP-001):** `Hesaplama.AdamYönetimi/Degistir` applies x/+/%/- operations to a pre-existing GameObject roster using activation/deactivation and enforces a minimum one active unit in the inspected implementation.

**VERIFIED FACT (UNITY-005):** trigger callbacks are an available Unity mechanism for detecting overlaps; exact callback timing/configuration depends on physics setup/version.

**VERIFIED FACT (UNITY-004/006):** Unity documents runtime Instantiate/Destroy and pooling; pooling trades creation/GC pressure for retained live memory and requires workload-specific sizing.

## Gate operation model alternatives
1. **Additive**: N' = N + k.
2. **Subtractive**: N' = N - k.
3. **Multiplicative**: N' = N * k.
4. **Percentage/scalar**: implementation semantics must be explicitly defined; REP-001 contains a '%' operation but that repository is not authoritative for target product semantics.
5. **Set-to / clamp / bonus gates**: possible genre variants, but not evidenced as required for target; remain optional/UNKNOWN.

Candidate arithmetic invariants (**INFERENCE**):
- operation input and rounding rule must be deterministic;
- minimum/maximum army size policy must be explicit;
- overflow must be prevented;
- one gate must not apply multiple times due to multiple member colliders;
- gate consumption state must be idempotent per run;
- visual displayed operation must equal applied operation;
- mutation result must be observable before subsequent combat if gameplay ordering requires it.

## Detection ownership alternatives
A. Leader/player collider enters trigger and gate applies once to army model.
B. Army envelope/proxy collider enters trigger.
C. Individual members enter trigger and a gate aggregates/guards duplicate application.

Comparison: A/B make idempotency simpler and decouple gate logic from member count; C can create partial-crossing behavior but requires strict duplicate/ordering semantics. No evidence requires C.

## Spawn/despawn lifecycle alternatives
### Preallocated roster + activation
Evidence: REP-001.
Pros: no runtime instantiate for growth within capacity; stable object identity/slot pool.
Costs: retained memory; hard capacity; initialization cost.

### Generic object pool
Evidence: UNITY-006 ObjectPool API and UNITY-004 guidance.
Pros: reusable instances, configurable active/inactive lifecycle.
Costs: capacity/sizing/reset correctness; pool can still instantiate when empty depending implementation.

### Instantiate/Destroy on mutation
Evidence: REP-004/006/007 demonstrate runtime Instantiate; UNITY-004 describes allocation/GC tradeoff.
Pros: simplest ownership/lifetime.
Costs: workload-dependent allocation/initialization/destruction overhead; unsuitable conclusion cannot be asserted without profiling.

### Data-only logical members + rendered representatives
**HYPOTHESIS:** army count/state can be decoupled from one-GameObject-per-logical-unit for very large counts. This is not evidenced as necessary and belongs to #9/#12 evaluation.

## Formation mutation sequence candidate
**INFERENCE:** a robust transaction boundary is:
`Gate detected -> validate gate/run state -> compute new logical count -> clamp/validate -> acquire/release representations -> update slot topology -> assign/reassign targets -> settle formation -> emit mutation feedback`.

This is a candidate model for specification, not product code.

## Edge cases requiring explicit specification
- N=1 and subtractive gate.
- multiplication by zero/negative values.
- fractional/percentage rounding.
- integer overflow / configured maximum.
- two gates overlapping or crossed in same simulation step.
- gate hit after already consumed.
- reset/retry restoring gate and army state.
- growth larger than available pool capacity.
- shrink while units are in combat/death transition.
- gate crossing while formation is compressed/turning.
- member spawned inside obstacle/other collider.
- simultaneous despawn and target assignment.
- visual count and logical count divergence.
- pause/time-scale effects on trigger/settle animation.
- scene unload or run abort during pending pool returns.

## Candidate requirements (not yet normative)
GATE-CAND-001 Gate application SHALL be idempotent per gate instance per run.
GATE-CAND-002 Arithmetic SHALL define integer domain, rounding, min/max and overflow behavior.
ARMY-CAND-001 Logical army count SHALL be authoritative over presentation objects.
ARMY-CAND-002 Representation lifecycle SHALL support deterministic acquire/release/reset.
FORM-CAND-001 Formation SHALL recompute/repair slot assignment after count mutation without orphaned active units.
TEST-CAND-001 Verification SHALL cover every edge case above and compare logical count, active representation count and displayed count.

## Unknowns
Exact Top Lords gate formula set, rounding, minimum count, maximum count, collision ownership and pooling strategy are UNKNOWN. They must not be reverse-engineered from storefront behavior.
