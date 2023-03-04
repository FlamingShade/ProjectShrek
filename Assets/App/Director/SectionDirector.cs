using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class SectionDirector : AbstractDirector
{
    private Dictionary<Type, AbstractSection> _sectionDictionary = new Dictionary<Type, AbstractSection>();
    public AbstractSection CurrentSection {get; private set;}
    public override void Initialize()
    {
        base.Initialize();
        EventDirector.OnEnterStateEventHandler += OnStateEntered;
        EventDirector.OnExitStateEventHandler += OnStateExited;
        SectionCreate<AppStartSection>();
        SectionCreate<MainMenuSection>();
        SectionCreate<GlobalMapSection>();
    }

    public void CurrentSectionSet<T>() where T : AbstractSection
    {
        T tempSection = SectionGet<T>();
        CurrentSection = tempSection;
        tempSection.Activate();
    }
    public void SectionCreate<T>() where T : AbstractSection, new()
    {
        T tempSection = new T();
        Type tempType = typeof(T);
        tempSection.Initialize();
        var tempBool = _sectionDictionary.TryAdd(tempType, tempSection);
        Debug.Log($"{tempBool} {tempType}");
    }
    public T SectionGet<T>() where T : AbstractSection
    {
        Type tempType = typeof(T);
        if (_sectionDictionary.TryGetValue(tempType, out AbstractSection tempSection))
        {
            return tempSection as T;
        }
        else
        {
            return null;
        }
    }    
    public void OnStateExited()
    {
        Debug.Log("SectionDirector: some state exited ");
    }
    public void OnStateEntered()
    {
        Debug.Log("SectionDirector: some state entered ");
    }
}
