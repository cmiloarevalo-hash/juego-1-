# PHASE 3 SOURCE REGISTER

Consulted 2026-10-05/06. Each entry states evidence type, limitations and supported claim. Source hierarchy: A product data; B methodological study; C aggregate benchmark; D official technical/policy; E comparable; F vendor/community/exploratory.

1. https://pubsonline.informs.org/doi/10.1287/isre.2021.0217
   - Organization/authors: INFORMS, Information Systems Research; Jiaying Deng, Stephanie Lee, Yong Tan.
   - Publication: online 2024-12-10; journal vol. 36(3), 2025.
   - Type: B, methodological research; Hidden Markov Model using detailed mobile-game tap-stream data.
   - Supports: perceived challenge has positive diminishing engagement effect; challenge fluctuation can improve engagement transitions; reward-ad scaffolding can help engagement, particularly at higher challenge.
   - Limitations: one game/context; observational/model-based transfer to our runner is not guaranteed; does not prove our rewarded placement improves retention.

2. https://research-portal.uu.nl/en/publications/daily-quests-or-daily-pests-the-benefits-and-pitfalls-of-engageme/
   - Authors/org: Julian Frommel, Regan L. Mandryk; Utrecht University / University of Saskatchewan; Proc. ACM HCI CHI PLAY.
   - Publication: 2022-10-25; DOI 10.1145/3549489.
   - Type: B, peer-reviewed mixed-methods survey, 178 participants, validated motivation/passion scales.
   - Supports: daily/engagement rewards can motivate but can also create FOMO, obligation and chore experiences.
   - Limitations: self-report across games; does not establish our daily/weekly causal retention effect.

3. https://www.sciencedirect.com/science/article/abs/pii/S0747563214002684
   - Authors: Joyce L.D. Neys, Jeroen Jansz, Ed S.H. Tan; Computers in Human Behavior.
   - Publication: 2014, vol. 37.
   - Type: B, large survey N=7,252 using self-determination/social identity framework.
   - Supports: enjoyment has a central role in gaming persistence; competence/autonomy/relatedness are relevant.
   - Limitations: older, broad gaming population, correlational/self-report; not mobile-runner-specific.

4. https://www.sciencedirect.com/science/article/pii/S0747563218302516
   - Publication: Computers in Human Behavior; experimental study N=59, repeated-measures reward conditions.
   - Type: B, experiment.
   - Supports: greater/more diverse virtual rewards can increase effort, enjoyment and presence in the tested casual game.
   - Limitations: small controlled study; does not determine economy complexity or long-term retention.

5. https://www.gameanalytics.com/reports/2025-mobile-gaming-benchmarks
   - Organization: GameAnalytics; report last updated 2026-08-24, covering 2024 benchmark patterns.
   - Type: C, aggregate industry benchmark.
   - Supports: mobile retention is difficult; content pacing/progression are plausible long-term health concerns; platform/genre distributions differ.
   - Limitations: aggregate/portfolio data; not a target or causal feature analysis; must not set our D1/D7/D28 goals.

6. https://developers.google.com/admob/unity/rewarded
   - Organization: Google for Developers / AdMob; consulted 2026-10-05/06.
   - Type: D official SDK documentation.
   - Supports: rewarded ads are optional interactions exchanged for in-app rewards; test ads/test devices are required in development guidance.
   - Limitations: technical documentation, not evidence that rewarded improves retention.

7. https://support.google.com/googleplay/android-developer/answer/9857753
   - Organization: Google Play; consulted 2026-10-05/06.
   - Type: D official policy.
   - Supports: unexpected disruptive full-screen ads are restricted; explicitly opted-in rewarded ads receive distinct treatment; ad content/audience requirements apply.
   - Limitations: policy, not product-performance evidence.

8. https://support.google.com/googleplay/android-developer/answer/18258653
   - Organization: Google Play; consulted 2026-10-05/06.
   - Type: D official developer/families policy.
   - Supports: additional monetization/ad requirements when children/unknown-age users are involved; aggressive commercial tactics and Families restrictions matter.
   - Limitations: policy changes; recheck before implementation/release; audience classification remains Human decision.

9. https://support.google.com/googleplay/android-developer/answer/11043825
   - Organization: Google Play; consulted 2026-10-05/06.
   - Type: D official Families data-practices policy.
   - Supports: restrictions on identifiers/data for children/unknown-age users.
   - Limitations: applies according to target audience classification; not an engagement finding.

