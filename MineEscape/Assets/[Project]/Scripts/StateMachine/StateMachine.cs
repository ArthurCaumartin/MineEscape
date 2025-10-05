using Alchemy.Inspector;
using UnityEngine;
using UnityEngine.InputSystem.UI;

namespace StateManagment
{
    public abstract class StateMachine : MonoBehaviour
    {
        [SerializeField, ReadOnly] private string _currentStateName;
        private State _currentState;

        protected virtual void SetState(State stateToSet)
        {
            _currentState?.ExitState();
            _currentState = stateToSet;
            _currentState.EnterState();
            _currentStateName = _currentState.ToString() ?? "None";
        }

        protected virtual void Update()
        {
            _currentState?.UpdateState();
        }

        protected virtual void FixedUpdate()
        {
            _currentState?.FixedUpdateState();
        }
    }
}