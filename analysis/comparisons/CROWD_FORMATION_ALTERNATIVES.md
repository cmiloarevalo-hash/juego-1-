# Comparison — Crowd and Formation Alternatives

Work Item: #6

| Alternative | Behavioral fit | Implementation complexity | CPU/memory evidence | Determinism | Mobile suitability | Dependencies | Evidence/limits |
|---|---|---|---|---|---|---|---|
| NavMesh per unit | independent routing | medium | target-scale UNKNOWN | medium | requires benchmark | Unity navigation | REP-005 demonstrates integration, not target-scale performance |
| leader + offsets | coherent formation | low-medium | simple target math; backend cost UNKNOWN | high if assignment stable | plausible; benchmark | custom + movement backend | REP-005 grid-point evidence |
| slot/grid + reassignment | explicit formation topology | medium-high | assignment-dependent | high with stable policy | plausible | custom | REP-005; reassignment cost unmeasured |
| steering/boids | organic local response | medium-high tuning | all-pairs variants structurally expensive; no target numbers | medium/low by default | depends on spatial partition | custom/jobs optional | REP-002/004/006 |
| shared field/grid | common-goal crowd flow | high | shared field amortization plausible; unbenchmarked | high with fixed update | depends on grid/update | custom grid | REP-003 |
| lightweight kinematic | runner-specific control | medium-high custom | explicit workload but unbenchmarked | high if fixed policy | candidate | custom | inferred from comparable patterns |
| ECS/DOTS | data-oriented mass update | high ecosystem complexity | no program benchmark/evidence yet | design-dependent | UNKNOWN | current Unity Entities/Burst/Jobs | RESEARCH_GATE required before material choice |

## Proposed experiment EXP-CROWD-001
QUESTION: Which movement/formation strategy meets target behavior with acceptable mobile CPU, memory and frame stability?  
HYPOTHESIS: slot targets + lightweight kinematic movement with spatially bounded separation will reduce per-unit overhead relative to per-agent navigation while preserving runner formation readability.  
ALTERNATIVES: NavMesh-per-unit; slot+kinematic; slot+steering; shared-field+local steering. ECS/DOTS only after a Research Gate establishes current package relevance.  
ENVIRONMENT: exact Unity version to be fixed by architecture Research Gate; development build and profiler-connected representative mobile devices.  
SCENE: identical straight/curved corridor, obstacles, width compression, gate growth/shrink and enemy-contact placeholder; identical visual load.  
UNIT COUNTS: parameter sweep; values must be selected from product requirements/device profiling, not invented here.  
MEASUREMENTS: main-thread/frame CPU, jobs time, GC alloc/frame, managed/native memory, physics/navigation time, formation error, collision/overlap count, settle time after mutation.  
PROFILER: Unity Profiler + Profile Analyzer; platform GPU profiler if rendering becomes confounding.  
PROCEDURE: warm-up; deterministic scripted input; repeated captures per alternative/count; record raw profiler captures under experiment results when executed.  
SUCCESS CRITERIA: thresholds come from approved Performance Specification; until then compare relative costs and correctness without declaring a winner.  
RAW RESULTS LOCATION: `analysis/experiments/EXP-CROWD-001/results/` when executed.  
CONCLUSION: NOT RUN / NO RESULTS.

## Proposed experiment EXP-CROWD-002
QUESTION: What neighbor-query strategy avoids all-pairs scaling while preserving local separation?  
ALTERNATIVES: all-pairs baseline; uniform spatial grid; physics overlap query; native spatial hash if justified.  
MEASUREMENTS: CPU, allocations, candidate-neighbor count, missed-overlap/correction error.  
PROCEDURE/SUCCESS: same target-device discipline as EXP-CROWD-001.  
CONCLUSION: NOT RUN / NO RESULTS.
