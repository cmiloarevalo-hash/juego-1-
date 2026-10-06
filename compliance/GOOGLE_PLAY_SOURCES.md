# GOOGLE PLAY SOURCES

Consulta: **2026-10-06 UTC**. Fuentes prioritariamente oficiales Google/Android/Play. Las políticas pueden cambiar; revalidar inmediatamente antes de cualquier envío/publicación.

| ID | URL oficial | Organización | Requisito respaldado | Tipo / aplicabilidad / limitación |
|---|---|---|---|---|
| S01 | https://support.google.com/googleplay/android-developer/answer/11926878 | Google Play | Target API: desde 31-08-2026 apps nuevas/updates móviles deben target Android 16/API 36+ (salvo excepciones de form factor); exact timeline | Política obligatoria de envío. Temporal: revalidar antes de release. |
| S02 | https://support.google.com/googleplay/android-developer/answer/16561298 | Google Play | Política general: nuevas apps/updates deben targetear API dentro de un año del último Android mayor | Política obligatoria; S01 da fechas exactas. |
| S03 | https://developer.android.com/guide/app-bundle | Android Developers | Apps nuevas en Google Play se publican con Android App Bundle desde agosto 2021 | Requisito de publicación; no aplica al APK sideload de Samsung. |
| S04 | https://developer.android.com/studio/publish/app-signing | Android Developers | Play App Signing, app signing key vs upload key; AAB requiere configuración de Play App Signing para upload/distribución | Técnico/release; implica custodia/autoridad Human. |
| S05 | https://developer.android.com/studio/publish/versioning | Android Developers | `versionCode` entero creciente/único para releases; `versionName` visible | Técnico obligatorio para versionado Android/Play. |
| S06 | https://developer.android.com/privacy-and-security/minimize-permission-requests | Android Developers | Minimizar permisos; permisos sensibles pueden requerir disclosures y revisión de datos | Recomendación fuerte + políticas específicas según permiso. No afirma que el prototipo tenga permisos. |
| S07 | https://support.google.com/googleplay/android-developer/answer/10144311 | Google Play | Data Safety clara/precisa para cada app; responsabilidad incluye SDKs; privacy policy en Play y dentro de app | Política obligatoria para publicación. Respuestas dependen del build final. |
| S08 | https://support.google.com/googleplay/android-developer/answer/13323374 | Google Play | Developer responsable de que SDKs terceros no causen violaciones; conocer permisos/datos/finalidad | Política obligatoria condicional a SDKs. |
| S09 | https://support.google.com/googleplay/android-developer/answer/9898843 | Google Play/IARC | Todas las apps necesitan content rating IARC; cuestionario exacto y actualizado | Obligatorio para estar en Play. |
| S10 | https://support.google.com/googleplay/android-developer/answer/9867159 | Google Play | Declarar Target Audience and Content; si incluye niños aplica Families; antes de sección se requiere ads declaration/access/privacy policy | Obligatorio en Play; audiencia es decisión Human futura. |
| S11 | https://support.google.com/googleplay/android-developer/answer/9900633 | Google Play | Si ads se sirven a niños/edad desconocida, usar Families Self-Certified Ads SDKs y cumplir restricciones; mixed audience requiere tratamiento adecuado | Condicional. Lista/versiones pueden cambiar: revalidar justo antes de ads/release. |
| S12 | https://support.google.com/googleplay/android-developer/answer/9857753 | Google Play | Ads y ofertas forman parte de la app, deben cumplir políticas y ser apropiados para content rating; reglas adicionales para niños | Condicional a ads. No autoriza ads ni selecciona proveedor. |
| S13 | https://support.google.com/googleplay/android-developer/answer/10281818 | Google Play | Play Billing requerido para compras in-app de bienes/servicios digitales distribuidos por Play, salvo excepciones de política | Condicional a IAP; no se integra en este paquete. |
| S14 | https://support.google.com/googleplay/android-developer/answer/9866151 | Google Play | Preview/store assets: icono Play 512x512 PNG, short description y requisitos de assets/listing aplicables | Requisito de listing; assets concretos dependen de superficies soportadas. |
| S15 | https://support.google.com/googleplay/android-developer/answer/9859455 | Google Play | App content: privacy, ads declaration, access instructions, target audience, high-risk permissions y otras declaraciones | Obligatorio/condicional para review. |
| S16 | https://support.google.com/googleplay/android-developer/answer/14151465 | Google Play | Para nuevas cuentas personales sujetas a la regla, closed test con al menos 12 testers opt-in continuos 14 días antes de solicitar production access; internal opcional | Condicional al tipo/estado de cuenta. No asumir aplicabilidad hasta inspeccionar cuenta. |
| S17 | https://developer.android.com/google/play/vitals | Android Developers/Google Play | Core vitals (crash/ANR, etc.) y bad-behavior thresholds pueden afectar visibilidad/warnings; métricas se observan tras distribución | Calidad Play; no puede marcarse PASS antes de datos reales. |
| S18 | https://support.google.com/googleplay/android-developer/answer/9859655 | Google Play | Ads deben ser adecuados al content rating; target age declaration y Families si incluye niños | Condicional; complementa S09/S10/S12. |
| S19 | https://support.google.com/googleplay/android-developer/answer/11043825 | Google Play | En Families, restricciones de identificadores/AAID y configuración de SDK/data; target API 33+ sin AD_ID deshabilita AAID | Condicional a audiencia infantil/mixta. No implementar hasta gate de audiencia. |

## Disciplina de uso

- **OBLIGATORIO** sólo cuando la fuente establece requisito aplicable al checkpoint.
- **CONDICIONAL** cuando depende de ads, IAP, niños, permisos, cuenta o feature aún no autorizada.
- **RECOMENDACIÓN** no se eleva artificialmente a blocker.
- Las fuentes de Play Console describen políticas vigentes a la fecha de consulta; el Console real y las políticas vigentes al envío son autoridad final operacional.
- Ninguna fuente anterior prueba que Unity compile, que un APK/AAB exista, que Samsung instale, que Data Safety esté completado o que Google haya aprobado la app.
