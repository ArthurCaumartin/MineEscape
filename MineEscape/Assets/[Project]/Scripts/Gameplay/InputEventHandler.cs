using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputEventHandler : MonoBehaviour
{
    public delegate void DirectionalInputEvent(Vector2 direction);
    public event DirectionalInputEvent OnMoveEvent;
    public event DirectionalInputEvent OnAimEvent;

    public delegate void ButtonInputEvent(bool isPressed);
    public event ButtonInputEvent OnGrabEvent;
    public event ButtonInputEvent OnReleaseEvent;
    public event ButtonInputEvent OnJumpEvent;


    private void OnMove(InputValue value)
    {
        OnMoveEvent?.Invoke(value.Get<Vector2>());
    }

    private void OnAim(InputValue value)
    {
        OnAimEvent?.Invoke(value.Get<Vector2>());
    }

    private void OnGrab(InputValue value)
    {
        OnGrabEvent?.Invoke(value.Get<float>() > .5f);
    }

    private void OnRelease(InputValue value)
    {
        OnReleaseEvent?.Invoke(value.Get<float>() > .5f);
    }

    private void OnJump(InputValue value)
    {
        OnJumpEvent?.Invoke(value.Get<float>() > .5f);
    }
}