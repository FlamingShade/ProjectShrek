using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMapState : AbstractState
{
    public override void StateEnter()
    {
        base.StateEnter();
        var tempSection = AppStatic.SectionDirector.SectionGet<GlobalMapSection>();
        tempSection.LocationGeneration();
        Debug.Log($"enter GlobalMapState");
    }

    public override void StateExit()
    {
        base.StateExit();
        Debug.Log($"exit GlobalMapState");
    }
}
