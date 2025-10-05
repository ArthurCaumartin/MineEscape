using StateManagment;
using UnityEngine;

public class StateMachine_PlayerControler : StateMachine
{
    [SerializeField] private InputEventHandler _inputEventHandler;
    [Space]
    [SerializeField] private State_GroundMovement _stateGroundMovement = new();
    [SerializeField] private State_BarMovement _stateBarMovement = new();
    [SerializeField] private State_RopeMovement _stateRopeMovemwent = new();


    private void Awake()
    {
        _stateGroundMovement.InitState(this, _inputEventHandler, transform);
        _stateBarMovement.InitState(this, _inputEventHandler, transform);
        _stateRopeMovemwent.InitState(this, _inputEventHandler, transform);
    }

    private void Start()
    {
        SetState(_stateGroundMovement);
    }



}

