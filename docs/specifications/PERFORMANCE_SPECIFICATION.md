# Performance Specification

PERF-001 No numeric FPS/frame/memory/unit budget is approved yet; GAP-002/003 remain PENDING and SHALL be resolved before implementation acceptance.
PERF-002 Acceptance measurements SHALL run on named representative physical devices with OS/build/backend/profiler provenance.
PERF-003 CPU, GPU, memory, GC, rendering, animation and physics SHALL be profiled separately enough to identify bottleneck class.
PERF-004 Crowd movement SHALL execute EXP-PERF-001/002 or equivalent before committing to high-complexity ECS/DOTS.
PERF-005 Lifecycle SHALL compare preallocation/pooling/Instantiate baseline under representative mutation workload.
PERF-006 Rendering/animation SHALL compare representative art using EXP-PERF-004/005.
PERF-007 Physics design SHALL record broad/narrow interaction metrics and filter irrelevant layers.
PERF-008 Sustained mobile testing SHALL check frame-time degradation/memory growth/thermal behavior.
PERF-009 Raw captures/environment/procedure SHALL be retained for any claimed benchmark.

Evidence: #9, UNITY-003/004/007..010. Current experiment status: NOT RUN.
