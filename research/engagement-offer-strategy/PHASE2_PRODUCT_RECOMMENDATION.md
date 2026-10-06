# FASE 2 — ENGAGEMENT / OFFER RESEARCH

Issue #99. Consulta: 2026-10-06. Estado: recomendación de investigación; NO cambia Prototipo 1.

## Método y disciplina
Cada conclusión se etiqueta como **HECHO/EVIDENCIA**, **INFERENCIA**, **HIPÓTESIS A VALIDAR** o **RECOMENDACIÓN**. No se atribuyen métricas de retención, ingresos, eCPM, duración o cantidad de niveles sin evidencia. Los checkpoints Supervisor 6006600012, 6006616914 y 6006629664 autorizan esta Fase 2 y exigen cubrir engagement recurrente, premios/cobro y el ciclo RUN→REWARD→CLAIM→PROGRESS→DAILY/WEEKLY GOAL→NEXT RUN.

## 1. Hook y diferenciación
**HECHO/EVIDENCIA:** Count Masters vende explícitamente elegir gates, reunir guerreros, chocar con otra multitud y derrotar un rey final. Tall Man Run vende transformación corporal para derrotar bots. Crowd Evolution vende crecimiento/evolución de multitud. Mob Control amplía la fantasía de mob con campeones, cartas, modos, liga, desafíos y recompensas. Fuentes: Play Store, ver SOURCES.md.

**INFERENCIA:** “multitud que crece + gate + enemigo final” ya es lenguaje competitivo establecido; copiarlo no diferencia.

**RECOMENDACIÓN:** promesa: **“Lidera a Santa y convierte un pequeño grupo de elfos en un ejército navideño capaz de atravesar peligros y derrotar al boss.”** La identidad debe afectar lectura del estado: elfos = fuerza/protección visible; perderlos duele; rescatarlos/multiplicarlos cambia el ejército; snowball/hammer/boss son payoffs navideños. Navidad no debe ser sólo decoración.

**HIPÓTESIS A VALIDAR:** una captura/video de pocos segundos donde Santa corre delante y el ejército crece/pierde miembros comunica mejor la propuesta que Santa solo o un runner genérico con skins.

## 2. Sensación, core loop y “una más”
**RECOMENDACIÓN:** el micro-loop debe ser: anticipar → elegir/maniobrar → transformación visible del ejército → riesgo/pérdida → recuperación → combate/payoff. Priorizar feedback de alta frecuencia: crecimiento/pérdida, gate, impactos y lectura de formación. Boss y resultado son payoff de menor frecuencia.

La razón para “una más” no debe depender primero de economía. Debe combinar: (a) siguiente recorrido/variación visible; (b) objetivo de gameplay parcialmente avanzado; (c) progreso ligero cobrado tras jugar. La pantalla de resultado debe enseñar qué se ganó, qué progresó y qué objetivo jugable queda cerca.

**HIPÓTESIS A VALIDAR:** replay/next-run aumenta cuando el resultado revela una variación/objetivo cercano, comparado con una pantalla que sólo entrega moneda.

## 3. Oferta competitiva y escala inicial
**HECHO/EVIDENCIA:** Count Masters combina gates, crowd combat, obstáculos, monedas/upgrades, batalla final y eventos/ofertas visibles en Play Store. Mob Control ofrece progresión mucho más amplia (cartas, campeones, modos, liga, desafíos/rewards). Subway Surfers se apoya en acción de evasión muy legible y una oferta madura con crew/power-ups/social; no es comparable mecánico directo pero sí referencia de claridad y profundidad de runner.

**INFERENCIA:** competir por volumen con productos maduros antes de validar el core es una mala asignación de capital. La primera oferta debe demostrar variedad percibida a bajo costo marginal.

