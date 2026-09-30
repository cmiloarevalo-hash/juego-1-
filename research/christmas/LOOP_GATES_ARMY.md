# Investigación navideña — loop, gates y reglas del ejército

Work Item: #39
Estado de evidencia: investigación; no implementación.

## Reutilización de evidencia previa
Se reutilizan #6 (input/crowd/formación), #7 (gates/mutación), #8 (combate/resultado), #9 (performance) y #10 (nivel/UX). Esos artefactos ya separan evidencia observable de Top Lords de diseño propio. La temática navideña no altera por sí sola los contratos técnicos.

## Loop candidato
**INFERENCE / RECOMENDACIÓN DE INVESTIGACIÓN:** para un prototipo sin metajuego, el loop mínimo coherente es:
`Inicio de etapa -> carrera/control lateral -> decisión de ruta/gate/obstáculo -> mutación/formación -> encuentro/combat -> continuación -> condición final -> resultado/reintento/siguiente etapa`.

Esto no aprueba cantidad de etapas, boss ni armas concretas.

## Input/runner
**SOURCE CLAIM (TL-001/TL-002, investigación previa):** la referencia observable soporta control simple/lateral y decisiones de camino.
**VERIFIED FACT (Unity docs previas + documentación móvil):** Android dispone de touch; el límite/semántica exacta debe fijarse con la versión de Input System del proyecto.
**RECOMENDACIÓN:** abstracción de intención lateral continua; evitar que gameplay dependa directamente de API táctil. Permite pruebas y cambio de paquete.

## Ejército navideño
Identidad propuesta: Santa = líder visual; ayudantes/elfos = unidades lógicas/visuales originales.
**RECOMENDACIÓN:** una sola magnitud lógica de ejército para el prototipo base; variantes cosméticas/roles no deben alterar el conteo salvo decisión explícita.
Reglas candidatas:
- count entero no negativo;
- mutación de gate atómica/idempotente;
- muerte/reducción usa el mismo dominio de ejército;
- presentación/pool no es autoridad;
- formación se recalcula tras mutación;
- resultado captura survivors/count una sola vez.

## Gates — alternativas
| Familia | Ejemplo abstracto | Ventaja | Riesgo/decisión |
|---|---|---|---|
| aditivo | +N / -N | lectura inmediata | valores/negativos |
| multiplicativo | ×K | decisión de alto impacto | crecimiento explosivo/capacidad |
| porcentual | ±P% | escala con ejército | redondeo |
| elección funcional | ruta segura vs herramienta/recurso | variedad | introduce otro estado |
| condición | requiere umbral/herramienta | táctica | complejidad/soft-lock |

**RECOMENDACIÓN:** prototipo inicial debe evaluar aditivo + multiplicativo como baseline de legibilidad; porcentual/condicional quedan alternativas. Valores, caps y rounding = **UNKNOWN / decisión humana**.

## Formación
Alternativas heredadas #6: slots deterministas; slots + corrección local; steering orgánico; navegación por unidad.
**RECOMENDACIÓN:** mantener slots deterministas como hipótesis baseline porque facilita gates, lectura y pruebas; backend de movimiento sigue pendiente de experimento/performance #46.

## Decisiones durante carrera
- gate A/B con resultado visible;
- desvío por obstáculo;
- herramienta/arma que habilita una ruta;
- riesgo de combate vs ruta más segura.
**HYPOTHESIS:** demasiados tipos simultáneos reducen legibilidad móvil; medir con prueba de usuario, no asumir.

## Combate
Reutiliza #8: targeting/damage/death originales; no se conoce algoritmo propietario.
Alternativas: contacto frontal/local; radius targeting; slot/lane pairing; resolución agregada.
**RECOMENDACIÓN:** encuentros cortos con política determinista/local como baseline de investigación. Boss = no aprobado.

## Victoria/derrota/resultado
Alternativas:
1. llegar al final con ≥1 unidad/Santa vivo;
2. derrotar encuentro final;
3. objetivo de etapa explícito.
Derrota: ejército llega a cero, Santa cae, o condición authored.
**DECISIÓN PENDIENTE:** cuál es autoridad de derrota cuando Santa y ejército se modelan por separado.
Resultado mínimo recomendado: estado victoria/derrota, count/survivors, decisiones relevantes para telemetría de prueba; sin economía/metajuego.

## Casos límite
- gate dispara dos veces;
- ×0, negativo, overflow/cap;
- dos gates solapados;
- unidad muere durante mutación;
- ejército cero antes/después del gate;
- formación sin espacio;
- ruta bloqueada sin alternativa;
- herramienta requerida no disponible;
- último aliado y último enemigo mueren mismo tick;
- resultado emitido dos veces;
- input durante transición/resultado;
- representación pooled desincronizada del count.

## Experimentos propuestos
EXP-XMAS-LOOP-001: prueba de legibilidad de decisión A/B con gate aditivo vs multiplicativo; registrar comprensión/errores/tiempo de decisión. NOT RUN.
EXP-XMAS-LOOP-002: estabilidad visual de formación tras secuencia de crecimiento/reducción en anchos de corredor representativos. Medir crossings, tiempo de asentamiento y errores de ownership. NOT RUN.

## Decisiones humanas pendientes
- cantidad y fórmula de gates;
- si Santa tiene salud independiente;
- condición final/boss;
- tamaño/cap del ejército;
- ritmo/duración;
- si herramientas alteran count o sólo interacción.
