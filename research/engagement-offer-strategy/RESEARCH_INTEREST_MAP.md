# RESEARCH INTEREST MAP — Issue #99 / Fase 1

Estado: mapa de interés solamente. No contiene benchmark profundo ni conclusiones definitivas.
Autoridad: checkpoint Supervisor #6006546233.
Rama: `research/engagement-offer-strategy`.

## Regla de prioridad
- **P0**: puede cambiar materialmente qué juego construimos, qué produce engagement, nuestra diferenciación, la oferta necesaria o dónde invertir desarrollo.
- **P1**: decisión importante de diseño/medición que concreta o valida una dirección P0, pero no debería redefinir por sí sola la propuesta completa.
- **P2**: optimización/guardrail posterior; útil una vez resueltas las decisiones P0/P1.

Las hipótesis siguientes son hipótesis de trabajo a contrastar, no conclusiones.

## P0 — decisiones que pueden cambiar el producto o la inversión

### 1. HOOK / PROMESA CENTRAL — P0
**DECISIÓN A TOMAR ->** Qué fantasía y promesa debe comunicar el juego en sus primeros segundos y qué elemento debe dominar producción/presentación.
**PREGUNTA ->** ¿Santa liderando un ejército de elfos que crece visiblemente y sobrevive hasta un payoff navideño se percibe como una fantasía diferenciada y deseable, o como un crowd runner genérico con skin?
**EVIDENCIA NECESARIA ->** Primeros segundos y store creatives de comparables; patrones de promesa visual; señales públicas de recepción; test futuro de comprensión/atracción con jugadores.
**COMPARABLE/FUENTE ->** Crowd runners y runners con crecimiento/ejército/combat; Play Store, creatividades oficiales, páginas de producto y observación directa del onboarding cuando sea accesible.
**HIPÓTESIS ACTUAL ->** El ejército visible de elfos y el liderazgo de Santa pueden ser el núcleo del hook si crecimiento, pérdida y payoff se leen inmediatamente; Navidad sola no basta.
**CRITERIO DE DECISIÓN ->** Priorizar esta promesa si puede expresarse visualmente en segundos, distingue el juego de comparables y conecta directamente con acciones repetidas del core loop sin requerir sistemas externos.

### 2. SENSACIÓN MOMENTO A MOMENTO — P0
**DECISIÓN A TOMAR ->** En qué interacciones audiovisuales/mecánicas invertir primero para que la run sea satisfactoria en Android.
**PREGUNTA ->** ¿Qué combinación de control, cámara, crecimiento del ejército, gate feedback, pérdida de elfos, snowball, impacto, hammer, boss y resultado produce mayor satisfacción percibida por costo/riesgo técnico razonable?
**EVIDENCIA NECESARIA ->** Descomposición de feedback de comparables, frecuencia de cada interacción, costo aproximado de implementación, carga visual/performance y posterior playtest del prototipo.
**COMPARABLE/FUENTE ->** Crowd runners, runner-combat y juegos móviles de acción simple; capturas/gameplay oficiales y builds propias cuando existan.
**HIPÓTESIS ACTUAL ->** Crecimiento/pérdida legible del ejército, gate feedback e impactos claros probablemente tienen mejor retorno inicial que VFX complejos o sistemas secundarios.
**CRITERIO DE DECISIÓN ->** Invertir primero en interacciones frecuentes que mejoren legibilidad + satisfacción y puedan ejecutarse con presupuesto Android estable; posponer polish caro con baja frecuencia.

### 4. CORE LOOP DE UNA RUN — P0
**DECISIÓN A TOMAR ->** Qué secuencia y ritmo constituyen la unidad jugable repetible que debe sobrevivir a múltiples recorridos.
**PREGUNTA ->** ¿Dónde aparecen tensión, anticipación, elección y payoff dentro de crecer -> decidir -> arriesgar/perder -> recuperar/aumentar -> combatir -> boss, y qué segmentos se vuelven relleno?
**EVIDENCIA NECESARIA ->** Estructura/ritmo de runs comparables, densidad de decisiones, duración entre payoffs, variación de estados del jugador y futuro playtest segmentado.
**COMPARABLE/FUENTE ->** Crowd runners con gates, runner-combat, boss runners; observación de gameplay y estructura de niveles.
**HIPÓTESIS ACTUAL ->** El loop será más defendible si el tamaño del ejército cambia el riesgo y el combate, haciendo que gates/pérdidas tengan consecuencias visibles hasta el boss.
**CRITERIO DE DECISIÓN ->** Conservar sólo segmentos que cambien decisión, riesgo, estado del ejército o payoff; reducir segmentos cuya eliminación no altere tensión ni comprensión.

