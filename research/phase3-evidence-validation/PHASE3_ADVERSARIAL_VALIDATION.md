# PHASE 3 — ADVERSARIAL EVIDENCE VALIDATION

Issue lineage: #98 + #99; Program #90. Branch: `research/phase3-evidence-validation`.
Consulted: 2026-10-05/06. Research only. Prototipo 1 is unchanged and Unity → APK → Samsung remains unblocked.

## Evidence discipline
A product data; B methodological study; C recognized aggregate benchmark; D official technical/policy; E observable comparable; F vendor/community/exploratory. Competitor presence is not causality; industry benchmarks are context, not targets; rewarded adoption is not proof of retention lift. No product telemetry exists yet for the post-prototype hypotheses below.

## External evidence vs our product evidence
**EVIDENCIA EXTERNA:** peer-reviewed/methodological research, official policies/docs, aggregate benchmark, observable products. It can constrain design and establish plausibility, not prove fit for this game.

**EVIDENCIA DE NUESTRO PRODUCTO:** none yet for hook preference, replay, retention, reward economy, daily/weekly objectives or ads. M2 static semantics exist, but executable player behavior does not. Therefore several decisions end as PRODUCT-DATA-REQUIRED.

## 1. Hook: Santa + ejército de elfos
**DECISIÓN →** Lead with “Santa grows/leads a visible elf army” rather than generic Christmas runner.
**EVIDENCIA A FAVOR →** Crowd growth is explicitly sold as satisfying in Mob Control; Join Clash sells gathering a crowd, dodging obstacles and final clash. Theme gives a recognizable semantic wrapper around an established readable mechanic.
**EVIDENCIA EN CONTRA →** These comparables demonstrate market presence, not that Santa/Christmas improves acquisition or retention; seasonal identity may narrow appeal or read as a skin.
**CALIDAD/FUERZA → WEAK.** E only; no causal/product data.
**APLICABILIDAD →** High conceptual fit because helpers already determine survival/combat in frozen semantics.
**INFERENCIAS →** Differentiation is strongest when elves are gameplay state, not decoration.
**RIESGOS →** Seasonal ceiling; crowded visual; Santa IP-style expectations; hook misunderstood as generic math runner.
**HIPÓTESIS MEDIBLE →** A player exposed briefly to gameplay/store creative can correctly describe “Santa builds an elf army and uses it to survive/fight” and shows stronger intent than a generic-runner framing.
**EXPERIMENTO →** After executable visual slice, blinded creative/comprehension test: thematic army creative vs generic mechanic-forward control; measure correct unaided proposition recall, play intent, and confusion themes. No arbitrary sample threshold: collect until dominant comprehension failures/themes stabilize and uncertainty is sufficient for a product decision.
**RESULTADO → NEEDS PRODUCT DATA.**

## 2. Visible army growth/loss as satisfaction + tension
**DECISIÓN →** Make army-size change one of the highest-priority feedback investments.
**FAVOR →** Mob Control explicitly foregrounds visible multiplication; Join Clash centers gathering/loss risk. Experimental reward research reports greater rewards can increase enjoyment/effort/presence, while persistence research places enjoyment centrally.
**CONTRA →** Comparable marketing does not isolate causality; excessive crowd density can hurt Android clarity/performance; extrinsic visual reward cannot compensate for weak control.
**FUERZA → MODERATE plausibility, PRODUCT-DATA-REQUIRED for magnitude.**
**APLICABILIDAD →** Direct: helper count is authoritative state and defeat condition.
**INFERENCIAS →** Count delta, formation expansion/contraction, sound/impact and readable loss deserve priority over expensive ambient polish.
**RIESGOS →** clutter, frame cost, emotionally flat losses if units look interchangeable.
**HIPÓTESIS →** Players notice and can predict army-state consequences; growth moments increase reported satisfaction, losses increase tension without confusion.
**VALIDACIÓN →** Instrument helper_count_before/after key events + short observed playtest; compare full feedback vs reduced-feedback build if needed; look for comprehension, replay and boss-reach effects, not vanity animation ratings alone.
**RESULTADO → GO for making it a core presentation priority; NEEDS PRODUCT DATA for polish level.

