# ADR — Monetización desacoplada y rewarded opt-in

Estado: PROPUESTA POST-PROTOTIPO 1
Fecha de consulta: 2026-10-05

## Decisión propuesta
El gameplay no dependerá de un SDK publicitario. Definir un puerto de aplicación equivalente a:

```text
IMonetizationService
  Initialize(context)
  GetRewardedAvailability(placement)
  ShowRewarded(placement, onEarned, onClosed, onError)
  ShowPrivacyOptions()
```

Implementaciones: `NullMonetizationService` (sin anuncios), `FakeMonetizationService` (tests), y posteriormente un adapter específico de mediación. Los callbacks del proveedor se traducen a eventos internos. El dominio nunca conoce ad-unit IDs, SDK classes ni network names.

La recompensa se concede únicamente tras señal de reward válida del adapter; cierre/error/no-fill no puede bloquear la run. Idempotencia por `placementAttemptId` evita doble recompensa.

## Placements recomendados
Rewarded voluntario solo en pausas naturales y mediante CTA explícito:
- **Pantalla de resultado**: recompensa post-run (p. ej. recurso futuro o bonus de progresión), nunca altera el resultado ya emitido.
- **Entre niveles / selector de nivel**: bonus opcional antes de iniciar el siguiente nivel, mostrado antes de que el usuario pulse jugar.
- **Retry tras derrota**, solo si producto autoriza una recompensa concreta y transparente; preferir bonus para la siguiente run antes que resurrección dentro del recorrido.

No mostrar rewarded durante traversal, gates, obstacle, combat, boss, onboarding ni inmediatamente después de que el usuario pulse iniciar nivel. No insertar interstitials como sustituto silencioso.

## Comparación actual
### Google AdMob Mediation
Pros: integración Unity oficial/documentada; rewarded; múltiples fuentes y bidding/waterfall según red; UMP/Privacy & Messaging integrado en el ecosistema; Ad Inspector/test ads. Buena opción inicial Android-first si la audiencia/política resulta compatible.
Contras: configuración por red/adapters; consentimiento debe propagarse correctamente; políticas y dependencias de terceros siguen siendo responsabilidad del publisher.

### Unity LevelPlay
Pros: mediación centrada en juegos; múltiples redes; rewarded ampliamente soportado; Unity Ads recomienda actualmente mediación/LevelPlay y bidding frente a integración legacy directa.
Contras: otro stack operativo/SDK; se debe evaluar tamaño, compatibilidad, reporting y requisitos de privacidad antes de adoptar.

### AppLovin MAX
Alternativa relevante del mercado y compatible como mediation partner de Unity Ads. Requiere evaluación práctica/documental específica antes de selección; esta investigación no encontró evidencia oficial suficiente en la consulta actual para declarar superioridad o términos comerciales.

### Integración directa Unity Ads
No recomendada como arquitectura objetivo. Unity indica que desde 2026-04-01 la integración directa mediante Advertisement Legacy puede tener menor performance y recomienda integrar Unity Ads como bidder/mediation.

## Recomendación
Shortlist para prueba post-Prototipo 1: **AdMob Mediation vs Unity LevelPlay**. No seleccionar por eCPM teórico. Hacer spike con test ads sobre el mismo `IMonetizationService`, comparar tamaño/build health, tiempo de integración, consentimiento, crash/ANR, disponibilidad regional, tooling y métricas reales. Mantener AppLovin MAX como alternativa si el spike muestra una carencia material.

No firmar compromisos comerciales ni crear IDs de producción durante el spike.