### 5. RAZÓN PARA “UNA MÁS” — P0
**DECISIÓN A TOMAR ->** Qué motivador post-run justifica construir meta-progresión/contenido adicional y de qué tipo.
**PREGUNTA ->** ¿La repetición debe apoyarse principalmente en mastery/variedad del siguiente recorrido o necesita desbloqueos, colección/cosméticos u otra progresión persistente?
**EVIDENCIA NECESARIA ->** Estructuras post-run de comparables, frecuencia y claridad de objetivos, relación entre contenido y recompensa; posteriormente comportamiento de replay/next-level de jugadores.
**COMPARABLE/FUENTE ->** Runners/crowd runners con y sin meta-loop; Play Store, gameplay y sistemas visibles de progresión.
**HIPÓTESIS ACTUAL ->** Un siguiente recorrido claramente distinto + progreso ligero puede ser más coherente que una economía profunda; la diversión de la run debe sostener el replay antes de añadir capas.
**CRITERIO DE DECISIÓN ->** Añadir meta-loop sólo si resuelve una razón observable para volver que la variedad/mastery no cubre y si su costo no supera el de mejorar el core.

### 6. OFERTA COMPETITIVA REAL — P0
**DECISIÓN A TOMAR ->** Qué oferta mínima debe igualar/superar expectativas del segmento y qué features no necesitamos copiar.
**PREGUNTA ->** ¿Qué reciben realmente los jugadores en comparables actuales en variedad, duración, contenido, progresión, bosses, cosméticos, rewards, eventos y monetización?
**EVIDENCIA NECESARIA ->** Matriz comparable homogénea con features observadas, sesión/estructura, contenido efectivo y monetización; señales públicas de escala/actualización cuando sean confiables.
**COMPARABLE/FUENTE ->** Play Store y materiales oficiales de una muestra acotada de competidores directos/adyacentes; gameplay verificable.
**HIPÓTESIS ACTUAL ->** La oferta defendible depende más de variedad percibida + loop + progreso que de un número bruto de niveles.
**CRITERIO DE DECISIÓN ->** Adoptar sólo elementos competitivos que cubran una expectativa recurrente o una carencia estratégica demostrable; no perseguir paridad feature-for-feature.

### 7. REPETICIÓN VS VARIEDAD — P0
**DECISIÓN A TOMAR ->** Qué dimensiones reutilizables deben constituir el sistema de contenido multi-level y recibir inversión.
**PREGUNTA ->** ¿Qué variaciones —layout, ritmo, gates +N/xN, riesgo/recompensa, obstáculos, enemigos, formación, timing, boss, bioma— cambian realmente la experiencia usando el mismo núcleo?
**EVIDENCIA NECESARIA ->** Taxonomía de variación en comparables, costo marginal por dimensión y capacidad de combinar variaciones sin nuevas mecánicas completas.
**COMPARABLE/FUENTE ->** Runners de múltiples niveles/mundos; gameplay, mapas/recorridos observables y documentación propia #98 sobre arquitectura multi-level.
**HIPÓTESIS ACTUAL ->** Layout/ritmo + composición de riesgo + presentación/bioma probablemente ofrecen más variedad por costo que crear una mecánica nueva por nivel.
**CRITERIO DE DECISIÓN ->** Priorizar dimensiones combinables, legibles y baratas de autorar que produzcan diferencias perceptibles sin fragmentar el core.

### 10. IDENTIDAD / DIFERENCIACIÓN — P0
**DECISIÓN A TOMAR ->** Qué partes de la identidad navideña deben ser estructurales y cuáles meramente visuales.
**PREGUNTA ->** ¿Cómo pueden Santa, elfos, nieve, aldea/taller, aurora, regalos y ejército reforzar decisiones/payoffs del core sin convertirse en scope creep?
**EVIDENCIA NECESARIA ->** Análisis de identidad mecánica vs skin en comparables, memorabilidad de store proposition y costo de integrar motivos navideños al loop existente.
**COMPARABLE/FUENTE ->** Juegos temáticos con identidad mecánica fuerte, crowd runners temáticos y materiales oficiales/Play Store.
**HIPÓTESIS ACTUAL ->** Santa + ejército de elfos puede diferenciar si la identidad explica crecimiento, pérdida, combate y recompensa; decorado navideño aislado tiene menor valor defensible.
**CRITERIO DE DECISIÓN ->** Convertir un motivo temático en inversión prioritaria sólo cuando refuerce al menos una acción/core payoff y mejore reconocimiento sin exigir un subsistema desproporcionado.

