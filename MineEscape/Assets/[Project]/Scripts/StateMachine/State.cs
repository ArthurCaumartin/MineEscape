using System;

namespace StateManagment
{
    [Serializable]
    public abstract class State
    {
        public virtual void InitState(StateMachine stateMachine) { }
        public virtual void EnterState() { }
        public virtual void UpdateState() { }
        public virtual void FixedUpdateState() { }
        public virtual void ExitState() { }
    }
}