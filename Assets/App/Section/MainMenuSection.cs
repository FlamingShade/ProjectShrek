using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSection : AbstractSection
{
    public override void Initialize()
    {
        base.Initialize();
        ScenePart.SceneNameAdd(SceneDirector.SceneName.MainMenuScene);
        ScenePart.SceneNameAdd(SceneDirector.SceneName.MainMenuOptionsScene);
        ScenePart.StartingSceneSet(SceneDirector.SceneName.MainMenuScene);
    }
}
