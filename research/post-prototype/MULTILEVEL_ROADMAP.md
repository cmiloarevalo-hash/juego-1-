# Post-Prototipo 1 — arquitectura multi-level y roadmap

Consulta: 2026-10-05. Rama de investigación únicamente. No amplía Prototipo 1.

## Arquitectura propuesta
Mantener el núcleo de dominio actual (ArmyState, RunCoordinator, gates positivos, combat/boss/result) y convertir el contenido de recorrido en datos/composición. Un `LevelDefinition` futuro debería describir: identidad, biome/presentation profile, secuencia ordenada de route sections, tuning permitido, referencias de prefabs/presentation y boss profile. Un `LevelLoader/LevelSessionFactory` compone el mismo `GameSession` con la definición elegida. Las escenas/prefabs no deben poseer reglas de ejército, gates, derrota o resultado.

Separación recomendada:
- Core gameplay reusable: reglas invariantes.
- Level definition: datos y orden del recorrido.
- Presentation/biome profile: materiales, iluminación, decoración, audio y variantes visuales.
- Unity adapters: bindings reemplazables.
- Progression service: desbloqueo entre niveles; no modifica reglas de una run.
- Monetization service: fuera del core y nunca requisito para progresar durante una run.

## Recorridos/biomas candidatos
1. **Bosque boreal nocturno**: pinos, aurora, puentes helados; introduce mayor densidad visual y ventanas de decisión algo más cortas, sin crear gates negativos.
2. **Puerto/pueblo navideño nevado**: muelles, almacenes de regalos, hielo y faroles; alterna espacios estrechos/anchos para variar formación y lectura.
3. **Paso de montaña / taller del Polo**: túneles de hielo, talleres y aproximación monumental; dificultad por timing, composición y enemigos, no por nuevas reglas arbitrarias.

Progresión recomendada: aumentar gradualmente densidad, velocidad/timing, combinaciones de secciones y presión de combate. Mantener legibilidad Android. Nuevas mecánicas solo mediante decisión de producto independiente; primero extraer variación de parámetros, layouts, enemigos y presentación.

## Roadmap recomendado
P0: terminar y validar Prototipo 1 (Unity/runtime/APK/Samsung).
P1: extraer `LevelDefinition` + loader/factory y convertir Level 1 en primera definición sin cambiar comportamiento.
P2: crear Level 2 con assets reemplazables y validar que no requiera forks del core.
P3: progression/save mínimo y selección/desbloqueo de niveles.
P4: resolver audiencia objetivo/edad, privacidad y estrategia comercial.
P5: integrar `IMonetizationService` con implementación Null/Fake; pruebas.
P6: seleccionar mediación/proveedor, integrar solo test ads y consentimiento aplicable.
P7: experimento controlado de rewarded opt-in; medir UX, fill, crashes, ANR y economía antes de ampliar formatos.

## Riesgos
- Arquitectura: convertir diferencias de contenido en condicionales dentro del core crea deuda; mitigación: data-driven definitions + adapters.
- Android: más biomas/assets aumentan memoria, tamaño y GPU; presupuestar por nivel y perfilar en hardware real.
- Diseño: dificultad basada solo en velocidad puede degradar legibilidad; variar composición antes que velocidad extrema.
- Comercial: fill/eCPM dependen de geografía, audiencia, consentimiento y demanda; no proyectar ingresos sin datos.
- UX: rewarded mal ubicado puede sentirse obligatorio; recompensa nunca debe bloquear la ruta principal.
- Política: audiencia infantil/mixta cambia SDKs, targeting y formatos permitidos; resolver antes de integrar producción.

## Decisiones Human pendientes
1. Audiencia objetivo declarada: adultos/teen, mixta o incluye niños.
2. Prioridad de biomas y cantidad de niveles para el primer paquete post-prototipo.
3. Economía/recompensas permitidas para rewarded (sin pay-to-progress obligatorio).
4. Proveedor/mediación solo después de evaluación técnica/política con datos reales.