## 3. Core loop + “one more run”
**DECISIÓN →** Engagement must come first from run quality: grow → choose → risk/lose → recover → combat → boss → reward/next goal.
**FAVOR →** Large survey research links persistence centrally to enjoyment; challenge research in mobile games finds challenge can improve engagement with diminishing returns and beneficial variation. Successful comparables repeatedly expose growth/obstacle/final-clash loops.
**CONTRA →** Mature comparables also add substantial meta systems; intrinsic loop alone may not sustain long-term retention.
**FUERZA → MODERATE.** B + E.
**APLICABILIDAD →** Very high; matches frozen run semantics.
**INFERENCIAS →** Meta should amplify a proven run, not hide a weak one.
**RIESGOS →** repetitive route, deterministic best gate, long dead zones.
**HIPÓTESIS →** Players voluntarily start another run/next route without requiring a login gift or ad prompt.
**VALIDACIÓN →** APK funnel: run_start → meaningful decisions → boss/result → next_run_started; observe voluntary immediate replay and qualitative reasons. Negative signal: players claim reward then exit or describe run as repetitive.
**RESULTADO → GO architecture/order; NEEDS PRODUCT DATA for actual replay strength.

## 4. Route/biome variety + data-driven composition
**DECISIÓN →** Reuse invariant core; vary layout/rhythm/configuration/presentation via data rather than fork mechanics.
**FAVOR →** #98 architecture reduces coupling; observable comparables use many level layouts/elements/biomes; research on content access found diversity/novelty mediated retention in a mobile-game field experiment, though in a crowdsourcing context.
**CONTRA →** Novel visuals alone may not create meaningful gameplay variety; data-driven authoring has upfront tooling cost.
**FUERZA → MODERATE for architecture; WEAK/MODERATE for retention effect transfer.**
**APLICABILIDAD →** High: current domain boundaries are reusable.
**INFERENCIAS →** First prove a second route/biome can feel different without new core mechanics.
**RIESGOS →** configuration complexity, cosmetic reskins, authoring burden.
**HIPÓTESIS →** A second configured route is recognizably different in rhythm/risk while preserving comprehension.
**VALIDACIÓN →** Post-P1 architecture proof with one additional route/biome; compare player descriptions, fail locations and replay preference before mass production.
**RESULTADO → GO for data-driven architecture proof; KILL mass content commitment before proof.

## 5. Initial content scale
**DECISIÓN →** Do not commit to a large level count before marginal content cost and exhaustion are observed.
**FAVOR →** Aggregate mobile benchmarks show retention is difficult and point to content pacing/progression as common weak spots; mature comparables have broad content, but that is survivor/product evidence, not required launch scale.
**CONTRA →** Too little content can cause rapid exhaustion; benchmark does not identify our required quantity.
**FUERZA → PRODUCT-DATA-REQUIRED.** C/E cannot set count.
**APLICABILIDAD →** High cost sensitivity for small project.
**HIPÓTESIS →** A small diverse batch is enough to reveal whether content quantity is the limiting factor.
**VALIDACIÓN →** After reusable route proof, measure completion distribution, replay/next-route behavior, qualitative repetition complaints and authoring cost per route. Expand only when content exhaustion—not core weakness—is evidenced.
**RESULTADO → NEEDS PRODUCT DATA; MODIFY prior language to avoid any implied fixed launch count.

## 6. Lightweight meta-loop
**DECISIÓN →** Start with content/progress visibility, not deep upgrade/card/base systems.
**FAVOR →** Reward/meta research shows extrinsic systems can support feedback and alternative goals; mature Mob Control demonstrates large meta can extend an established core.
**CONTRA →** Self-determination literature warns controlling expected tangible rewards can undermine intrinsic motivation; mature systems carry high complexity and cannot establish necessity for a new title.
**FUERZA → MODERATE for keeping it light; PRODUCT-DATA-REQUIRED for exact feature.**
**APLICABILIDAD →** Strong cost/complexity rationale.
**HIPÓTESIS →** Simple progress toward next route/cosmetic goal improves next-run intent without becoming the reason to tolerate gameplay.
**VALIDACIÓN →** Compare baseline run/results vs lightweight progress display once replay baseline exists; measure next_run_started and return behavior plus qualitative motivation.
**RESULTADO → GO lightweight principle; NEEDS PRODUCT DATA exact meta mechanic.