**RECOMENDACIÓN:** después de Prototipo 1, construir un **vertical de oferta**, no un catálogo: reutilizar core y producir un segundo recorrido/bioma como prueba de arquitectura; luego un lote pequeño de recorridos que varíen composición y ritmo. No fijar número final de niveles ahora. Escalar sólo cuando (1) el core se valida, (2) el pipeline de autoría es reutilizable y (3) la variedad adicional sea el cuello de botella observado.

Dimensiones de variedad con mejor ROI esperado: layout/ritmo de secciones; secuencia y valores de +N/xN; riesgo/recompensa; posición/timing de obstáculos y enemigos; composición/formación visual; boss tuning/presentación; bioma. Crear una mecánica nueva por nivel es de menor prioridad.

## 4. Progresión/meta-loop y economía mínima
**RECOMENDACIÓN:** persistencia mínima con tres conceptos como máximo al inicio:
1. **Progreso de contenido**: recorrido/mundo siguiente desbloqueable por jugar/completar, no por pagar/ver anuncios.
2. **Recompensa fungible única** (nombre temático por decidir, p.ej. regalos/estrellas): se obtiene principalmente jugando y sirve para un conjunto pequeño de mejoras/cosméticos no necesarios para completar el core.
3. **Objetivos**: daily/weekly basados en acciones de gameplay, no en abrir la app.

Evitar inicialmente múltiples monedas, crafting, energía, gacha, upgrades con árboles profundos y power inflation. La economía debe explicar una razón para otra run, no reemplazarla.

## 5. PREMIO y experiencia de COBRAR
El ciclo recomendado es:

`RUN → PREMIO → COBRAR → PROGRESAR → OBJETIVO DIARIO/SEMANAL → SIGUIENTE RUN`

- **RUN:** el jugador gana valor por acciones reales: completar, llegar al boss, tomar gates, conservar/recuperar ejército, etc.
- **PREMIO:** resultado claro, derivado de la run; nunca premio principal por abrir.
- **COBRAR:** acción breve y satisfactoria. Cobro base siempre disponible sin anuncio. Mostrar origen y efecto del premio.
- **PROGRESAR:** el cobro mueve un objetivo visible (contenido, colección/cosmético o barra de objetivo), evitando pantallas encadenadas.
- **OBJETIVO DAILY/WEEKLY:** la UI señala “qué jugar ahora”, no “qué reclamar ahora”.
- **SIGUIENTE RUN:** CTA principal vuelve directamente al gameplay; el próximo objetivo/variación es visible.

**RECOMENDACIÓN:** una sola pantalla post-run puede consolidar resultado + cobro + progreso + siguiente objetivo para minimizar fricción.

**ANTI-PATRÓN:** `ABRIR → DAILY LOGIN REWARD → COBRAR → CERRAR`. No otorgar el valor central por launch/login. Si existe calendario/streak futuro, debe exigir al menos actividad jugable significativa antes del claim.

## 6. Daily, weekly y streak
**DAILY — RECOMENDACIÓN:** 2–3 tipos rotables conceptuales, todos gameplay-linked: completar runs; alcanzar/derrotar boss; atravesar cierto tipo de gate; terminar con condición de ejército; usar/evitar herramienta/obstáculo cuando aplique. No fijar cantidades todavía. El premio debe contribuir a progreso ligero y el objetivo debe poder completarse con sesiones normales.

**WEEKLY — RECOMENDACIÓN:** objetivos agregados de mayor amplitud que incentiven varias runs/días, no tareas artificialmente largas: completar varios recorridos/biomas, bosses, decisiones de gate o metas de ejército. Recompensa semanal puede ser más distintiva (cosmético/progreso) pero no necesaria para avanzar.

**STREAK/CALENDARIO — RECOMENDACIÓN:** NO construir en primera ola. Sólo probarlo si datos muestran retorno recurrente insuficiente pese a que runs/dailies funcionan. Si se prueba, streak por **día con gameplay cualificado**, no por login/claim, y con tolerancia a perder un día para evitar coerción.

