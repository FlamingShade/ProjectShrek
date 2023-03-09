using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneRitualCaveState : AbstractState
{
    public override void StateEnter()
    {
        base.StateEnter();
        Debug.Log($"enter BoneRitualCaveState");
    }

    public override void StateExit()
    {
        base.StateExit();
        Debug.Log($"exit BoneRitualCaveState");
    }
}
