using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractState
{
    public virtual void Initialize()
    {

    }
    public virtual void StateEnter()
    {
        AppStatic.EventDirector.OnStateEnterAction();
    }
    public virtual void StateExit()
    {
        AppStatic.EventDirector.OnStateExitAction();
    }
    
}
