# Performance Specification — Christmas Prototype Freeze
Status: FROZEN acceptance semantics; numeric resource budgets are MEASUREMENT_DERIVED.

PERF-001 [FROZEN] Prototype acceptance target is stable 30 FPS on the selected lower representative Android target device under defined representative workload.
PERF-002 [FROZEN] Sustained test SHALL show no sustained thermal collapse under its defined duration/workload. Exact device/thermal threshold and duration are measurement/test-protocol derived and must be recorded before claim.
PERF-003 [NON_BLOCKING_STRETCH] Observe 60 FPS capability; failure to sustain 60 alone does not fail baseline.
PERF-004 [MEASUREMENT_DERIVED] Maximum army/crowd capacity.
PERF-005 [MEASUREMENT_DERIVED] CPU budget, GPU budget, memory ceiling and detailed thermal thresholds.
PERF-006 [FROZEN] Claims require named physical device, SoC/GPU/RAM/OS/API/build/backend/profiler and raw capture provenance.
PERF-007 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-01 crowd update compares synthetic backend alternatives without changing gameplay semantics.
PERF-008 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-02 rendering/animation.
PERF-009 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-03 physics/destruction using baseline authored swap/pre-broken strategy plus relevant comparison.
PERF-010 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-04 lifecycle/pooling.
PERF-011 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-05 device/thermal after representative device selection.
PERF-012 [AUTHORIZED_FOR_FUTURE_SPIKE / NOT_RUN] X46-06 asset/load after representative asset selection.
PERF-013 [FROZEN] Backend decision (ECS/Jobs/central/GameObject/etc.) remains evidence-driven until X46 results; no architecture winner is implied by this freeze.
PERF-014 [FROZEN] No benchmark result exists at freeze. Editor-only results cannot establish Android acceptance.