### 12. OFERTA INICIAL / ESCALA DE CONTENIDO — P0
**DECISIÓN A TOMAR ->** Cuántos mundos/recorridos/variaciones hacen defendible una primera oferta post-prototipo y cuándo detener producción de contenido para validar.
**PREGUNTA ->** ¿Qué escala mínima entrega variedad percibida suficiente sin asumir 3/30/100 niveles por intuición?
**EVIDENCIA NECESARIA ->** Oferta efectiva de comparables, duración/repetibilidad, costo marginal estimado por recorrido/bioma, tasa de reutilización de sistemas y evidencia futura de replay/agotamiento.
**COMPARABLE/FUENTE ->** Play Store/gameplay de comparables + estimaciones internas basadas en arquitectura #98 y producción real tras Prototipo 1.
**HIPÓTESIS ACTUAL ->** Debe definirse un lote pequeño pero variado y un gate de validación antes de escalar masivamente contenido.
**CRITERIO DE DECISIÓN ->** Escalar sólo cuando cada nueva unidad tenga costo marginal controlado y la evidencia muestre que variedad/contenido, no el core, es el cuello de botella de engagement.

### 14. RETORNO DE INVERSIÓN DE DESARROLLO — P0
**DECISIÓN A TOMAR ->** Orden de inversión post-Prototipo 1 y lista explícita de mejoras a posponer.
**PREGUNTA ->** ¿Qué mejoras tienen mayor impacto esperado en hook, engagement, diferenciación u oferta por unidad de costo, complejidad y riesgo Android?
**EVIDENCIA NECESARIA ->** Resultado de las líneas P0/P1, estimación cualitativa de costo/dependencias/riesgo, frecuencia de exposición al jugador y evidencia futura de comportamiento.
**COMPARABLE/FUENTE ->** Síntesis de este research, backlog técnico real, métricas/playtests futuros y restricciones Android.
**HIPÓTESIS ACTUAL ->** Core feel/legibilidad, variedad reusable e identidad integrada deberían superar inicialmente a metagame profundo, VFX caros o gran volumen de contenido.
**CRITERIO DE DECISIÓN ->** Priorizar mejoras con alta exposición e impacto, reutilización amplia y riesgo bajo/medio; exigir evidencia más fuerte a inversiones costosas, permanentes o periféricas.

## P1 — decisiones que concretan/validan la dirección

### 3. TIME-TO-FUN / PRIMERA SESIÓN — P1
**DECISIÓN A TOMAR ->** Ritmo del onboarding y orden temporal de los primeros payoffs.
**PREGUNTA ->** ¿Cuánto puede tardar el jugador en controlar, crecer, elegir un gate, enfrentar peligro y recibir un payoff sin explicación pesada?
**EVIDENCIA NECESARIA ->** Cronometraje de onboarding comparable, acciones antes de texto/tutorial, futuros tests de comprensión y abandono por segmento.
**COMPARABLE/FUENTE ->** Onboarding de runners/casual action; gameplay oficial/observado y playtests propios.
**HIPÓTESIS ACTUAL ->** Control y crecimiento deben demostrarse por acción casi inmediatamente; instrucciones textuales deberían ser mínimas.
**CRITERIO DE DECISIÓN ->** Elegir el flujo que logre comprensión observable con menos pasos/tiempo sin sacrificar control ni lectura de la primera decisión.

### 8. PROGRESIÓN / META-LOOP — P1
**DECISIÓN A TOMAR ->** Si implementar persistencia entre runs y cuál es su forma mínima.
**PREGUNTA ->** ¿Desbloqueo de recorridos/mundos, regalos/estrellas, cosméticos, colección u objetivos agregan motivación suficiente sin economía innecesaria/pay-to-progress?
**EVIDENCIA NECESARIA ->** Patrones de progresión en comparables, relación con variedad y replay, costo de implementación/contenido y futura respuesta de usuarios.
**COMPARABLE/FUENTE ->** Runners/casual games con meta ligera; #98 para separación arquitectónica post-prototipo.
**HIPÓTESIS ACTUAL ->** Desbloqueo claro de contenido y/o colección ligera puede bastar; economía profunda no está justificada todavía.
**CRITERIO DE DECISIÓN ->** Implementar la mínima persistencia que cree objetivo futuro comprensible y medible; rechazar capas que existan principalmente para sostener monetización.

