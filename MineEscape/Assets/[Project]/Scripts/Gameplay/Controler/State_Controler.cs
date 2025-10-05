using StateManagment;
using UnityEngine;

public abstract class State_Controler : State
{
    protected InputEventHandler inputEventHandler;
    protected Transform transform;

    public virtual void InitState(StateMachine stateMachine, InputEventHandler inputEventHandler, Transform transform)
    {
        base.InitState(stateMachine);
        this.inputEventHandler = inputEventHandler;
        this.transform = transform;
    }
}

public class State_RopeMovement : State_Controler
{

}

public class State_BarMovement : State_Controler
{

}
