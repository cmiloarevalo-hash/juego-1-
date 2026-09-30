> **DOCUMENTATION CLASSIFICATION: REFERENCE_ONLY / HISTORICAL_EVIDENCE.**
> This material is evidence, not target-product requirements or reuse permission. Current product authority is `docs/DOCUMENTATION_AUTHORITY_MAP.md`; Issue #83 global hold applies.

# Top Lords — Observable Reference

Work Item: #3  
Access date: 2026-09-30  
Scope: observable behavior only; no proprietary-code assumptions.

## Source quality
Primary storefront sources TL-001/TL-002 are authoritative for publisher-supplied product description and store metadata, not for hidden implementation details. TL-003/TL-004 are third-party gameplay videos useful as observational leads. Secondary strategy-guide claims are not promoted to facts without corroboration.

## Verified identity and positioning
- **VERIFIED FACT (TL-001, TL-002):** the current iOS/Android product is titled **Top Lords** and is published/listed under GAME SPARK / GAME SPARK PTE. LTD. Store descriptions position it as a medieval strategy runner/strategy game.
- **VERIFIED FACT (TL-001):** Apple lists iPhone/iPad support, in-app purchases, 13+ rating, multiple languages, and a 1.2 GB storefront size at access time.
- **VERIFIED FACT (TL-002):** Google Play lists strategy/4X/single-player descriptors and in-app purchases at access time.

## Observable/publisher-described runner loop
- **SOURCE CLAIM (TL-001/TL-002):** lateral swipes are the primary simple input; the player chooses a path, grows army ranks and fights enemies.
- **SOURCE CLAIM (TL-001):** Apple explicitly describes swipe-to-dodge or charge behavior and calls the experience a medieval strategy runner.
- **SOURCE CLAIM (TL-001/TL-002):** resource gathering and territorial expansion connect battle play to kingdom progression.
- **SOURCE CLAIM (TL-003/TL-004):** third-party gameplay-video descriptions report growing the army during battles and continuing through enemy encounters.
- **UNKNOWN:** exact forward-motion model, lane discretization, collision model, gate arithmetic, formation algorithm, target-selection algorithm, damage formula, spawn/despawn implementation, pooling, boss state machine and result calculation. These require direct frame-level observation or code-equivalent comparable evidence and must not be inferred from marketing text.

## Metagame systems described by storefronts
- **SOURCE CLAIM (TL-001/TL-002):** appoint lords/knights and grant/govern fiefs.
- **SOURCE CLAIM (TL-001/TL-002):** collect taxes and expand territory.
- **SOURCE CLAIM (TL-001/TL-002):** recruit heroes with distinct roles/skills and combine them into a team.
- **SOURCE CLAIM (TL-001/TL-002):** raise/command a griffin and progress in rank/title/kingdom growth.
- **VERIFIED FACT (TL-001):** Apple lists loot boxes, messaging/chat and in-app purchases in its current product metadata. This verifies storefront declarations, not their detailed gameplay/economic implementation.

## Reconstructable high-level loop
**INFERENCE, supported by TL-001/TL-002:** the product combines a short-session runner/battle layer with a persistent kingdom/metagame layer:

`simple swipe/path decision -> army growth/encounter -> resources/progress -> kingdom expansion/governance -> hero/griffin/rank growth -> further encounters`.

This is a conceptual loop only. Ordering, persistence boundaries and exact reward conversion remain UNKNOWN.

## UX observations supported by publisher copy
- **SOURCE CLAIM:** one-hand/simple-touch accessibility is an explicit design promise.
- **SOURCE CLAIM:** decisions are framed as rapid dodge/charge/path choices.
- **INFERENCE:** readable immediate choices and visible army growth are likely central feedback requirements for a comparable original product; exact UI composition is not established here.

## Questions delegated to later Work Items
- #6: input mapping, continuous vs lane movement, formation/slots/steering.
- #7: gate operators, activation, army mutation, spawn/despawn/pooling.
- #8: targeting, attack cadence, damage/death, boss encounters.
- #10: level segmentation, camera, obstacles, feedback/authoring.
- #11: reward economy, hero/fief/griffin/rank persistence and meta loop.

## Non-findings
No evidence reviewed in #3 establishes Top Lords source code, engine, Unity version, private algorithms, numeric balance values, exact gate formulas, exact troop statistics, or server architecture. These remain **UNKNOWN**.
