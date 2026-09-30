> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Comparative Consolidation

Work Item: #12

## Evidence convergence
1. **Control**: primary Top Lords evidence supports simple lateral swipe/path choice, but exact lane model is UNKNOWN.
2. **Crowd**: comparable code evidences centralized loops, per-agent updates, slots/formation targets, NavMesh, grid fields, steering/boids and local/global neighbor searches.
3. **Mutation**: REP-001 evidences preallocated activation/deactivation and arithmetic gates; Unity supports triggers/pools/Instantiate, but target semantics remain a product specification.
4. **Combat**: primary evidence confirms enemies/heroes/army framing but not proprietary targeting/damage/boss algorithms. Target design must be original.
5. **Performance**: no target-device benchmark exists; all performance winners remain unproven.
6. **Authoring**: structured data assets and modular level definitions are supported by Unity capabilities and improve traceability, but exact package/tool choice is pending.
7. **Progression**: storefront supports resources/territory/taxes/heroes/griffin at concept level; exact economy is proprietary/UNKNOWN and must be independently specified.

## Contradictions/tensions
### C-001 organic crowd vs deterministic formation
Steering/boids favor organic local motion; slot formations favor deterministic visual topology. Resolution candidate: layered model (authoritative slots + bounded local correction), subject to experiment.

### C-002 per-unit simulation vs aggregate scalability
Individual health/target/Animator/physics increases fidelity and state cardinality; aggregate army models can reduce work but may undermine hero/combat readability. Requires performance/product constraints.

### C-003 pooling speed vs retained memory
Unity guidance and code evidence show both benefits and retained-memory cost. Pool capacity cannot be chosen without target unit counts/device memory.

### C-004 packaged systems vs custom runner-specific systems
NavMesh/Cinemachine/Input System reduce custom infrastructure but introduce mutable package/API dependencies and may exceed needs. Research Gate required.

### C-005 inspiration vs cloning
Top Lords storefront defines high-level product reference but not algorithms/content/balance. Specifications must preserve genre mechanics while creating original combat/economy/content and never claim proprietary internals.

## Material gaps
GAP-001 target Unity supported release/package versions.
GAP-002 target device tiers and performance budgets.
GAP-003 maximum simultaneous visual/logical army sizes.
GAP-004 exact original-product combat rules/boss requirement.
GAP-005 exact metagame scope/economy values.
GAP-006 accessibility/localization targets.
GAP-007 whether cloud/backend persistence is in scope.
GAP-008 measured performance experiment results.
These gaps do not prevent writing specifications when represented as constraints/TBD requiring Supervisor decisions, but they prevent pretending final architecture/performance acceptance.

## Candidate technical direction for specification
**PROPOSED / not approved:**
- input intent abstraction with touch implementation;
- logical army state separated from visual representation;
- deterministic formation slots with lightweight local correction as baseline hypothesis;
- idempotent gate transaction mutating logical count;
- lifecycle abstraction permitting pool/preallocation;
- explicit combat state/target/damage/death contracts independent of animation;
- data-driven modular levels;
- versioned local persistence;
- profiling-first performance acceptance.

This direction is selected as a coherent specification baseline, not as a claim that alternatives have been benchmarked superior.

## Traceability seeds
- INPUT: TL-001/002 -> #6 -> candidate input intent.
- CROWD: REP-002..006 -> #5/#6 -> formation/movement comparison.
- GATE: REP-001 + UNITY-004/005/006 -> #7.
- COMBAT: TL-001/002 + #8 explicit unknowns -> original target/combat specification.
- PERF: UNITY-003/007..010 + REP observations -> #9 experiments/RG.
- LEVEL: TL + UNITY-011..013 -> #10.
- DATA: TL + UNITY-014..016 + REP-001 -> #11.
