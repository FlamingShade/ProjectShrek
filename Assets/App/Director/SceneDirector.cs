using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
public class SceneDirector : AbstractDirector
{
    private Dictionary<SceneName, AbstractSection> _sceneSectionDictionary = new Dictionary<SceneName, AbstractSection>();
    public Scene CurrentScene {get; private set;}
    public enum SceneName
    {
        MainMenuScene,
        MainMenuOptionsScene,
        AppStartScene,
        GlobalMapScene,
        BoneRitualCaveScene
    }
    public Scene CurrentSceneSet()
    {
        return SceneManager.GetActiveScene();
    } 
    public void SceneLoad(SceneName tempSceneName)
    {
        AppSceneLoad(tempSceneName);
        //Debug.Log($"{AppStatic.sectionDirector.currentSection} {currentScene.name}"); 
    }
    private async void AppSceneLoad(SceneName tempSceneName)
    {
        await AppAsyncLoad(tempSceneName);
    }

    private async Task AppAsyncLoad(SceneName tempSceneName)
    {
        AsyncOperation asyncIt = SceneManager.LoadSceneAsync(tempSceneName.ToString());
        await Task.Yield();
    }
    public void SceneSectionAdd(SceneName tempSceneName, AbstractSection tempSection)
    {
        _sceneSectionDictionary.Add(tempSceneName, tempSection);
    }
}
