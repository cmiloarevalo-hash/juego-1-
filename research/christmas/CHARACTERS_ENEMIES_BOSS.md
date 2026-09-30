# Investigación navideña — personajes, enemigos y boss original

Work Item: #42

## Restricción de originalidad
Santa/elfos/navidad se usan como arquetipos generales con expresión propia. **DO_NOT_REUSE:** Grinch, silueta/rostro/vestuario/composición distintiva de terceros, nombres/escenarios/UI reconocibles de franquicias.

## Roster funcional mínimo — alternativas
### Santa
Rol candidato: líder/anchor visual, no necesariamente unidad de combate independiente.
Silueta propia: volumen amplio + saco/herramienta original; evitar dependencia exclusiva rojo/verde para identificación.
Decisión pendiente: invulnerable/health propia/representa al army.

### Ayudantes/elfos
Baseline recomendado: una familia humanoide con variación modular (cabeza/accesorio/material) antes de crear rigs distintos.
Roles opcionales: runner básico; melee; ranged/tool specialist. **HYPOTHESIS:** múltiples roles elevan claridad/animación/combat complexity y no son necesarios para probar el loop.

### Enemigos originales
Familias funcionales, no personajes de IP:
- juguete mecánico descontrolado: blocker/melee;
- muñeco de nieve construido como guardián: pesado/ranged snow;
- criatura de hielo abstracta: hazard/area;
- autómata de taller: shield/breakable.
Nombres/diseños finales = pendientes. Cada familia debe diferenciarse por silueta/movimiento, no sólo color.

## Rig y animación
**VERIFIED FACT (Unity Manual):** Humanoid Avatar permite retargeting entre modelos humanoides con mapeo válido; un rigged/skinned humanoid es requisito del flujo humanoid.
Fuentes primarias consultadas 2026-09-30:
- https://docs.unity3d.com/Manual/ConfiguringtheAvatar.html
- https://docs.unity3d.com/Manual/AnimationOverview.html
**INFERENCE:** Santa, ayudantes y enemigos humanoides compatibles podrían compartir una biblioteca de locomoción/acciones mediante retargeting, pero diferencias extremas de proporción/equipamiento requieren prueba visual y corrección.

## Set de animaciones candidato
Común: idle, locomotion/run, hit reaction, death, celebrate/defeat.
Herramienta: windup/attack/recover por familia de arma; ranged throw/release.
Boss: locomotion/idle + telegraph/attack/recover/hit/death por ataque.
No se aprueba cantidad de clips; eventos de gameplay no deben depender únicamente del frame de animación (#8).

## Boss — valor/coste
Valor potencial: clímax, prueba combat/telegraph, identidad.
Costes adicionales: diseño único, rig/animaciones, VFX/audio, cámara, arena, AI/state machine, balance, QA, performance y fail/retry.
Alternativas:
A. sin boss: encuentro final de tropas/objetivo;
B. boss grande simple: 1 patrón + vulnerabilidad clara;
C. boss por fases;
D. boss + adds.
**RECOMENDACIÓN:** A/B son alternativas de prototipo; C/D sólo si alcance/tiempo/asset budget lo justifican. No declarar boss aprobado.

## Mecánicas originales de boss candidatas
- guardián de hielo que telegraph golpe y abre ventanas;
- máquina de regalos averiada con módulos destructibles;
- muñeco de nieve gigante que crea zonas de nieve.
Son **HYPOTHESIS** funcionales; arte/nombres deben desarrollarse originalmente y revisar similitud antes de producción.

## Matriz de coste cualitativo
Una familia humanoide compartiendo Avatar/animaciones: menor coste relativo.
Enemigo con proporciones/rig único: mayor modelado/rig/QA.
Boss único: mayor coste por contenido + lógica + presentación.
No son horas ni presupuesto medido.

## Verificación futura
- importar modelos candidatos y validar Avatar;
- retarget locomotion/attack y registrar artefactos/defectos;
- medir Animator/skinning en #46;
- silhouette test en grayscale/pequeño tamaño;
- revisión de originalidad lado-a-lado contra referencias seleccionadas;
- boss prototype sólo tras aprobación.

## UNKNOWN/decisiones humanas
boss sí/no; Santa health; número de familias; roles de elfo; nivel de estilización/proporciones; equipamiento; animaciones finales; asset sources/licencias (#44).
