using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
public static class AppStatic 
{
    public enum Lands
    {
        ForestLand,
        PlainLand,
        MountainLand
    }
    private static Dictionary<Type, AbstractDirector> _directorDictionary = new Dictionary<Type, AbstractDirector>();
    public static SceneDirector SceneDirector {get; private set;} 
    public static ResourceDirector ResourceDirector {get; private set;} 
    public static SectionDirector SectionDirector {get; private set;} 
    public static GameDirector GameDirector {get; private set;}
    public static StateDirector StateDirector { get; private set; }
    public static EventDirector EventDirector { get; private set; }
    public static void AppInitialize()
    {
        SceneDirector = DirectorCreate<SceneDirector>();
        ResourceDirector = DirectorCreate<ResourceDirector>();
        SectionDirector = DirectorCreate<SectionDirector>();
        GameDirector = DirectorCreate<GameDirector>();
        StateDirector = DirectorCreate<StateDirector>();
        EventDirector = DirectorCreate<EventDirector>();
    }
    private static T DirectorCreate<T>() where T : AbstractDirector, new()
    {
        var tempDirector = new T();
        var tempType = typeof(T);
        tempDirector.Initialize();
        _directorDictionary.TryAdd(tempType, tempDirector);
        //Debug.Log($"{tempDirector} tempDirector");
        return tempDirector as T;
    }
    private static T DirectorGet<T>() where T : AbstractDirector, new()
    {
        Type tempType = typeof(T);
        if (_directorDictionary.TryGetValue(tempType, out AbstractDirector tempDirector))
        {
            return tempDirector as T;
        }
        else
        {
            return null;
        }
    }
    public static void AppRun()
    {
        AppStatic.AppInitialize();
        AppStatic.SectionDirector.CurrentSectionSet<GlobalMapSection>();
        AppStatic.StateDirector.SwitchState<GlobalMapState>();
    }
}