### 9. DIFICULTAD Y FRACASO — P1
**DECISIÓN A TOMAR ->** Cómo escalar desafío y diseñar retry justo dentro del core elegido.
**PREGUNTA ->** ¿Qué mezcla de decisiones matemáticas, posicionamiento, riesgo, ejército acumulado, timing y combate aumenta dificultad sin depender sólo de velocidad?
**EVIDENCIA NECESARIA ->** Curvas/patrones de dificultad comparables, causas visibles de derrota, tiempo a retry, futuros datos de fallos por sección.
**COMPARABLE/FUENTE ->** Runners con gates/obstáculos/combat y playtests propios.
**HIPÓTESIS ACTUAL ->** Dificultad multivariable con consecuencias legibles será más justa que subir velocidad global; retry debe ser rápido.
**CRITERIO DE DECISIÓN ->** Aceptar aumentos de dificultad cuando el jugador pueda atribuir el fallo a una decisión/acción legible y reintentar sin fricción excesiva.

### 11. RETENCIÓN MEDIBLE — P1
**DECISIÓN A TOMAR ->** Qué eventos/comportamientos medir para validar hook/core/oferta antes de escalar.
**PREGUNTA ->** ¿Qué señales observables permiten diagnosticar dónde se pierde interés sin convertir objetivos D1/D7 en promesas arbitrarias?
**EVIDENCIA NECESARIA ->** Funnel propuesto: onboarding completion, first gate, boss reach, run completion, replay/next-level, session depth y retorno; definición de eventos y cohortes cuando exista instrumentación autorizada.
**COMPARABLE/FUENTE ->** Prácticas de analítica de juegos como referencia metodológica y datos propios futuros como autoridad de producto.
**HIPÓTESIS ACTUAL ->** Funnel de progreso + replay inmediato + profundidad de sesión dará diagnóstico inicial más accionable que una única métrica agregada.
**CRITERIO DE DECISIÓN ->** Instrumentar sólo señales ligadas a una decisión de producto concreta y establecer targets después de obtener baseline propio, no antes.

## P2 — guardrail/optimización posterior

### 13. MONETIZACIÓN SIN DESTRUIR ENGAGEMENT — P2
**DECISIÓN A TOMAR ->** Cuándo habilitar monetización post-Prototipo 1 y qué intercambio voluntario de valor probar primero.
**PREGUNTA ->** ¿Qué rewarded placement aporta valor sin cortar el recorrido ni distorsionar progreso/dificultad?
**EVIDENCIA NECESARIA ->** Heredar arquitectura/política/proveedores de #98; mapear pausas naturales y valor de rewards; más adelante medir aceptación, completion y efecto en replay/session flow.
**COMPARABLE/FUENTE ->** Evidencia durable de #98 y, sólo si cambia la decisión de placement, comparables con rewarded opt-in.
**HIPÓTESIS ACTUAL ->** Rewarded voluntario en pausas naturales post-run/entre contenido es más compatible que interrupciones durante recorrido, gates, combate o boss.
**CRITERIO DE DECISIÓN ->** No monetizar hasta demostrar engagement básico; aceptar un placement sólo si es voluntario, comprensible, policy-compliant y no deteriora el core ni vuelve obligatorio el reward.

## Resumen de priorización
- **P0 (9):** 1 Hook/promesa; 2 sensación momento a momento; 4 core loop; 5 razón para una más; 6 oferta competitiva; 7 repetición vs variedad; 10 identidad/diferenciación; 12 oferta inicial/escala; 14 ROI de desarrollo.
- **P1 (4):** 3 time-to-fun; 8 meta-loop; 9 dificultad/fracaso; 11 retención medible.
- **P2 (1):** 13 monetización sin destruir engagement.

## Gate de Fase 1
Este documento define qué investigar y qué decisión habilitaría la evidencia. No ejecuta la investigación profunda, no selecciona comparables definitivos y no convierte las hipótesis en decisiones. Fase 2 requiere revisión/autorización Supervisor.
