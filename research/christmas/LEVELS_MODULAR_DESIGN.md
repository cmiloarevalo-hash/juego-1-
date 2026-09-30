# Investigación navideña — escenarios, etapas y niveles modulares

Work Item: #41

## Hipótesis de tres etapas
Aldea navideña, bosque nevado y fortaleza/hielo son **HYPOTHESIS**, no alcance aprobado.

## Alternativas de cantidad
- 1 etapa vertical slice: máxima concentración de pulido/medición.
- 2 etapas: demuestra reutilización y variación con coste moderado.
- 3 etapas: prueba progresión visual/ritmo y modularidad, mayor contenido/QA.
**UNKNOWN:** duración adecuada y cantidad óptima; no hay métrica de usuario ni presupuesto de producción que permita fijarlas.

## Estructura reusable de etapa
`Start -> Traversal -> Decision/Gate -> Obstacle -> Army mutation -> Encounter -> Recovery/Decision -> Final encounter/objective -> Result`.
Cada bloque es opcional y authored; no obliga boss.

## Hipótesis A — Aldea
Función: onboarding/lectura.
Módulos: calle/camino, casas genéricas propias, plaza, cercas/cajas, decoraciones, gate sockets.
Ritmo candidato: decisiones simples antes de combinar obstáculo+combat.
Riesgo originalidad: evitar composiciones/arquitectura reconocibles de una IP concreta.

## Hipótesis B — Bosque nevado
Función: rutas/ocultación/anchos variables.
Módulos: senderos, árboles/rocas, nieve, puentes/troncos genéricos, claros de combate.
Riesgos: overdraw/vegetación, oclusión de crowd/gates, siluetas enemigas sobre fondo.

## Hipótesis C — Fortaleza/hielo
Función: clímax visual/mecánico.
Módulos: murallas/puertas/plataformas de hielo, corredores, arena final.
Boss = opcional. Riesgos: materiales transparentes/reflexivos costosos y similitud con castillos de franquicias; diseño geométrico original.

## Bifurcaciones
Alternativas: lane A/B corta; desvío temporal que converge; rutas paralelas con herramienta/umbral; bifurcación visual sin cambio de scene.
**RECOMENDACIÓN:** convergencia authored reduce explosión combinatoria de QA para prototipo; HYPOTHESIS a validar.

## Authoring/data-driven
Reutiliza #10/ADR-004:
- LevelDefinition con stable ID;
- ordered SegmentDefinitions;
- sockets/referencias para gates, obstacles, encounters, camera;
- prefab/scene modules de presentación;
- runtime state separado;
- validator de IDs/referencias/orden/end.
No implementar todavía.

## Kit modular propuesto
PathSegment; Turn/WidthTransition; GateSocket; ObstacleSocket; EncounterZone; DecorationSocket; CameraZone; Start/End; RouteSplit/Merge; Boundary/Backdrop.
Los nombres son contratos conceptuales, no clases finales.

## Reutilización entre escenarios
Geometría lógica/colliders/sockets pueden compartir contrato; materiales/meshes/decoración cambian por tema. Esto permite identidad por escenario sin duplicar lógica.

## Mapa lógico de referencia
Start → tutorial traversal → Gate choice → obstacle → merge → encounter → Gate/route choice → themed challenge → final objective → Result.
La secuencia exacta y número de repeticiones = UNKNOWN.

## Métricas futuras
tiempo por segmento/etapa, errores de decisión, deaths/retries, army count distribution por checkpoint, camera readability, memory/load transition. No se fijan targets.

## Recomendación
Construir investigación/especificación para kit modular capaz de 1–3 etapas; decidir cantidad tras estimación de assets/animación (#42/#44), rendimiento (#46) y alcance humano. No codificar tres niveles por defecto.

## Decisiones humanas
cantidad de etapas; duración; boss; qué escenario(s) entran; streaming/loading vs escenas; bifurcación real; densidad de encuentros.
