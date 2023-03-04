using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStartSection : AbstractSection
{
    public override void Initialize()
    {
        base.Initialize();
        ScenePart.SceneNameAdd(SceneDirector.SceneName.AppStartScene);
        ScenePart.StartingSceneSet(SceneDirector.SceneName.AppStartScene);
    }
}
