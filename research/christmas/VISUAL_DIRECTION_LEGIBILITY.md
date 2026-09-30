# Investigación navideña — dirección visual y legibilidad móvil

Work Item: #45

## Direcciones comparadas
### A — Low-poly geométrico cálido
Formas grandes, bevels simples, materiales opacos, detalle por silueta/accesorio.
Pros: compatible con crowd y assets CC0 modificables; lectura a distancia. Riesgo: apariencia genérica si se usan packs sin transformación.

### B — Toy-diorama
Proporciones de juguete, superficies mate/plástico/madera, entorno como maqueta.
Pros: conecta taller/navidad y herramientas. Riesgo: demasiada microdecoración/reflectividad.

### C — Stylized storybook 3D
Formas redondeadas, gradientes/textura pintada, VFX suaves.
Pros: identidad fuerte. Riesgo: mayor coste de arte/shader/consistencia.

**RECOMENDACIÓN DE INVESTIGACIÓN:** A+B híbrido como baseline de prototipo: geometría low-poly propia/modificada + lenguaje de juguete/taller. No es dirección final aprobada.

## Siluetas
Santa: ancho/alto distinguible del crowd; ayudantes más pequeños/triangulares; enemigos por masas distintas (cuadrado pesado, alto/estrecho, redondo). Arma/herramienta debe extender silueta de forma legible.
**INFERENCE:** variación cosmética dentro del crowd debe ser secundaria a la lectura aliado/enemigo.

## Color/material
No depender sólo rojo=aliado/verde=enemigo. Usar combinación de silueta, valor/luminancia, material/accesorio, iconografía y movimiento.
Nieve clara exige contornos/valores suficientemente separados; hielo transparente/reflectivo debe usarse selectivamente por coste y lectura.

## Gates
Regla propuesta: operación grande + símbolo (+,−,×) + valor + forma/borde diferenciable. Evitar codificar signo únicamente por color. La traducción no debe cambiar símbolos matemáticos sin necesidad.

## Obstáculos/herramientas
Pares funcionales deben compartir lenguaje de forma/icono: martillo↔barrera fracturable, bola de nieve↔target ranged, etc., sin exigir memorizar color. Destructible debe tener estado intacto/dañado claro.

## Combat/VFX
VFX cortos, localizados y jerarquizados: hit, death, tool impact, gate mutation y result no compiten simultáneamente. Evitar partículas blancas sobre nieve sin contraste/shape.
Damage authority permanece en dominio; VFX sólo feedback.

## Cámara
Reutiliza #10: look-ahead a decisiones, framing de crowd, overrides authored. **HYPOTHESIS:** cámara ligeramente elevada favorece lectura de formation/gates, pero ángulo/FOV deben probarse en dispositivo y no se fijan aquí.

## HUD
Priorizar: army count/estado crítico, pausa, resultado; tool indicator sólo si mecánica aprobada.
Texto breve y escalable; no hornear ES/EN en texturas salvo arte localizado deliberado.
**VERIFIED FACT (Unity Localization docs):** tablas mantienen entradas por locale y claves/IDs estables; soportan strings y assets localizados.
**VERIFIED FACT (W3C WCAG 1.4.3, referencia de accesibilidad web):** texto normal usa 4.5:1 y texto grande 3:1 como criterio AA. **INFERENCE:** usar estos valores como referencia conservadora para HUD textual, no como afirmación de requisito normativo del juego.

## Español/inglés
- claves semánticas, no texto hardcoded;
- probar expansión de strings y plural;
- incluir á/é/í/ó/ú/ü/ñ/¿/¡ en cobertura de fuente;
- evitar layouts que dependan de longitud inglesa;
- pseudo-localization/overflow test si paquete seleccionado lo soporta.

## Reglas de originalidad
1. No Grinch ni equivalente visual reconocible.
2. No copiar composición/paleta/UI de un juego de referencia.
3. Santa/elfos deben tener model sheet propio antes de final art.
4. Assets de packs se transforman/recombinan; no usar escena demo como nivel.
5. Mantener registro de fuente/licencia de cada pieza.
6. Revisar side-by-side de silueta/UI/boss contra referencias antes de aprobación.

## Pruebas propuestas
VIS-001 screenshot downscaled al tamaño físico objetivo: identificar aliado/enemigo/gate/obstáculo sin color. NOT RUN.
VIS-002 grayscale + simulaciones de deficiencia de color: comprensión de gates/HUD. NOT RUN.
VIS-003 crowd stress screenshots con variación de count/camera: medir occlusion de Santa/gate/telegraph. NOT RUN.
VIS-004 ES/EN string expansion/font glyph audit. NOT RUN.
VIS-005 A/B de A vs A+B vs C con criterios legibilidad, coste estimado por asset y originalidad. NOT RUN.

## Decisiones humanas
dirección A/B/C; palette/material language; grado de estilización; cámara/FOV; HUD final; nivel de VFX; fuente; art budget y qué assets #44 pasan a producción.
