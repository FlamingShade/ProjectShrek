using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class AbstractSection
{
    private Dictionary<Type, AbstractPart> _partDictionary = new Dictionary<Type, AbstractPart>();
    public ScenePart ScenePart {get; private set;} 
    public MasterPart MasterPart {get; private set;} 
    public UIMasterPart UIMasterPart {get; private set;} 
    public virtual void Initialize()
    {
        ScenePart = PartCreate<ScenePart>();
        MasterPart = PartCreate<MasterPart>();
        UIMasterPart = PartCreate<UIMasterPart>();
        ScenePart.SectionHostSet(this);
    }
    public virtual void Activate()
    {
        AppStatic.SceneDirector.SceneLoad(ScenePart.StartingSceneName);
    }
    private T PartCreate<T>() where T : AbstractPart, new()
    {
        T tempPart = new T();
        Type tempType = typeof(T);
        tempPart.Initialize();
        _partDictionary.TryAdd(tempType, tempPart);
        return tempPart as T;
    }
    private T PartGet<T>() where T : AbstractPart
    {
        Type tempType = typeof(T);
        if (_partDictionary.TryGetValue(tempType, out AbstractPart tempPart))
        {
            return tempPart as T;
        }
        else
        {
            return null;
        }
    }

}
