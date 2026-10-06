using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    /// <summary>Android-friendly third-person runner camera. Presentation only.</summary>
    public sealed class RunnerCameraBehaviour : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 offset = new Vector3(0f, 6f, -8f);
        [SerializeField, Min(0f)] private float followSharpness = 8f;
        [SerializeField, Min(0f)] private float lookAhead = 4f;
        [SerializeField, Min(0f)] private float lookHeight = 1.5f;

        public void SetTarget(Transform value) => target = value;

        private void LateUpdate()
        {
            if (target == null) return;
            Vector3 desired = target.TransformPoint(offset);
            float t = 1f - Mathf.Exp(-followSharpness * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, desired, t);
            Vector3 focus = target.position + target.forward * lookAhead + Vector3.up * lookHeight;
            Vector3 direction = focus - transform.position;
            if (direction.sqrMagnitude > 0.001f)
                transform.rotation = Quaternion.LookRotation(direction.normalized, Vector3.up);
        }
    }
}
