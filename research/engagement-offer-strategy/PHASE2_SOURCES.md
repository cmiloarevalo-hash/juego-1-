# FASE 2 — SOURCES

Consultadas: 2026-10-06. Revalidar políticas/SDKs antes de implementación/release. Se priorizan fuentes primarias/oficiales.

## Comparables actuales — Google Play
1. Count Masters: Stickman Games — Freeplay Inc
https://play.google.com/store/apps/details?id=freeplay.crowdrun.com
HECHO usado: su listing describe elegir gates, reunir crowd, obstáculos, monedas/upgrades y batalla final contra King; contiene ads/IAP y muestra eventos/ofertas. No se infieren métricas internas.

2. Mob Control — VOODOO
https://play.google.com/store/apps/details?id=com.vincentb.MobControl
HECHO usado: listing describe crecer mob, champions, collectible cards, modos, Champions League, desafíos/recompensas y opciones premium/no-ads/Skip'Its. Se usa como comparable adyacente de expansión, no como prueba de que esas features causen retención.

3. Tall Man Run — Supersonic Studios
https://play.google.com/store/apps/details?id=com.VectorUpGames.TallManRun
HECHO usado: promesa pública centrada en crecer alto/ancho para derrotar bots y completar nivel. Comparable de transformación/growth runner.

4. Crowd Evolution! — Rollic Games
https://play.google.com/store/apps/details?id=com.longhorn.countmasterevo
HECHO usado: listing vende crecer/evolucionar crowd y vencer enemigos. Comparable de promesa, no de performance comercial.

5. Subway Surfers — SYBO Games
https://play.google.com/store/apps/details?id=com.kiloo.subwaysurf
HECHO usado: listing comunica acción de correr/esquivar y crew/power-up/social. Comparable adyacente de claridad/runner maduro, no equivalente mecánico.

## Ads / policy — Google official
6. Google Mobile Ads Unity — Rewarded ads
https://developers.google.com/admob/unity/rewarded
HECHO: rewarded ofrece recompensa a cambio de interacción voluntaria; documentación exige test ads durante desarrollo y expone callbacks de reward/lifecycle.

7. Google Play — Ads policy
https://support.google.com/googleplay/android-developer/answer/9857753
HECHO: anuncios inesperados durante gameplay/inicio de contenido son disruptivos; rewarded explícitamente opt-in recibe tratamiento específico; ads siguen sujetos a políticas aplicables.

8. Google Play Developer Program Policies / Families advertising requirements
https://support.google.com/googleplay/android-developer/answer/18258653
HECHO: cuando aplican requisitos de niños/edad desconocida existen restricciones adicionales de contenido/formato/publicidad. #98 mantiene audiencia como decisión Human previa a monetización real.

## Analytics / game events — Google official
9. Firebase Analytics Unity — Log events
https://firebase.google.com/docs/analytics/unity/events
HECHO: Unity puede registrar eventos; Firebase ofrece eventos recomendados para categorías incluyendo gaming.

10. Firebase Analytics Unity reference
https://firebase.google.com/docs/reference/unity/class/firebase/analytics/firebase-analytics
HECHO: existen eventos recomendados `level_start` y `level_end`; `level_end` admite success.

11. Google Play Games Services — Events
https://developer.android.com/games/pgs/events
HECHO: Events permite definir/recopilar acciones y progreso de gameplay para análisis y feedback de diseño/dificultad.

12. Google Play Games Services — Game Stats
https://developer.android.com/games/pgs/gamestats
HECHO: Player Events representan momentos, completions y milestones; Game Stats no deben basarse en abrir genéricamente el juego, compras ni ver ads. Esto apoya el principio de objetivos centrados en gameplay, aunque Game Stats no se adopta aquí como backend obligatorio.

## Evidencia durable heredada
Issue #98 / SHA `e2d0b18417b48130c797af7e7f4903dc094ef6f8`:
- `research/post-prototype/ADR_MONETIZATION.md`
- `research/post-prototype/POLICY_PRIVACY_SOURCES.md`
- `research/post-prototype/MULTILEVEL_ROADMAP.md`

Se heredan: provider-neutral `IMonetizationService`; Null/Fake antes de SDK; rewarded-only como primer formato candidato; no ads durante recorrido; audiencia/privacy antes de proveedor/producción; prueba de segundo bioma antes de escalar catálogo. No se re-investigó mediación/proveedores en #99.

## Límites de evidencia
- Listings de Play Store demuestran oferta/promesa declarada, no causalidad de engagement ni retención.
- Descargas/reseñas públicas no se usan para estimar D1/D7, ingresos, eCPM ni duración de sesión.
- Recomendaciones de daily/weekly/economía son diseño inferido a validar con el producto propio, no hechos de mercado.