10. https://developer.android.com/google/play/billing/one-time-products
    - Organization: Android Developers / Google Play Billing; consulted 2026-10-05/06.
    - Type: D official commerce documentation.
    - Supports: one-time products can be consumable or non-consumable; ad-free versions are an explicit non-consumable example.
    - Limitations: capability only; does not prove purchase demand.

11. https://support.google.com/googleplay/android-developer/answer/9858738
    - Organization: Google Play; consulted 2026-10-05/06.
    - Type: D official payments policy.
    - Supports: paid randomized virtual-item mechanisms require odds disclosure; payment terms/pricing must be clear.
    - Limitations: policy only; does not assess commercial performance.

12. https://firebase.google.com/docs/reference/unity/group/event-names
    - Organization: Firebase/Google; consulted 2026-10-05/06.
    - Type: D official analytics documentation.
    - Supports: standardized events exist for level start/end, virtual currency earn/spend, purchases etc.; useful vocabulary for a future minimal event contract.
    - Limitations: SDK vocabulary is not authority to integrate Firebase and does not prove which metrics cause retention.

13. https://play.google.com/store/apps/details?id=com.vincentb.MobControl
    - Organization/product: Google Play listing, VOODOO, Mob Control; observed 2026-10-05/06.
    - Type: E comparable product offering.
    - Supports: crowd multiplication is marketed as satisfying; mature offer includes gates, champions, cards/upgrades, boss levels, quests, season pass and no-ads option.
    - Limitations: feature presence/popularity does not establish causality or necessity for our game; mature scale is not launch requirement.

14. https://play.google.com/store/apps/details?id=com.freeplay.runandfight
    - Product: Join Clash 3D / Freeplay; observed 2026-10-05/06.
    - Type: E comparable.
    - Supports: crowd gathering, obstacle avoidance, bosses/final clash and rewards are observable offer components.
    - Limitations: cannot infer which feature drives retention or revenue.

15. https://play.google.com/store/apps/details?id=com.Garawell.BridgeRace
    - Product: Bridge Race / Supersonic Studios; observed 2026-10-05/06.
    - Type: E comparable plus weak user-review signals.
    - Supports: route/level variety is marketed; public reviews include complaints about intrusive ad load, useful only as weak risk signal.
    - Limitations: reviews are selected/anecdotal and not causal; do not quantify impact.

16. https://unity.com/blog/understanding-the-impact-of-rewarded-ads-on-iap-retention-and-engagement
    - Organization: Unity/ironSource; 2022-08-24.
    - Type: F vendor analysis of eight high-DAU apps.
    - Supports: rewarded viewers can correlate with higher spend/retention/session behavior.
    - Contrary/limitations: selection/self-selection/confounding; vendor interest; exposed vs non-exposed users are not necessarily comparable. Do NOT use as proof rewarded causes retention.

17. https://admob.google.com/home/resources/deguci-games-boosts-arpdau-by-10-percentage-with-rewarded-video/
    - Organization: Google AdMob; publisher case study, results stated for 2025.
    - Type: F vendor case study.
    - Supports: a publisher reports positive outcomes after adding rewarded at natural pauses.
    - Limitations: single selected case; individual results vary; causal design details insufficient; not transferable performance forecast.

18. https://papers.ssrn.com/sol3/Delivery.cfm/6137709.pdf?abstractid=6137709&mirid=1
    - Authors: Jiacheng Chang, Xiao Lei, Zhixi Wan, Lei Huang; HKU/Tencent; 2026 working paper.
    - Type: B/F boundary: methodological working paper with field experiments, not treated as final peer-reviewed authority.
    - Supports contrary evidence/risk framing: maximizing immediate rewarded-ad usage can frustrate players and reduce future retention; ad design has intertemporal trade-offs.
    - Limitations: puzzle-game context; working-paper status; implementation differs from our runner.

19. https://doi.org/10.1287/mnsc.2020.3943
    - Organization: Management Science; randomized mobile-gaming field experiment.
    - Type: B randomized field experiment.
    - Supports: content diversity/novelty can mediate retention effects in the tested crowdsourcing context; features can have non-obvious interaction effects.
    - Limitations: crowdsourced-content feature is not equivalent to authored runner biomes; only supports plausibility/need to test variety, not our exact architecture.

## Explicit source-use constraints
- #98 provider/mediation research is inherited; Phase 3 does not re-select providers.
- No source above establishes our required number of levels, D1/D7/D28 target, revenue, eCPM, ad frequency or economy values.
- No external source can substitute for APK evidence on hook comprehension, replay, content exhaustion, difficulty, reward claim UX or rewarded impact in this game.