## 7. Rewarded voluntario, cobro y anti-abuso
**HECHO/EVIDENCIA:** Google define rewarded como opt-in a cambio de reward. Google Play exceptúa rewarded explícitamente opt-in de ciertas reglas de anuncios disruptivos, aunque siguen aplicando políticas de audiencia/Families. #98 ya recomienda adapter desacoplado y no seleccionar proveedor antes del gate de audiencia.

**RECOMENDACIÓN:** primer placement a validar: **post-run, después de que el premio base esté garantizado**, opción “ver rewarded para aumentar una parte acotada del premio”. No bloquear `Cobrar` normal ni `Siguiente run`. No mostrar rewarded durante recorrido, gate, combate, boss, onboarding ni antes de empezar contenido.

Alternativa secundaria a testear después: un continue transparente tras derrota, sólo si no trivializa decisiones/dificultad. No lanzar ambos placements simultáneamente en el primer experimento.

**LÍMITES/ANTI-ABUSO:** reward idempotente por oportunidad; grant exactamente una vez tras callback válido; límite por run/placement configurable; no encadenar videos; disponibilidad del ad nunca bloquea premio base/progreso; registrar offer→accept→earned→claim; manejar cierre/fallo sin penalizar; server-side verification sólo si el riesgo/economía futura lo justifica. No se fija frecuencia numérica sin datos.

## 8. Dificultad y retry
**RECOMENDACIÓN:** escalar dificultad por composición, no sólo velocidad: decisiones +N/xN, ventanas/posición, secuencia de riesgo, densidad de obstáculo/enemigo, presión de combate y boss. La derrota debe ser atribuible a una decisión/acción legible. Retry debe volver rápido al gameplay; evitar pantallas de economía obligatorias entre fallo y retry.

**HIPÓTESIS A VALIDAR:** fallos donde el jugador entiende “perdí demasiados elfos aquí / elegí esta ruta” producen mejor retry que muertes por velocidad/ruido visual.

## 9. Funnel y analytics mínimos
**HECHO/EVIDENCIA:** Firebase ofrece eventos recomendados `level_start` y `level_end` (con success), y Google Play Games Events permite registrar acciones/progreso para analizar gameplay. Google Play Game Stats modela eventos como momentos de juego, finalización de runs y milestones, y explícitamente desaconseja estadísticas basadas en abrir app, compras o ver ads.

**RECOMENDACIÓN:** diseñar contrato de analytics provider-neutral; no integrar SDK en Prototipo 1 por esta investigación. Eventos mínimos futuros:
- `run_start` (route/biome/version)
- `first_meaningful_action` o hitos separados de onboarding
- `gate_crossed` (operation, operand bucket/config id, army_before/after)
- `army_loss` (cause/config id, before/after)
- `boss_reached`
- `run_end` (success/fail, fail_section, army_end, duration bucket)
- `reward_presented` / `reward_claimed`
- `progress_advanced` (system/id)
- `goal_progressed` / `goal_completed` (daily/weekly id)
- `next_run_started` (source/result-screen/goal/etc.)
- rewarded: `rewarded_offer`, `rewarded_accept`, `rewarded_earned`, `rewarded_failed/closed`.

Funnel diagnóstico: run_start → first gate/meaningful action → boss_reached → run_end → reward_claimed → next_run_started. Daily/weekly se analizan como caminos de retorno al run, no como fin en sí mismos. No definir targets D1/D7 hasta tener baseline real.

## 10. ROI — matriz de decisión

