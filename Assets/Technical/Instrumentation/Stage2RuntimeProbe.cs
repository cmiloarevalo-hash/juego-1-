using Unity.Profiling;
using UnityEngine;

namespace Stage2.Technical
{
    public sealed class Stage2RuntimeProbe : MonoBehaviour
    {
        private static readonly ProfilerMarker UpdateMarker = new("Stage2.RuntimeProbe.Update");

        private void Start()
        {
            Debug.Log(
                $"[STAGE2_ENV] unity={Application.unityVersion}; " +
                $"platform={Application.platform}; device={SystemInfo.deviceModel}; " +
                $"graphics={SystemInfo.graphicsDeviceType}/{SystemInfo.graphicsDeviceName}; " +
                $"cpu={SystemInfo.processorType}; cpuCount={SystemInfo.processorCount}; " +
                $"ramMB={SystemInfo.systemMemorySize}");
        }

        private void Update()
        {
            using (UpdateMarker.Auto())
            {
                // Intentionally empty instrumentation seam for synthetic Stage 2 workloads.
            }
        }
    }
}
