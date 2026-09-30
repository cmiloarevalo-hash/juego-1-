# SPEC FREEZE MATRIX — Christmas Prototype
Issue #64. Authority decision: Issue #57 comment 5914691381, 2026-09-30.

| Requirement | Decision source | Spec/component | Verification | Status |
|---|---|---|---|---|
| Android APK / runner / Christmas / Santa/helpers / ES+EN | #57 + comment 5914691381 | SRS-PROD-* / Run+Presentation+Localization | VER-BUILD/LOC | FROZEN |
| one village/workshop vertical slice | comment 5914691381 RG-02 | SRS-SCOPE/LOOP, GAME-STAGE | loop coverage | FROZEN |
| Santa army-protection; zero=defeat | comment RG-01 | SRS-HEALTH, GAME-HEALTH/DEFEAT / Army+Run | VER-ZERO/ARMY | FROZEN |
| +N / ×N positive integers, idempotent | comment RG-01 | SRS-GATE, GAME-GATE / Gate Resolver | VER-GATE-* | FROZEN |
| numeric army cap | comment RG-01/RG-04 | GAME-CAP/PERF-004 / instrumentation | VER-CAP | MEASUREMENT_DERIVED |
| hammer authored destruction | comment RG-01 | SRS-OBS/TOOL, GAME-HAMMER | VER-HAMMER | FROZEN |
| snowball ranged combat | comment RG-01 | SRS-TOOL, GAME-SNOW / Combat | VER-SNOW/COMBAT | FROZEN |
| one-phase final boss, no adds | comment RG-01 | SRS-BOSS, GAME-BOSS / Boss | VER-BOSS/VICTORY | FROZEN |
| exactly-once result | comment RG-01 | SRS-RESULT/GAME-RESULT / Run+Result | VER-VICTORY/DEFEAT | FROZEN |
| low-poly toy-workshop/diorama/originality | comment RG-03 | SRS-ART/ORIG / Presentation | VER-ORIG/MOBILE | FROZEN |
| Unity 6.3 LTS + URP + Input + Android landscape | comment RG-04 | TECH-* | VER-BUILD | FROZEN |
| exact patch/packages/API/ABI/backend order | comment RG-04 | TECH BOOTSTRAP_PIN | VER-BUILD | BOOTSTRAP_PIN |
| 30 FPS lower representative device | comment RG-04 | PERF-001 | VER-PERF | FROZEN acceptance |
| no sustained thermal collapse | comment RG-04 | PERF-002 | VER-THERM | FROZEN acceptance; protocol values measurement-derived |
| 60 FPS | comment RG-04 | PERF-003 | VER-60 | NON_BLOCKING_STRETCH |
| CPU/GPU/memory/capacity | comment RG-04 | PERF-004/005 | VER-CAP/X46 | MEASUREMENT_DERIVED |
| game-specific code NEW | comment RG-05 | SRS-REUSE / all game domains | provenance + implementation review | FROZEN |
| fracture/SST | comment RG-05 | reuse policy | VER-PROV | REFERENCE_ONLY |
| Kenney/Poly Haven | comment RG-05 | asset boundary | VER-PROV/ORIG | ADAPT_ELIGIBLE after snapshot |
| Mixamo/other conditional | comment RG-05 | asset boundary | VER-PROV | BLOCKED until exact terms/item |
| kingdom/metagame/economy | #57/comment | DATA + SRS | audit grep | OUT_OF_SCOPE |
| stages 2/3, forest, ice fortress | comment RG-02 | SRS/DATA | audit grep | DEFERRED |
| stage duration/tuning numbers | comment RG-02 | GAME-STAGE/TUNING | playtest | MEASUREMENT_DERIVED/TUNABLE |

## Consistency check
Search targets reviewed conceptually against all frozen specs:
- PENDING/TBD: none required for material product semantics.
- UNKNOWN: none required before Bootstrap/Spike.
- boss OPTIONAL: removed from active frozen specs.
- metagame/kingdom/economy: only explicit OUT_OF_SCOPE references.
- runtime fracture: explicit OUT_OF_SCOPE.
- exact engine/package/API values: BOOTSTRAP_PIN, not human PENDING.
- numeric performance/capacity: MEASUREMENT_DERIVED, no fabricated values.

## Cold handoff #64
A repository-only agent can determine product/scope/gameplay/out-of-scope/deferred/measurement-derived/technical baseline/bootstrap pins/reuse policy/tests without inventing a material product decision. Exact tuning remains data/playtest and exact runtime backend remains authorized spike evidence.

**RESULT: PASS. SPECIFICATION STATUS: FROZEN / READY_FOR_REVIEW.**


## Issue #83 documentation-readiness clarification
The #64 statement that no material PENDING/TBD/UNKNOWN decision was required **before technical Bootstrap/Spike** remains valid for that bounded technical tranche. It was not a claim that final product-facing visual/UX/content quality was fully specified. Issue #83 now makes those later product-readiness gaps explicit in `VISUAL_UX_CONTENT_SPECIFICATION.md`, `QUALITY_ACCEPTANCE_SPECIFICATION.md`, and the Blocking Gap Register. Those gaps do not retroactively change frozen mechanics; they block affected product presentation/content implementation until resolved.
