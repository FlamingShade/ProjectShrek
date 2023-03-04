using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : AbstractState
{
    public override void StateEnter()
    {
        base.StateEnter();
        Debug.Log($"enter MainMenuState");
    }

    public override void StateExit()
    {
        base.StateExit();
        Debug.Log($"exit MainMenuState");
    }
}
