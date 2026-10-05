using UnityEngine;
using UnityEngine.InputSystem;

namespace ChristmasRunner.Gameplay.Input
{
    public sealed class RunnerInputController : MonoBehaviour
    {
        [SerializeField] private float lateralSpeed = 5f;
        [SerializeField] private float lateralLimit = 4f;
        [SerializeField] private float forwardSpeed = 4f;
        private float _lateralIntent;

        private void Update()
        {
            var keyboard = Keyboard.current;
            var touch = Touchscreen.current;
            _lateralIntent = 0f;
            if (keyboard != null)
                _lateralIntent = (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed ? 1f : 0f) - (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed ? 1f : 0f);
            if (touch != null && touch.primaryTouch.press.isPressed)
            {
                float normalizedX = touch.primaryTouch.position.ReadValue().x / Mathf.Max(1f, Screen.width);
                _lateralIntent = Mathf.Clamp((normalizedX - 0.5f) * 2f, -1f, 1f);
            }

            Vector3 p = transform.position;
            p.x = Mathf.Clamp(p.x + _lateralIntent * lateralSpeed * Time.deltaTime, -lateralLimit, lateralLimit);
            p.z += forwardSpeed * Time.deltaTime;
            transform.position = p;
        }
    }
}
