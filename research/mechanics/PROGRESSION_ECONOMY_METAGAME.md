> **DOCUMENTATION CLASSIFICATION: HISTORICAL_EVIDENCE / NOT CURRENT IMPLEMENTATION AUTHORITY.**
> This document predates the accepted Christmas prototype freeze. Where it mentions iOS, metagame/economy/progression, optional boss, extra gate/tool families, old TBDs or proposed architecture, those statements are superseded by `PROJECT_AUTHORITY.md` and `docs/specifications/**`. Preserve as rationale/evidence only; do not execute recommendations without current authority. Issue #83 global hold applies.

# Progression, Economy and Metagame

Work Item: #11

## Observable Top Lords boundary
**SOURCE CLAIM (TL-001/TL-002):** publisher storefronts state resource collection, territory expansion, rank/throne progression, fiefs, taxes, lords/knights, heroes with roles/abilities and a griffin.
**UNKNOWN:** exact currencies, prices, reward equations, upgrade curves, timers, monetization economy, drop rates, hero rarity or save schema. No values are invented.

## Runner -> metagame transition
Candidate flow (**INFERENCE**):
`start run loadout/state -> runner level -> result snapshot -> reward calculation from approved rules -> atomic progression transaction -> metagame presentation -> next level/loadout`.

Separation required:
- run-local state: army count, encounter state, temporary effects;
- profile progression: unlocked levels/content, durable upgrades;
- economy balances: currency/resource ledgers;
- roster: heroes/units/griffin if in product scope;
- world/territory/fief state if in product scope;
- settings/preferences.

## Reward model alternatives
1. fixed level-completion reward;
2. performance-based reward from survivors/objectives;
3. authored reward table by level;
4. metagame resource generation/tax state.

Storefront supports resources/taxes conceptually, not equations. Reward values remain specification/product decisions.

## Upgrade model
Candidate data should define stable upgrade IDs, prerequisites, max level, cost rule/table and effects. Runtime code consumes data; it should not hide economy constants in behavior scripts.

Risks:
- circular prerequisites;
- integer overflow/negative balances;
- partial transaction on interruption;
- duplicate reward claim;
- version migration invalidating IDs;
- balance data changing while old save persists.

## Persistence evidence
**CODE OBSERVATION (REP-001):** inspected utility uses PlayerPrefs.
**VERIFIED FACT (UNITY-014):** PlayerPrefs persists simple string/int/float preferences and is unencrypted; Unity advises against sensitive data.
**VERIFIED FACT (UNITY-015):** persistentDataPath provides a location intended for files retained between runs/updates subject to user/device behavior.
**VERIFIED FACT (UNITY-016):** JsonUtility serializes supported fields using Unity serialization rules.

Persistence alternatives:
A. PlayerPrefs for settings/small simple values.
B. versioned local save file under persistentDataPath.
C. platform/cloud/backend persistence — **OUTSIDE CURRENT EVIDENCE**, requires product/backend scope and Research Gate.

Candidate save envelope:
`schemaVersion, profileId/local slot, progression, economy, roster, worldState, settingsVersion, checksum/integrity metadata if required`.
No security claim is made; local files/preferences are not authoritative anti-cheat storage.

## Transaction/integrity candidate rules
- result/reward transaction idempotent;
- validate nonnegative balances and caps;
- save migration explicit by schema version;
- write strategy must tolerate interruption (temporary file/replace or equivalent evaluated later);
- reset/new game intentionally clears owned state;
- corrupted/unsupported save has defined recovery behavior;
- no sensitive secrets in PlayerPrefs.

## Candidate requirements
DATA-CAND-001 Durable entities SHALL use stable IDs independent of display names.
SAVE-CAND-001 Save format SHALL be versioned and migration behavior testable.
SAVE-CAND-002 Result rewards SHALL be applied at most once per completed run transaction.
ECON-CAND-001 Currency/resource arithmetic SHALL define domain, caps and insufficient-funds behavior.
PROG-CAND-001 Unlock/upgrade prerequisites SHALL be data-driven and validated for invalid/cyclic references.
META-CAND-001 Runner result SHALL cross into metagame through an explicit immutable result snapshot/transaction input.

## Verification cases
new profile; normal save/load; app interruption during reward; duplicate result submission; schema migration; missing/corrupt save; max/min currency; upgrade prerequisite cycle; reset; content ID removed/renamed; offline clock dependence if timers are later introduced.

## Open product questions
Which Top Lords-inspired metagame features belong to the original product is not fully fixed by observable inspiration. Exact hero/griffin/fief/tax depth and monetization are material product-scope decisions; specifications must avoid silently cloning proprietary balance/content.
