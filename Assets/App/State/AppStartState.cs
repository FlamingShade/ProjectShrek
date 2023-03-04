using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AppStartState : AbstractState
{
    
    public override void StateEnter()
    {
        base.StateEnter();
        Debug.Log($"enter AppStartState");
    }

    public override void StateExit()
    {
        base.StateExit();
        Debug.Log($"exit AppStartState");
    }
}
