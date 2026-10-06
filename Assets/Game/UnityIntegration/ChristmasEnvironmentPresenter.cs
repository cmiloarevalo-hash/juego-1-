using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    /// <summary>Replaceable presentation contract for the continuous Christmas environment.</summary>
    public sealed class ChristmasEnvironmentPresenter : MonoBehaviour
    {
        [Header("Continuous route layers")]
        [SerializeField] private GameObject snowyPathRoot;
        [SerializeField] private GameObject villageRoot;
        [SerializeField] private GameObject mountainsRoot;
        [SerializeField] private GameObject auroraRoot;

        [Header("Optional lightweight atmosphere")]
        [SerializeField] private GameObject snowfallRoot;
        [SerializeField] private bool snowfallEnabled = true;

        private void Awake()
        {
            if (snowfallRoot != null) snowfallRoot.SetActive(snowfallEnabled);
        }

        public bool HasCoreVisualLayers =>
            snowyPathRoot != null && villageRoot != null && mountainsRoot != null && auroraRoot != null;
    }
}
