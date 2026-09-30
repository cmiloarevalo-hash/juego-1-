# Investigación navideña — armas, herramientas, obstáculos y destrucción

Work Item: #40

## Criterio
Las opciones son mecánicas originales basadas en arquetipos genéricos. Ninguna queda aprobada por aparecer aquí.

| Herramienta | Objetivo/efecto candidato | Ejército | Obstáculo | Feedback | Complejidad | Evidencia/referencia | Recomendación |
|---|---|---|---|---|---|---|---|
| bastón/candy-cane genérico | melee corto / empuje | líder o primera línea | enemigos/objetos ligeros | arco/impacto | baja-media | #8 contratos combat | evaluar como baseline visual propio |
| martillo de juguetero | golpe pesado | líder/unidad especial | cajas/barreras frágiles | anticipación + fractura/VFX | media | #8 + destrucción stateful | buen candidato herramienta↔obstáculo |
| hacha genérica | corte | rol especializado | madera/ramas | corte/astillas | media | arquetipo funcional | riesgo visual de violencia/tono; decisión humana |
| bolas de nieve | proyectil | Santa/elfo ranged | enemigos/targets | trayectoria/impacto nieve | media | #8 targeting | diferenciación navideña genérica; evaluar |
| ariete/trineo | romper/embestir | requiere grupo o pickup | barrera pesada | carga/choque | media-alta | gate/army threshold concept | interesante para decisión colectiva; no baseline |
| campana/estrella mágica original | pulso/aturdir/activar | no consume count | mecanismo/target | onda/VFX | media | diseño original HYPOTHESIS | alternativa no bélica |

## Taxonomía de obstáculos
1. **Destructible frágil:** una interacción válida lo elimina.
2. **Destructible con resistencia:** health/impact threshold; aumenta estado/combat.
3. **Indestructible geométrico:** fuerza desvío/compresión.
4. **Peligro temporal:** patrón/telegraph; daño o pérdida si falla.
5. **Bloqueo condicional:** herramienta o count mínimo.
6. **Bifurcación:** dos rutas con trade-off explícito.
7. **Obstáculo móvil:** requiere timing; mayor coste de física/legibilidad.

## Modelo de interacción recomendado
**INFERENCE:** separar `ToolCapability` de `ObstacleRequirement` evita hardcodear pares concretos. Resultado candidato:
`contact/query -> validate capability -> resolve authored effect -> obstacle state change -> army/tool consequence -> feedback`.
Esto es especificación conceptual, no clase/código.

## Destrucción
Alternativas:
- swap de mesh/estado intacto→roto;
- piezas prefracturadas activadas;
- física/ragdoll-like debris temporal;
- shader/VFX sin geometría física.
**RECOMENDACIÓN:** para móvil, comparar swap/prefracturado con debris físico mediante #46; no afirmar ganador sin medición.

## Reglas de seguridad de diseño
- herramienta necesaria debe anunciarse antes del compromiso;
- no crear soft-lock sin ruta/resultado definido;
- feedback visual no depender sólo de color;
- destrucción no debe cambiar count dos veces por callbacks múltiples;
- pooled obstacle debe resetear estado/fragmentos;
- proyectil perdido no debe conservar target pooled stale.

## Casos límite
herramienta cambia al entrar; dos herramientas golpean mismo objeto; ejército cae bajo umbral durante carga; obstáculo destruido recibe segundo hit; fragmentos bloquean gate; ruta condicional sin herramienta; proyectil impacta tras resultado; pool reutiliza obstáculo roto.

## Coste relativo cualitativo
LOW: interacción instantánea sin proyectil/física persistente.
MEDIUM: windup, estado destructible, VFX, targeting simple.
HIGHER: proyectiles numerosos, fragmentos físicos, obstáculos móviles, herramienta colectiva con sincronización.
Estas categorías son **INFERENCE**, no benchmark.

## Recomendación de prototipo
Evaluar un conjunto pequeño que cubra tres verbos distintos: combate, romper, evitar. Candidatos para playtest: bastón o bola de nieve (combat), martillo (romper), obstáculo indestructible/peligro (evitar). **HYPOTHESIS**, requiere decisión humana y #44/#45 assets/legibilidad.

## Experimentos
EXP-XMAS-OBS-001: comparar swap/prefracturado/debris físico con mismo obstáculo; medir CPU Physics, active rigidbodies, GPU/draws, allocations, claridad. NOT RUN.
EXP-XMAS-OBS-002: playtest de comprensión herramienta→obstáculo sin texto vs icono+forma; registrar acierto/error. NOT RUN.

## Decisiones pendientes
set de herramientas; si son pickups/equipamiento/roles; daño vs utilidad; destrucción física; violencia/tono; requisitos de ruta; consumo/cooldown.
