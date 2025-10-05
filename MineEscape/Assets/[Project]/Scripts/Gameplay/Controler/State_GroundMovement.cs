using System;
using StateManagment;
using UnityEngine;

[Serializable]
public class State_GroundMovement : State_Controler
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [Space]
    [SerializeField] private float _movementSpeed = 5;
    private Vector2 _movementInput;

    public override void InitState(StateMachine stateMachine, InputEventHandler inputEventHandler, Transform transform)
    {
        base.InitState(stateMachine, inputEventHandler, transform);
        inputEventHandler.OnMoveEvent += SetMovementInput;
    }

    public override void FixedUpdateState()
    {
        base.FixedUpdateState();
        SetRigidbodyVelocity();
    }

    private void SetRigidbodyVelocity()
    {
        Vector2 newVelocity = new Vector2(_movementInput.x * _movementSpeed, _rigidbody.linearVelocityY);
        _rigidbody.linearVelocity = newVelocity;
    }

    private void SetMovementInput(Vector2 direction)
    {
        _movementInput = direction;
    }
}
