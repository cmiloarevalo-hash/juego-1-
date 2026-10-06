# Política, privacidad y fuentes — monetización futura

Fecha de consulta: 2026-10-05
Alcance: investigación; verificar nuevamente inmediatamente antes de integrar/publicar porque SDKs y políticas cambian.

## Hechos actuales (fuentes oficiales)

1. Google Mobile Ads Unity — rewarded ads: rewarded es opt-in a cambio de recompensa; Google exige usar test ads durante desarrollo y ofrece callbacks de recompensa/eventos.
https://developers.google.com/admob/unity/rewarded

2. Google UMP para Unity: se recomienda actualizar información de consentimiento en cada arranque; `CanRequestAds()` indica cuándo pueden solicitarse anuncios; puede ser obligatorio ofrecer acceso a opciones de privacidad.
https://developers.google.com/admob/unity/privacy

3. AdMob mediation permite servir desde múltiples fuentes; la selección actual de fuentes/adapters incluye redes con soporte de rewarded y bidding/waterfall según red.
https://developers.google.com/admob/unity/mediation
https://developers.google.com/admob/unity/choose-networks

4. Unity Ads en mediación: Unity documenta LevelPlay, Google AdMob y AppLovin MAX como partners; desde 2026-04-01 advierte posible reducción de performance para integración directa mediante Advertisement Legacy y recomienda mediación/bidding.
https://docs.unity.com/en-us/grow/ads/mediation/unity-ads-in-mediation

5. Unity LevelPlay lista múltiples mediated networks y formatos, incluido rewarded.
https://docs.unity.com/en-us/grow/levelplay/platform/fundamentals/mediated-networks

6. Google Play Families: si se muestran anuncios a niños o usuarios de edad desconocida, deben usarse SDKs de anuncios autocertificados para Familias; no anuncios basados en intereses/remarketing para esos usuarios; contenido/formato debe ser apropiado. Para audiencia mixta, Google exige medidas de filtrado por edad como pantalla de edad neutral y SDKs autocertificados para anuncios servidos a niños. Apps solo para niños tienen restricciones adicionales sobre identificadores y permisos.
https://support.google.com/googleplay/android-developer/answer/9893335
https://support.google.com/googleplay/android-developer/answer/9867159

7. Google Play Ads/Better Ads: prohíbe interstitials inesperados durante gameplay o al inicio de un nivel/segmento. La regla general de interstitial no se aplica a rewarded explícitamente opt-in, pero Families añade requisitos más estrictos cuando aplica.
https://support.google.com/googleplay/android-developer/answer/9857753

## Recomendaciones derivadas (no son hechos de política)
- Resolver `Target Audience and Content` antes de elegir el stack de producción.
- Tratar edad desconocida conservadoramente hasta que el diseño de audiencia/age screen sea aprobado.
- Centralizar consentimiento/privacy state fuera del gameplay y bloquear inicialización/request de ads según la señal aplicable del CMP/SDK.
- Mantener un privacy-options entry point cuando el framework aplicable lo requiera.
- Rewarded solo por elección explícita y en pausas naturales; la ruta jugable funciona completamente sin anuncio.
- No almacenar por cuenta propia una copia “eterna” del consentimiento como fuente de verdad si el CMP ofrece estado actualizado.
- Revisar Data Safety, Target Audience, Content Rating, privacy policy y lista vigente de Families Self-Certified Ads SDKs justo antes de release.

## Riesgo de audiencia
El arte navideño/Santa/elfos puede resultar atractivo para menores, pero eso por sí solo no decide la audiencia declarada. La selección de audiencia es una decisión Human material y debe ser coherente con contenido, marketing y declaraciones de Play Console. No activar anuncios de producción hasta resolverla.