## 7. One initial reward/currency vs complex economy
**DECISIÓN →** Use at most one fungible reward resource initially, and only if it has a clear gameplay-returning sink.
**FAVOR →** Fewer currencies reduce implementation/economy balancing surface; Firebase has explicit earn/spend virtual-currency events, making a single loop measurable. Google Play supports virtual currency/IAP but does not require complexity.
**CONTRA →** Multiple currencies can separate sinks and monetization later; one currency can become meaningless if sinks are weak.
**FUERZA → WEAK/MODERATE design rationale; PRODUCT-DATA-REQUIRED.**
**APLICABILIDAD →** High simplicity fit.
**HIPÓTESIS →** One reward type can make progress legible without creating farming/hoarding confusion.
**VALIDACIÓN →** Prototype reward balance without purchase: earn → claim → spend/unlock → next run. Observe unused balances, comprehension and whether reward changes next action.
**RESULTADO → GO as complexity cap; NEEDS PRODUCT DATA before economy tuning.

## 8. REWARD → CLAIM → PROGRESS experience
**DECISIÓN →** Make claiming tactile/clear but short, and always expose the next gameplay objective immediately.
**FAVOR →** Experimental work indicates reward presence/diversity can increase enjoyment/effort; achievement research finds rewards can provide feedback/goals.
**CONTRA →** Extrinsic reward systems can become chores or displace intrinsic motivation; extra claim screens add friction.
**FUERZA → MODERATE for feedback, WEAK for exact UX.**
**APLICABILIDAD →** Direct to #99 loop.
**HIPÓTESIS →** Claim increases perceived payoff while next-goal CTA prevents open→claim→close behavior.
**VALIDACIÓN →** Funnel result_shown → reward_claimed → progress_viewed → next_run_started; compare concise claim vs auto-credit/less ceremony if claim abandonment or exit rises.
**RESULTADO → NEEDS PRODUCT DATA; GO on “claim must route back to play”.

## 9. Daily gameplay objectives
**DECISIÓN →** If used, require meaningful gameplay rather than login-only collection.
**FAVOR →** Frommel/Mandryk found engagement rewards can motivate; objectives can direct players to gameplay variety.
**CONTRA →** Same study found FOMO, obligation and chore experiences. Login rewards risk optimizing app-open rather than play.
**FUERZA → MODERATE contradictory B evidence.**
**APLICABILIDAD →** Good only after multiple meaningful run actions exist.
**HIPÓTESIS →** Low-burden gameplay dailies increase runs/variety without perceived obligation.
**VALIDACIÓN →** Baseline vs gameplay-objective exposure; measure objective_seen/start/completion, runs per active session, next-day return descriptively, and player reports of pressure/chore. No retention target imported from benchmarks.
**RESULTADO → MODIFY: gameplay objectives only; KILL login-only daily as initial design.

## 10. Weekly objectives
**DECISIÓN →** Defer until content depth supports multi-session goals.
**FAVOR →** Longer-horizon goals can provide continuity and meta direction.
**CONTRA →** Same engagement-reward evidence warns obligation/FOMO; without sufficient content, weekly quotas amplify repetition.
**FUERZA → WEAK/PRODUCT-DATA-REQUIRED.**
**HIPÓTESIS →** Weekly goal helps only after organic multi-day play exists.
**VALIDACIÓN →** First establish natural return and daily objective behavior; then test a broad gameplay goal that can progress through normal runs.
**RESULTADO → MODIFY/DEFER; NEEDS PRODUCT DATA.

## 11. Streak/calendar
**DECISIÓN →** Keep deferred; do not use loss/reset pressure initially.
**FAVOR →** Common market pattern and vendor material claims re-engagement value.
**CONTRA →** Peer-reviewed engagement-reward study identifies FOMO/obligation/chore risk; streaks explicitly add loss aversion and can reward opening rather than playing.
**FUERZA → MODERATE against initial use; favorable evidence is weaker/vendor/observational.**
**HIPÓTESIS →** A streak is unnecessary if gameplay objectives already create return; if reconsidered, forgiving cumulative attendance may outperform reset-on-miss UX.
**VALIDACIÓN →** Only after product data shows a return-frequency gap not explained by core/content. Test forgiving vs no-streak, not punitive streak first.
**RESULTADO → KILL punitive/reset streak for initial roadmap; DEFER calendar.

