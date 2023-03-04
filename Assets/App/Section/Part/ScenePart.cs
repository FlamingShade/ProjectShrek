using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenePart : AbstractPart
{
    public SceneDirector.SceneName StartingSceneName { get; private set;}
    public AbstractSection SectionHost { get; private set;}
    private List<SceneDirector.SceneName> _sceneNameList = new List<SceneDirector.SceneName>();
    private List<Scene> _sceneList = new List<Scene>();

    public void StartingSceneSet(SceneDirector.SceneName tempSceneName)
    {
        StartingSceneName = tempSceneName;
    }
    public void SectionHostSet(AbstractSection tempSection)
    {
        SectionHost = tempSection;
    }
    public void SceneNameAdd(SceneDirector.SceneName tempSceneName)
    {
        _sceneNameList.Add(tempSceneName); 
        Scene tempScene = SceneManager.GetSceneByName(tempSceneName.ToString());
        AppStatic.SceneDirector.SceneSectionAdd(tempSceneName, SectionHost);
        _sceneList.Add(tempScene);
    }
}
