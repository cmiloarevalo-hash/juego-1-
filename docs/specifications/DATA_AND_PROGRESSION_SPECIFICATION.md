# Data and Progression Specification — Christmas Prototype Freeze
Status: FROZEN reduced prototype scope. Supersedes prior metagame/economy baseline for this prototype.

DATA-STAGE-001 [FROZEN] One stage definition with stable ID and ordered segments/encounters/gates/obstacles/boss/result references.
DATA-GATE-001 [FROZEN] Gate definition: stable ID; operation {ADD,MULTIPLY}; positive integer N; display symbol/value; consumed runtime state.
DATA-RUN-001 [FROZEN] Run state is transient: army count, consumed gates, encounter/boss/result state and presentation reconciliation metadata as needed.
DATA-RESULT-001 [FROZEN] Result snapshot includes stage/run identity and terminal outcome sufficient for UI/verification; no strategic reward transaction required.
DATA-LOC-001 [FROZEN] ES/EN localization data uses stable keys and supports Spanish glyphs.
DATA-SETTINGS-001 [FROZEN/OPTIONAL IMPLEMENTATION] Minimal local settings may persist only controls/audio/language if those settings are exposed; schema/version only if persistence is implemented.
DATA-UPGRADE-001 [OUT_OF_SCOPE] upgrades/strategic progression.
DATA-ECON-001 [OUT_OF_SCOPE] balances/resources/kingdom economy.
DATA-ROSTER-001 [OUT_OF_SCOPE] durable hero/roster/world progression.
DATA-CLOUD-001 [OUT_OF_SCOPE] cloud/backend persistence.
DATA-STORE-001 [DEFERRED] Play Store/commercial account/store data.