## 12. Difficulty, defeat, retry
**DECISIÓN →** Vary meaningful challenge rather than only speed; retry should be fast and failure attributable.
**FAVOR →** 2024/25 mobile-game study finds challenge has positive but diminishing engagement effect and challenge fluctuation can move players to higher engagement states.
**CONTRA →** Study is another mobile game; transfer to this runner is uncertain. Too easy also removes tension.
**FUERZA → MODERATE B.**
**HIPÓTESIS →** Players understand why they lost and retry when failure appears recoverable.
**VALIDACIÓN →** Track failure_section/cause, retry_selected, time_to_retry, repeated-fail sequences; observed test asks player to explain defeat before designer explanation.
**RESULTADO → GO principle; NEEDS PRODUCT DATA tuning.

## 13. Rewarded post-run
**DECISIÓN →** Primary ad hypothesis: optional reward enhancement after base reward is secured, at natural post-run pause.
**FAVOR →** Google defines rewarded as optional value exchange; Play policy exempts explicitly opted-in rewarded from disruptive-ad rule. A methodological mobile-game study finds reward-ad scaffolding can improve engagement states, particularly at higher challenge. Vendor case studies report positive retention/revenue outcomes at natural pauses.
**CONTRA →** Vendor analyses are selected/observational and subject to self-selection; ad viewers may already be more engaged. Reward ads can add delay/friction and distort reward valuation.
**FUERZA → MODERATE external plausibility; PRODUCT-DATA-REQUIRED for our effect.**
**HIPÓTESIS →** Post-run opt-in bonus monetizes without reducing next-run conversion versus no-ad baseline.
**VALIDACIÓN →** Only after engagement baseline + audience gate. Control: no offer; variant: optional post-run bonus after base claim. Events: offer, accept, complete/fail, bonus grant, next_run_started, session_end, later return. GO if monetization is additive without material gameplay/replay deterioration; MODIFY if placement/reward causes friction; KILL if replay/session/return deteriorates consistently relative to control. Data minimum: enough exposed eligible players and repeat opportunities to distinguish stable behavior from novelty/technical failures; no arbitrary N.
**RESULTADO → NEEDS PRODUCT DATA; GO as first ad experiment, not production assumption.

## 14. Rewarded continue
**DECISIÓN →** Secondary hypothesis only, not default.
**FAVOR →** Challenge/reward-ad research suggests scaffolding is more useful under higher challenge; continue can preserve a run investment.
**CONTRA →** It can weaken defeat semantics, encourage engineered frustration, make fair retry less attractive and create perceived coercion.
**FUERZA → MODERATE evidence for scaffolding generally, WEAK for this exact placement.**
**APLICABILIDAD →** High semantic risk because zero helpers currently means immediate Defeat.
**HIPÓTESIS →** A clearly optional, limited continue may help only at high-investment failures without damaging fairness.
**VALIDACIÓN →** Do not test until Human approves semantics. If approved, compare fair retry baseline vs limited continue offer; track offer/accept, eventual result, subsequent retry/replay, perceived fairness.
**RESULTADO → MODIFY/DEFER; HUMAN/product semantic gate before experiment.

## 15. Ads vs replay/retention risk
**DECISIÓN →** Never assume rewarded improves retention; protect replay as primary health signal.
**FAVOR →** Methodological study supports potential engagement benefit; vendor case studies report retention gains.
**CONTRA →** Self-selection/confounding in vendor evidence; adaptive-ad research explicitly frames an intertemporal trade-off where more immediate ad usage can frustrate users and reduce future retention. Play policy also treats interruption as UX risk.
**FUERZA → MODERATE contradictory evidence.**
**HIPÓTESIS →** Natural-pause, optional ads can be neutral/additive, but frequency/reward design determines outcome.
**VALIDACIÓN →** Randomized product experiment where permitted; jointly evaluate ad completion/revenue and replay/session/return, never ad KPI alone.
**RESULTADO → GO guardrail; NEEDS PRODUCT DATA placement/frequency.

## 16. Engagement → progression → monetization order
**DECISIÓN →** Validate executable run first, then progression, then ads/IAP.
**FAVOR →** Persistence research centers enjoyment; aggregate benchmark emphasizes retention health; monetization requires retained exposure. Ads can alter engagement, so introducing them before baseline confounds diagnosis.
**CONTRA →** Early monetization prototypes can reveal technical/economic constraints sooner.
**FUERZA → STRONG as sequencing/risk-control inference, not causal feature proof.**
**APLICABILIDAD →** Excellent: P1 executable path is already separate and blocked only by environment.
**RESULTADO → GO.** Technical interfaces/fakes may be designed early, production monetization remains later.

