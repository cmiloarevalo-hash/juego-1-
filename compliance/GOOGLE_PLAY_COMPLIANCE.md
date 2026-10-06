# GOOGLE PLAY COMPLIANCE BY DESIGN

Consulta de políticas: 2026-10-06 UTC. Base auditada de Prototipo 1: `fe2ab0415b27049989621533cdd1fefb34faf4c4`. Este paquete es preparación de publicación; no modifica gameplay ni afirma ejecución Unity/Android/Play Console.

## Regla durable

**GOOGLE_PLAY_COMPATIBILITY_BY_DESIGN**

No implementar deliberadamente decisiones técnicas, SDKs, permisos, tratamiento de datos, monetización o contenido que generen una incompatibilidad evitable con Google Play. Mantener permisos/datos mínimos; SDKs, monetización y compras aislados del core; declaraciones de Play trazables a comportamiento real; y revalidar políticas inmediatamente antes de cualquier envío.

## 1. Inventario + 2. Matriz de cumplimiento

Estados: COMPLIANT sólo con evidencia; PREPARED = diseño compatible pero no verificado en build/Console; PENDING = trabajo futuro; HUMAN-GATE = requiere decisión/autoridad; NOT-APPLICABLE = no aplica al producto actual; BLOCKED = impide el checkpoint indicado.

