# REUSE_MATRIX

Access date: 2026-09-30. This is technical provenance classification, not legal advice.

| ID | Source/ref | Relevant path(s) | License | Classification | Copy? | Modify? | Commercial? | Attribution/restrictions | Proposed destination | Rationale |
|---|---|---|---|---|---|---|---|---|---|---|
| REP-001 | RunControl/RunControlMain@`77ca6cf...` | Batu/Hesaplama gate/army scripts; BellekYonetim | UNKNOWN | **UNKNOWN_LICENSE** | NO | NO | UNKNOWN | license not verified | none | concepts/reference only; independently implement requirements |
| REP-002 | ALI-P48/CrowdSimulation@`4f81451...` | CrowdManager; SteeringAgent; Avoidance; FollowPath | UNKNOWN | **UNKNOWN_LICENSE** | NO | NO | UNKNOWN | license not verified | none | architecture/performance reference only |
| REP-003 | TUM-MLCMS/...@`ac11e2a...` | Simulation.cs; Pathfinding.cs; Pedestrian.cs | MIT | **REFERENCE_ONLY** | legally MIT permits copy subject to notice, but program chooses NO COPY | same | permitted by MIT | retain copyright/license if reused | none | algorithms are generic; clean independent implementation avoids unnecessary provenance/code coupling |
| REP-004 | trinhthanhtrung/unity-pedestrian-sim@`18d4d19...` | CrowdGen/*; SocialForceModel/SFCharacter.cs | MIT | **REFERENCE_ONLY** | program chooses NO COPY | program chooses NO ADAPT | permitted by MIT | MIT notice if reused | none | use papers/concepts and independent implementation; no need to import code |
| REP-005 | Flameshot/Unity-Formation-Movement@`963b14f...` | FormationAI/interfaces/grid/NavMesh/A* integration | GPL-3.0 | **REFERENCE_ONLY** | NO for baseline | NO for baseline | GPL permits commercial use subject to GPL obligations | copyleft/source/license obligations | none | avoid license-strategy coupling; independently implement formation contracts |
| REP-006 | AlexandraSicobean/...@`7db2ff4...` | Simulator.cs; Agent.cs; CrowdGenerator.cs | UNKNOWN | **UNKNOWN_LICENSE** | NO | NO | UNKNOWN | license not verified | none | reference only |
| REP-007 | eavraam/Crowd-Simulator@`33fe42f...` | Agent/CrowdGenerator/Pathfinding/Locomotion | UNKNOWN | **UNKNOWN_LICENSE** | NO | NO | UNKNOWN | license not verified | none | reference only |
| TL-ASSETS | Top Lords storefront/game | proprietary observable game/assets | proprietary/unknown for reuse | **DO_NOT_REUSE** | NO | NO | N/A | no authorization | none | inspiration limited to observable mechanics; no assets/code/content copied |

## MIT license fields — REP-003/004
LICENSE FOUND: yes. LICENSE: MIT. LICENSE SOURCE: repository LICENSE at fixed SHA. COPY/MODIFICATION/COMMERCIAL: permitted under MIT conditions. ATTRIBUTION: copyright + permission notice required in copies/substantial portions. PROGRAM DECISION: REFERENCE_ONLY because specifications call for original implementation and copying provides no demonstrated necessity.

## GPL-3.0 fields — REP-005
LICENSE FOUND: yes. LICENSE: GPL-3.0. LICENSE SOURCE: repository LICENSE at fixed SHA. COPY/MODIFICATION/COMMERCIAL: GPL permits these subject to GPL terms and corresponding-source/license obligations on covered distribution. PROGRAM DECISION: REFERENCE_ONLY for current baseline; no compatibility conclusion is invented for an unspecified final distribution/license strategy.

## Unknown-license fields
REP-001/002/006/007: LICENSE FOUND = not verified; LICENSE = UNKNOWN_LICENSE; COPY/MODIFICATION/COMMERCIAL = UNKNOWN; classification UNKNOWN_LICENSE; no code copied/adapted.

## Clean-room implementation posture
Research may describe algorithms/interfaces at a factual/conceptual level. New product code should be derived from requirements/specifications and generic technical knowledge, not transliterated from reference repositories. Any future proposal to COPY/ADAPT requires revisiting this matrix with exact source path/SHA/license/attribution/destination/modifications.
