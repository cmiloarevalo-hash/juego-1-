# Technical Specification — Christmas Prototype Freeze
Status: FROZEN baseline with explicit BOOTSTRAP_PIN values.

TECH-UNITY-001 [FROZEN] Unity 6.3 LTS family. [BOOTSTRAP_PIN] exact latest stable patch selected and recorded at bootstrap.
TECH-RENDER-001 [FROZEN] URP. [BOOTSTRAP_PIN] exact package version/manifest/lock matching pinned editor.
TECH-INPUT-001 [FROZEN] Unity Input System. [BOOTSTRAP_PIN] exact package version; touch/editor inputs map to normalized intent.
TECH-PLATFORM-001 [FROZEN] Android only; landscape.
TECH-ANDROID-001 [BOOTSTRAP_PIN] record min API, target API, ABI and exact graphics backend order from pinned Unity/toolchain evidence.
TECH-GFX-001 [FROZEN] Prefer Vulkan when validated; GLES3 fallback when supported by pinned baseline. Exact PlayerSettings = BOOTSTRAP_PIN.
TECH-TIME-001 [FROZEN] Define deterministic ordering for same-frame gate/damage/death/boss/result conflicts; terminal result prevents subsequent mutation.
TECH-ID-001 [FROZEN] Stage, gate, encounter and runtime-authoring entities needing idempotency use stable IDs.
TECH-LIFE-001 [FROZEN] Reused representations fully reset target/animation/slot/transient state before reacquire.
TECH-DEST-001 [FROZEN] Obstacle destruction baseline uses authored state/mesh swap/pre-broken representation; runtime mesh fracture OUT_OF_SCOPE.
TECH-LOG-001 [FROZEN] Development/spike builds expose counters/profiler markers for logical units, active representations, lifecycle, query candidates, boss/result transition identity.
TECH-BUILD-001 [FROZEN] Bootstrap establishes reproducible package manifest/lock and Android Development Build configuration before performance spike.
TECH-PERSIST-001 [OUT_OF_SCOPE] strategic progression/economy/cloud backend. Minimal local settings may be implemented only if needed by localization/audio/control preferences.
