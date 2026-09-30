# Stage 2 Proposal — DO NOT EXECUTE IN STAGE 1
Dependency: Supervisor accepts #64/#65 GO. This file defines future Issues only; none are created/executed here.

## 2A — Unity/Android Bootstrap
Objective: create minimum technical project, no product gameplay.
Pin exact Unity 6.3 LTS stable patch; project manifest/packages-lock; URP; Input System; Android module/config; landscape; min/target API; ABI; Vulkan/GLES ordering based on pinned evidence; Development Build and instrumentation baseline.
Acceptance: reproducible editor/package/toolchain/config record; empty/synthetic scene opens; no product systems/assets.

## 2B — Android Smoke Build
Depends 2A.
Objective: minimal Development APK solely to validate toolchain/config on physical Android; no product gameplay.
Acceptance: build/install/launch evidence, device/OS/API/backend provenance, logs; failure documented reproducibly.

## 2C — Performance / Architecture Spike
Depends 2A; 2B should validate target toolchain first.
Objective: execute X46-01 crowd, X46-02 render/animation, X46-03 physics/destruction, X46-04 lifecycle/pooling with synthetic workloads only.
Acceptance: raw captures, environment/procedure, comparative results, evidence-backed backend/lifecycle decisions and measurement-derived initial capacity/resource observations. No production gameplay.

## 2D — Device / Thermal Baseline
Depends 2B + representative lower device selection + representative sustained synthetic workload from 2C.
Objective: X46-05.
Acceptance: named device/environment/protocol/raw thermal+frame evidence; evaluate frozen 30 FPS/no-collapse criteria.

## 2E — Asset / Load Spike
Depends exact representative asset snapshots passing provenance/originality gate; can follow 2A and run independently of 2D.
Objective: X46-06 using bounded representative assets, not production level.
Acceptance: exact provenance, load/memory/render evidence, no wholesale asset import or identity adoption.

Each must be a separate Issue→branch→evidence→PR→READY_FOR_REVIEW. Do not combine into product vertical-slice implementation.