| FEATURE | IMPACTO ESPERADO | COSTO | RIESGO | PRIORIDAD | VALIDACIÓN NECESARIA | DECISIÓN |
|---|---|---|---|---|---|---|
| Army growth/loss readability + feedback | Alto hook/core | Medio | Bajo/medio Android | P0 | playtest + perf | CONSTRUIR PRIMERO |
| Gate/impact/hammer/snowball feedback | Alto core feel | Bajo/medio | Bajo | P0 | playtest | CONSTRUIR PRIMERO |
| Segundo recorrido/bioma reusable | Alto variedad/oferta | Medio | Medio | P0 | core validado + costo autoría | VALIDAR/CONSTRUIR tras P1 |
| Variación data-driven layout/ritmo/gates | Alto variedad por costo | Medio | Medio | P0 | comparar recorridos | CONSTRUIR DESPUÉS DEL CORE |
| Post-run claim/progress/next-run screen | Alto “una más” | Medio | Bajo | P0/P1 | replay funnel | CONSTRUIR tras validar run |
| Meta-loop mínimo / una recompensa fungible | Medio/alto | Medio | Medio | P1 | replay + comprensión | PROTOTIPAR DESPUÉS |
| Daily gameplay goals | Medio retorno | Medio | Medio | P1 | goal→next_run | PROBAR DESPUÉS DEL META MÍNIMO |
| Weekly gameplay goals | Medio retorno | Medio | Medio | P1 | varias sesiones | DESPUÉS DE DAILY |
| Rewarded post-run boost | Monetización con bajo corte del loop | Medio | Política/UX | P2 | audiencia + opt-in + funnel | TEST DESPUÉS DE ENGAGEMENT |
| Continue rewarded | Potencial retry/monetización | Medio | Alto balance | P2 | fracaso/retry primero | EXPERIMENTO SECUNDARIO |
| Streak/calendario | Incierto | Medio | Coerción/login-only | P2 | evidencia de necesidad | NO TODAVÍA |
| Múltiples monedas/crafting/gacha | Bajo/incierto ahora | Alto | Alto complejidad/policy/UX | P2 | fuerte evidencia futura | NO CONSTRUIR |
| Interstitials durante gameplay | Negativo UX/policy | Bajo | Alto | — | ninguna | NO CONSTRUIR |
| Gran catálogo de niveles antes de validar | Incierto | Alto | Alto sunk cost | — | core + pipeline + demand | NO CONSTRUIR |

## Propuesta concreta de producto post-Prototipo 1
Un runner navideño de ejército donde **el tamaño/composición visible de los elfos es el estado emocional y mecánico central**. Cada recorrido remezcla decisiones de crecimiento, riesgo, pérdida/recuperación y combate hasta boss. La capa persistente es ligera: desbloqueo de contenido + una recompensa simple + objetivos jugables. El resultado transforma lo ocurrido en premio/progreso y apunta directamente a la siguiente run. Monetización, si se autoriza tras audiencia/policy, empieza con rewarded post-run opcional que mejora un premio ya ganado, nunca sustituye jugar.

## Orden final
### 1. CONSTRUIR PRIMERO
Terminar Prototipo 1 ejecutable; validar legibilidad/satisfacción de ejército, gates, impactos, boss y retry; después instrumentar contrato mínimo y construir segundo recorrido reusable como prueba.

### 2. VALIDAR ANTES DE ESCALAR
Hook Santa+ejército; core feel; causas de fracaso; replay/next-run; costo marginal de recorridos; si premio/cobro realmente devuelve al gameplay; baseline de funnel. Resolver audiencia antes de ads.

### 3. CONSTRUIR DESPUÉS
Claim/progress/next-run compacto; meta-loop mínimo; daily gameplay goals; luego weekly; rewarded post-run sólo tras engagement y policy gates.

### 4. NO CONSTRUIR TODAVÍA
Streak/calendario, economía multi-moneda, crafting/gacha, energía, pay-to-progress, catálogo masivo, múltiples placements publicitarios, interstitials en gameplay, liveops/eventos complejos.

### 5. DECISIONES HUMAN PENDIENTES
- Audiencia objetivo/edad (heredada #98; bloquea monetización real, no esta investigación).
- Tras evidencia de Prototipo 1: aprobar identidad final de la recompensa fungible/cosmética y primer scope de contenido post-P1.
- Tras test de engagement: autorizar o rechazar rewarded post-run y su semántica exacta; proveedor se decide por spike #98, no aquí.

`READY_FOR_REVIEW=YES`
