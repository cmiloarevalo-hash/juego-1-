using ChristmasRunner.Gameplay.Run;
using UnityEngine;
using UnityEngine.UI;

namespace ChristmasRunner.UnityIntegration
{
    public sealed class ResultPresenterBehaviour : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private GameObject resultPanel;
        [SerializeField] private Text resultText;
        [SerializeField] private Text helperCountText;
        private bool presented;

        private void OnEnable()
        {
            if (session != null)
            {
                session.ResultReady += Present;
                RunResult? existingResult = session.FinalResult;
                if (existingResult.HasValue)
                {
                    presented = true;
                    Render(existingResult.Value);
                    return;
                }
            }

            if (!presented && resultPanel != null) resultPanel.SetActive(false);
            else if (presented && resultPanel != null) resultPanel.SetActive(true);
        }

        private void OnDisable()
        {
            if (session != null) session.ResultReady -= Present;
        }

        private void Present(RunResult result)
        {
            if (presented) return;
            presented = true;
            Render(result);
        }

        private void Render(RunResult result)
        {
            if (resultPanel != null) resultPanel.SetActive(true);
            if (resultText != null)
            {
                string key = result.Outcome == RunPhase.Victory ? "result.victory" : "result.defeat";
                resultText.text = session != null ? session.Localize(key) : key;
            }
            if (helperCountText != null) helperCountText.text = result.HelpersRemaining.ToString();
        }
    }
}
