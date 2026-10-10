using ChristmasRunner.Gameplay.Localization;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    /// <summary>Camera-facing, presentation-only helper count; never changes army authority.</summary>
    [RequireComponent(typeof(TextMesh))]
    public sealed class LiveHelperCounterBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private TextMesh countText;

        private int lastCount = -1;
        private Language lastLanguage;
        private bool lastVisible;

        private void LateUpdate()
        {
            if (session == null || session.Session == null || countText == null) return;

            bool visible = !session.IsTerminal;
            Renderer meshRenderer = countText.GetComponent<Renderer>();
            if (meshRenderer != null && meshRenderer.enabled != visible)
                meshRenderer.enabled = visible;

            if (!visible) { lastVisible = false; return; }

            int count = session.HelperCount;
            Language language = session.Session.Localization.Current;
            if (lastVisible && count == lastCount && language == lastLanguage) return;

            countText.text = session.Localize("hud.helpers") + ": " + count;
            lastCount = count;
            lastLanguage = language;
            lastVisible = true;
        }
    }
}