| REQUISITO | FUENTE OFICIAL | OBLIG./COND. | APLICA AHORA | APLICA AL PUBLICAR | ESTADO | RIESGO | ACCIÓN | EVIDENCIA NECESARIA |
|---|---|---|---|---|---|---|---|---|
| Target SDK móvil | S01 | Obligatorio para envío | Preparar | Sí | PENDING | Alto publicación | Target API 36+ si se envía bajo regla vigente desde 31-08-2026; revalidar al release | PlayerSettings/Gradle + manifest merged + Play pre-check |
| Compile SDK compatible | S02/S01 | Técnico | Preparar | Sí | PENDING | Alto build | Usar toolchain capaz de compilar target requerido; no fijar valor sin Unity/Android execution | Gradle/build log |
| Android App Bundle | S03 | Obligatorio app nueva | No para APK Samsung | Sí | PENDING | Alto publicación | Generar `.aab` release después del APK validado | AAB + build log/hash |
| Play App Signing + upload key | S04 | Necesario con AAB/Play | No | Sí | HUMAN-GATE | Alto release | Configurar Play App Signing; custodiar upload key; no crear credenciales ahora | Console + fingerprints/secure custody record |
| versionCode/versionName | S05 | Obligatorio técnico | Preparar | Sí | PENDING | Medio | Definir/incrementar por release | manifest/bundle metadata |
| minSdk/compatibilidad dispositivo | S01 + Android | Técnico/producto | Sí | Sí | PENDING | Medio | Verificar minSdk/ABI/rendering en build y Samsung; target moderno no impide minSdk anterior | merged manifest + device install/test |
| Permisos mínimos | S06 | Policy/best practice; sensibles pueden tener reglas obligatorias | Sí | Sí | PREPARED | Alto si SDK añade permisos | No añadir permisos sin necesidad; auditar merged manifest de release | manifest merged + justificación por permiso |
| User Data / privacidad | S07 | Obligatorio si publica | Diseñar | Sí | PREPARED | Alto | Minimizar datos; mapear toda colección/transmisión incluida la de SDKs | data inventory + network/SDK review |
| Data Safety | S07 | Obligatorio | No Console ahora | Sí | PENDING | Alto | Completar de forma consistente con app/SDK/privacy policy | formulario Play + inventario firmado |
| Política de privacidad | S07 | Obligatorio para todas las apps | Preparar | Sí | PENDING | Alto | Crear/publicar política exacta y accesible también desde app antes de Play | URL pública + acceso in-app + review |
| SDKs terceros | S08 | Condicional | Sí | Sí | PREPARED | Alto | Responsable del comportamiento del SDK; mantener inventario y aislamiento; revisar permisos/datos/versiones | SBOM/lista SDK + docs proveedor + manifest/data audit |
| Content rating IARC | S09 | Obligatorio | No | Sí | PENDING | Alto publicación | Responder cuestionario fiel al contenido final; actualizar si cambia | rating emitido por Play/IARC |
| Target Audience & Content | S10 | Obligatorio | Puede diferirse | Sí | HUMAN-GATE | Alto | Human fija audiencia/edad antes de monetización productiva/publicación | declaración Play + revisión de contenido/marketing |
| Families | S10/S11 | Condicional si incluye niños | No decidir ahora | Condicional | HUMAN-GATE | Alto | Si incluye niños, aplicar Families; si ads a niños/edad desconocida, SDKs autocertificados y restricciones | audiencia declarada + SDK/version/config audit |
| Ads declaration | S10/S12 | Condicional | No ads reales | Sí si ads | PENDING | Alto si monetiza | Declarar correctamente; anuncios son parte de app/policy | Console declaration + build inspection |
| Rewarded ads | S12 + #98 | Condicional | No integrar | Sí si aprobado | HUMAN-GATE | Medio/alto | Mantener opt-in y fuera gameplay activo; audiencia primero; rewarded-continue requiere autorización semántica | UX spec + policy/SDK/config/test evidence |
| Advertising ID/identificadores | S10/S11 | Condicional | No necesario hoy | Condicional | PREPARED | Alto Families/privacy | No solicitar AD_ID ni identificadores por defecto; decidir sólo tras audiencia/provider; auditar manifest | merged manifest + SDK/data config |
| IAP / Play Billing | S13 | Condicional a venta digital | No integrar | Sí si vende digital | HUMAN-GATE | Alto comercial | Si se venden bienes digitales en app distribuida por Play, usar Play Billing salvo excepción aplicable; desacoplar del core | decisión Human + Billing implementation/test |
| Store metadata | S14 | Obligatorio para listing | No | Sí | PENDING | Medio | Nombre/descripciones/categoría/contacto y declaraciones exactas, sin claims engañosos | listing review |
| Assets de publicación | S14 | Obligatorio según asset/placement | No | Sí | PENDING | Bajo/medio | Preparar icono 512x512 y preview assets requeridos aplicables, screenshots reales | Play asset validation |
| App content / review access | S15 | Obligatorio según app | No | Sí | PENDING | Medio | Completar ads, privacy, audience, access instructions y permisos sensibles aplicables | App content page complete |
| Testing/release tracks | S16 | Cuenta-dependiente | No para Samsung sideload | Sí | HUMAN-GATE/PENDING | Medio | Usar internal/closed según cuenta; cuentas personales nuevas pueden requerir closed test 12 testers/14 días antes de production access | account eligibility + track evidence |
| Android vitals/calidad | S17 | Calidad Play; thresholds afectan visibilidad/warnings | Diseñar calidad | Sí | PENDING | Alto calidad | Tras distribución, observar crash/ANR/core vitals; no inventar PASS pre-Play | Play vitals dashboard |
| Contenido/políticas generales | S15/S09/S12 | Obligatorio | Sí | Sí | PREPARED | Alto | Mantener scope congelado; revisar contenido final, ads y metadata contra políticas | policy review + final build/listing |
| Revalidación de políticas | Todas | Obligación operativa | No | Sí | PENDING | Alto por cambios | Reconsultar fuentes y Play Console inmediatamente antes de release/publicación | dated compliance review |

## 3. Guardrails de arquitectura