## 17. Analytics/funnel
**DECISIÓN →** Instrument only events needed to falsify hypotheses.
**FAVOR →** Firebase officially provides game/economy events such as level_start/end, earn/spend virtual currency and purchase events; product data is the highest evidence tier here.
**CONTRA →** Analytics adds privacy/implementation burden and can encourage metric optimization without causal experiments.
**FUERZA → STRONG need, PRODUCT-DATA-REQUIRED results.**
**MINIMUM FUNNEL →** app/session start; onboarding_complete; run_start; first_growth; gate_choice(type/value); obstacle_hit/avoided; helper_count checkpoints; combat/boss reach; result(victory/defeat,cause); reward_shown/claimed; progress_changed; objective_seen/progress/completed; next_run_started/retry; rewarded_offer/accept/complete/fail/reward_granted; session_end. Add economy earn/spend only if economy exists.
**GUARDRAIL →** no analytics SDK is authorized by this research; audience/privacy gate applies before production collection.
**RESULTADO → GO event contract design later; implementation follows product/privacy authority.

## 18. Development investment priorities
**DECISIÓN →** Spend first on executable core feel/clarity and evidence collection, then reusable content/progress, then monetization experiments.
**FAVOR →** Decisions with greatest uncertainty require product evidence; army feedback and run loop are high-frequency; data-driven route proof caps content risk; monetization before engagement baseline confounds diagnosis.
**CONTRA →** Delaying meta/monetization delays learning about them.
**FUERZA → STRONG risk/ROI synthesis from current evidence hierarchy.**
**RESULTADO → GO.**

# Monetization alternatives

| Model | Favor | Against / risk | Phase-3 result |
|---|---|---|---|
| Rewarded post-run | opt-in; natural pause; policy-compatible; external engagement plausibility | self-selection/confounding; replay friction; reward inflation | NEEDS PRODUCT DATA; first ad experiment after gates |
| Rewarded continue | potential challenge scaffold | threatens defeat/fairness; coercion risk; semantic change | MODIFY/DEFER; Human gate |
| No-ads one-time IAP | Google Play explicitly supports permanent ad-free non-consumable product; simple value proposition | has little value before ads exist; purchase demand unknown | GO as later candidate, NEEDS PRODUCT DATA |
| Cosmetics | non-power purchase can preserve gameplay fairness | asset/catalog burden; Santa/elf visual identity may need consistency; demand unknown | DEFER until identity/core validated |
| Consumable currency/boosts | officially supported commerce model | economy complexity, pay-to-progress pressure, balance burden | KILL for initial monetization roadmap |
| Subscription/season pass | recurring content funding seen in mature comparables | content/liveops obligation far beyond current capacity | KILL/DEFER far beyond initial roadmap |
| Forced mid-run interstitial | immediate impressions | disruptive UX; policy constraints; direct replay risk | KILL |
| Loot-box/random paid rewards | monetization precedent | disclosure/policy burden, trust/fairness and economy complexity | KILL |

Audience/age remains a Human gate before production monetization. If children or unknown-age users receive ads, Google Play Families adds SDK/data/ad restrictions. No provider selected; #98 provider research stands.

# Master decision matrix

