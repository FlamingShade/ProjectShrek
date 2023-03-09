using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneRitualCaveSection : AbstractSection
{
    public override void Initialize()
    {
        base.Initialize();
        MasterPart.MasterCreate<FragmentMaster>();
        MasterPart.MasterCreate<ItemMaster>();
        ScenePart.SceneNameAdd(SceneDirector.SceneName.BoneRitualCaveScene);
        ScenePart.StartingSceneSet(SceneDirector.SceneName.BoneRitualCaveScene);
    }
    public override void Activate()
    {
        base.Activate();
        AppStatic.StateDirector.SwitchState<BoneRitualCaveState>();
    }
}