1. **Android/API:** mantener configuración Android explícita y verificable; al release targetear el API exigido entonces. No confundir APK de desarrollo con artefacto publicable.
2. **Permisos:** cero permisos nuevos sin necesidad de feature aceptada; revisar manifiesto fusionado porque plugins pueden introducir permisos transitivos.
3. **Privacy by design:** recopilar/transmitir sólo datos necesarios. Toda telemetría futura debe tener propósito, retención y declaración trazables.
4. **SDK isolation:** gameplay/domain no depende de clases de proveedor. Cada SDK futuro vive detrás de adapter/port y puede eliminarse/reemplazarse sin cambiar reglas del juego.
5. **Monetización:** `IMonetizationService`/Null/Fake de #98 sigue siendo dirección; anuncios reales no entran en Prototipo 1. Rewarded sólo en pausas naturales/post-run si se autoriza; no anuncios disruptivos durante gameplay.
6. **IAP:** interfaz separada del core/economía; ninguna compra necesaria para completar gameplay congelado; Play Billing sólo cuando exista decisión comercial y aplique.
7. **Edad/audiencia/consentimiento:** no inferir audiencia por estética. Human decide target audience antes de monetización productiva/Play. Configuración de ads/data se deriva después de esa decisión.
8. **Data Safety readiness:** mantener inventario de SDKs, permisos, datos recogidos, compartidos y finalidad para poder contestar Play sin adivinar.
9. **No dependencia comercial prematura:** sin IDs productivos, credenciales, contratos, gasto o proveedor irreversible antes del gate Human.
10. **Quality:** diseño Android-first; crashes/ANR/performance se validan en runtime/Play, no por inspección estática.

## 4. Auditoría Prototipo 1

Base auditada: `fe2ab0415...` (lineage `dev/application-completion`). El árbol contiene gameplay propio, adapters Unity, `Packages/manifest.json` y `ProjectVersion.txt`. El manifest de paquetes visible contiene únicamente `com.unity.inputsystem` 1.17.0; no se observan SDKs de ads/IAP/analytics en ese manifest. Unity declarado: 6000.3.25f1. No existe en la base auditada un `ProjectSettings/ProjectSettings.asset` versionado que permita verificar estáticamente target/min SDK, package name, versionCode, scripting backend u otras PlayerSettings; por ello esos puntos son PENDING, no FAIL.

| HALLAZGO | CLASE | EFECTO |
|---|---|---|
| Gameplay congelado no requiere datos personales, ads o IAP | NO_ISSUE | Mantener core independiente |
| No SDK comercial visible en `Packages/manifest.json` auditado | NO_ISSUE | Reduce superficie actual; reauditar dependencias transitivas en build |
| Input System es la única dependencia Unity declarada en manifest | NO_ISSUE | No introduce por sí solo decisión comercial |
| Target/compile/min SDK y PlayerSettings no verificables desde archivos versionados actuales | FUTURE_REQUIREMENT | Verificar al recuperar Unity/build; no bloquea coding ni APK preliminar salvo que build falle |
| AAB/Play App Signing/versionado release | FUTURE_REQUIREMENT | No bloquea APK Samsung; sí gate de publicación |
| Data Safety/privacy policy/IARC/listing | FUTURE_REQUIREMENT | Preparar al product readiness; no blocker APK |
| Audiencia/edad | HUMAN_GATE | Diferible; obligatorio antes de publicación/monetización productiva |
| Ads/IAP reales | HUMAN_GATE | No presentes/autorizados; no blocker de Prototipo 1 |
| Unity compile/runtime, APK/install/launch siguen NOT_RUN según estado del programa | FUTURE_REQUIREMENT | Evidencia ejecutable pendiente; compliance no convierte en PASS |

`PROTOTYPE1_SCOPE_CHANGED=NO`

## 5. Remediación

**Cambios de código/configuración:** NONE.

Razón: no se identificó una incompatibilidad estática demostrada que cumpla simultáneamente los cinco criterios de remediación. Cambiar PlayerSettings/API sin poder inspeccionar el archivo efectivo ni ejecutar Unity sería especulativo. La remediación correcta y reversible en este checkpoint es documentar guardrails y checkpoints verificables.

Checkpoints diferidos al entorno Unity/Android:
- inspeccionar PlayerSettings y manifest fusionado;
- confirmar package/application ID, min/target SDK, versionCode/versionName, ABI/scripting backend;
- confirmar target API vigente (actualmente API 36 para nuevos envíos desde 31-08-2026);
- clean compile; APK dev; instalación/launch Samsung;
- posteriormente release build + AAB y firma bajo autoridad Human.

## 6. Checklist pre-publicación operativo

Ruta: `APK VALIDADO → PRODUCT READINESS → PLAY COMPLIANCE → RELEASE BUILD → AAB → SIGNING → PLAY CONSOLE → TEST TRACK → REVIEW → PUBLICATION`.