| DECISIÓN | ESTADO ACTUAL | FAVOR | CONTRA | FUERZA | RIESGO | VALIDACIÓN PRODUCTO | RESULTADO |
|---|---|---|---|---|---|---|---|
| Santa+elf army hook | proposed | thematic+mechanic coherence | no causal evidence; seasonality | WEAK | hook generic/seasonal | creative comprehension | NEEDS PRODUCT DATA |
| Visible army feedback | proposed priority | comparable + reward/enjoyment plausibility | clutter/perf | MODERATE | Android readability | observed APK + telemetry | GO + tune with data |
| Run-first engagement | proposed | enjoyment/persistence + challenge evidence | meta may be needed later | MODERATE | repetition | replay funnel | GO / NEEDS DATA |
| Data-driven route variety | #98 recommendation | reuse + novelty plausibility | tooling/cosmetic reskin risk | MODERATE | authoring cost | second-route proof | GO |
| Large initial content | not fixed | mature games have breadth | no evidence for our quantity | PRODUCT-DATA-REQUIRED | waste | exhaustion + marginal cost | KILL commitment / NEEDS DATA |
| Lightweight meta | proposed | goals/feedback | extrinsic crowd-out/complexity | MODERATE | chores | baseline vs light progress | GO principle / NEEDS DATA |
| One initial currency | proposed | simplicity/measurability | weak sinks possible | WEAK-MODERATE | inflation | earn-spend-next-run | GO cap / NEEDS DATA |
| Claim experience | proposed | payoff feedback | friction | MODERATE | claim→exit | claim funnel | NEEDS DATA |
| Gameplay dailies | proposed | motivation/variety | FOMO/chore | MODERATE | obligation | controlled rollout | MODIFY |
| Weeklies | proposed later | continuity | repetition/obligation | WEAK | quota feel | only after organic return | MODIFY/DEFER |
| Punitive streak | deferred | market prevalence | FOMO/loss pressure | MODERATE against | open→claim→close | only if return gap | KILL initial |
| Fair difficulty/retry | proposed | challenge evidence | transfer uncertain | MODERATE | frustration | fail/retry telemetry | GO / tune with data |
| Rewarded post-run | #98/#99 candidate | opt-in + study/policy | ad friction/confounding | MODERATE | replay harm | randomized experiment | NEEDS DATA |
| Rewarded continue | secondary | challenge scaffold | defeat/coercion | WEAK-MODERATE | semantic harm | Human-approved experiment | MODIFY/DEFER |
| Protect replay from ads | guardrail | contradictory evidence demands joint KPIs | monetization pressure | MODERATE | local revenue optimization | joint replay+return+ad metrics | GO |
| Engagement→progression→monetization | proposed order | diagnostic clarity | slower monetization learning | STRONG | schedule | staged gates | GO |
| Minimal analytics contract | proposed | enables A-tier evidence | privacy/overinstrumentation | STRONG | data burden | validate event usefulness | GO design, no SDK yet |
| ROI order | proposed | uncertainty/high-frequency logic | later systems learned later | STRONG | sequencing | gate by product evidence | GO |

# Final groups

## GO
- Preserve run-first engagement and frozen gameplay path.
- Prioritize visible army-state feedback, readable decisions, impacts and fast/fair retry.
- Use data-driven reusable route/biome architecture; prove it with one post-P1 second-route experiment before scaling.
- Keep meta-loop lightweight and economy complexity capped initially.
- Keep rewards/objectives tied back to gameplay.
- Protect replay/return as health metrics when monetization is tested.
- Sequence engagement → progression → monetization.
- Define minimal falsifiable analytics/event contract before experiments, subject to privacy authority.
- Development ROI order: executable core/evidence → reusable content/progress → monetization tests.

## MODIFY
- Daily: gameplay objectives, not login-only claims; low burden and no punitive loss.
- Weekly: defer until organic multi-session behavior/content depth exists.
- Claim: short payoff then explicit next-run/goal path; do not optimize claim alone.
- Rewarded continue: secondary, bounded and only after Human approves semantics.
- Initial content: replace any implied fixed count with evidence-gated scaling.

## KILL
- Initial punitive reset streak/calendar.
- Login-only daily as primary retention mechanic.
- Large content commitment before second-route proof/product exhaustion evidence.
- Initial multi-currency/deep economy, consumable boost economy, subscription/season-pass obligation.
- Forced mid-run interstitials.
- Paid randomized/loot-box economy for initial roadmap.

## NEEDS PRODUCT DATA
- Whether Santa+elf army actually differentiates acquisition/comprehension.
- Magnitude of army feedback benefit.
- Organic “one more run” strength and retention baseline.
- Exact initial content quantity and exhaustion point.
- Exact lightweight meta feature and reward/sink balance.
- Claim UX effect on next-run conversion.
- Daily/weekly effect vs chore/FOMO.
- Difficulty curve and retry tuning.
- Post-run rewarded effect on replay/session/return and monetization.
- Any reconsideration of streak/calendar.
- Cosmetic/no-ads purchase demand.

# Human gates genuinely pending
1. Audience/age classification before production analytics/ads/monetization choices where policy/data handling depends on it.
2. Whether a rewarded continue is ever allowed to override/extend the frozen immediate-Defeat semantics; do not test until explicitly authorized.
3. Later commercial/IAP/ad activation and provider choice remain separate authority; research makes no commitment.

No Human decision blocks current research or Prototipo 1 completion.
