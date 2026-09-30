# Data and Progression Specification

DATA-LEVEL-001 Level definition: stable ID, ordered segments, geometry/presentation refs, gates, encounters, camera overrides, result/reward reference.
DATA-GATE-001 Gate definition: stable ID, operation/value, display semantics, validation bounds.
DATA-UPGRADE-001 Upgrade definition: stable ID, prerequisite IDs, max level, cost/effect data; exact economy values PENDING.
DATA-PROFILE-001 Durable profile: schemaVersion, progression, balances/resources, roster/world state only for features in approved scope, settings reference/version.
DATA-RUN-001 Run state SHALL be transient and not overwrite durable profile until result transaction.
DATA-RESULT-001 Result snapshot SHALL include stable run/level identity, outcome and reward inputs required by approved reward rules.
DATA-SAVE-001 Save migration SHALL explicitly transform supported prior schema versions or fail into defined recovery.
DATA-SEC-001 PlayerPrefs/local files SHALL not be treated as secure authoritative storage for secrets/anti-cheat. [UNITY-014]
DATA-CLOUD-001 Cloud/backend persistence is NOT IN BASELINE and requires explicit scope/RG-005 decision.