| CHECKPOINT / ACCIÓN | EVIDENCIA | PASS/FAIL | RESPONSABLE |
|---|---|---|---|
| APK validado: compile/build/install/launch y playthrough del scope congelado | SHA, Unity/build logs, APK hash, Samsung evidence | Supervisor determina contra evidencia | Implementer → Human device → Supervisor |
| Product readiness: scope final, ES/EN, resultado, contenido y UX estables | exact SHA + playthrough evidence | Supervisor | Implementer/Supervisor |
| Revalidar políticas vigentes antes de Play | revisión fechada de fuentes oficiales + Console requirements | Supervisor | Implementer/Supervisor |
| Fijar audiencia/edad y modelo comercial | decisión durable | Human | Human |
| Inventario final de datos/permisos/SDKs | merged manifest, dependencies, data map | Supervisor | Implementer/Supervisor |
| Privacy policy + Data Safety consistentes | URL/in-app policy + Console answers vs data map | Supervisor/Google review | Implementer + Human para publicación |
| IARC/content + Target Audience/App Content | cuestionarios/declaraciones completos | Play validation | Human/Implementer; Play Console/Google |
| Release build | reproducible release log, SHA/config | Supervisor | Implementer |
| Generar AAB | `.aab`, hash, bundle metadata | Supervisor | Implementer |
| Play App Signing/upload key | Console enrollment + upload cert; key custody | Human/Play | Human + Play Console/Google |
| Store listing/assets | validated metadata/icon/screenshots/feature assets aplicables | Play validation | Implementer/Human |
| Crear app/track en Play Console | app record + package identity | Play validation | Human/Implementer según credenciales |
| Internal test si útil | install/update evidence | Supervisor | Implementer/testers |
| Closed test si la cuenta lo exige | Console track + testers/duration exigidos por regla vigente | Play validation | Human/testers/Play Console |
| Vitals/pre-launch/release issues | Console reports; no unresolved material release blocker | Supervisor | Implementer/Supervisor/Google |
| Submit review | submission record | Google decides | Human authorizes; Play Console/Google executes review |
| Publication pública | explicit Human authorization + approved release | Google/Play status | Human + Play Console/Google |

Un FAIL reabre el checkpoint mínimo afectado; no convierte requisitos posteriores en blockers del APK de desarrollo.

## 7. Gate final

**PLAY_STORE_PATH = PREPARED_WITH_PENDING_GATES**

### Blockers reales por etapa
- **Continuar desarrollando:** NONE derivados de Google Play conocidos hoy.
- **Generar APK de desarrollo:** entorno Unity/Android ejecutable y configuración/build efectiva siguen pendientes fuera de este paquete; Google Play no añade un blocker nuevo.
- **Prueba Samsung:** APK instalable/launch/playthrough pendiente; Google Play no añade blocker nuevo.
- **Generar AAB:** requiere entorno Unity/Android, PlayerSettings release compatibles y target API vigente; no requiere aún publicación pública.
- **Play Console:** cuenta/acceso/credenciales Human, package identity, AAB válido, privacy/Data Safety/App Content/listing aplicables.
- **Publicación pública:** target API vigente; AAB + Play App Signing; declaraciones/políticas exactas; IARC; audiencia; Data Safety/privacy; testing/access-to-production aplicable a la cuenta; review de Google; y autorización Human explícita. Monetización añade gates sólo si se incluye.

### Human gates futuros
- audiencia/edad;
- anuncios reales y cualquier proveedor/compromiso;
- IAP/comercialización;
- cuentas/credenciales;
- firma/release cuando requiera autoridad/custodia Human;
- gasto/contratos;
- publicación pública;
- rewarded-continue si altera la semántica congelada de derrota.

No hay una pregunta documental abierta que justifique detener `Unity → APK → Samsung`. Requisitos dependientes de build/Console se verifican en su checkpoint y políticas se revalidan inmediatamente antes de publicación.

`GOOGLE_PLAY_COMPLIANCE_PACKAGE_COMPLETE=YES`
`PROTOTYPE1_SCOPE_CHANGED=NO`
`READY_FOR_REVIEW=YES`
