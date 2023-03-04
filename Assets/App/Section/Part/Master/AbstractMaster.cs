using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public abstract class AbstractMaster 
{
    public int uniqueNameCount = 0;
    private Dictionary<string, AbstractElement> _elementDictionary = new Dictionary<string, AbstractElement>();
    private Dictionary<string, Action> _creatorActionDictionary = new Dictionary<string, Action>();
    private List<Action> _creatorActionList = new List<Action>();
    private List<AbstractElement> _elementList = new List<AbstractElement>();
    public virtual void Initialize()
    {
    
    }    
    public void ElementTemplateAdd<T>() where T : AbstractElement, new()
    {
         var tempElementTypeName = typeof(T).ToSafeString();
        _creatorActionList.Add( () => ElementCreate<T>());
        _creatorActionDictionary.Add(tempElementTypeName, () => ElementCreate<T>());
    }
    public AbstractElement ElementCreate(int tempCount)
    {
        _creatorActionList[tempCount]();
        return _elementList[_elementList.Count-1];
    }
    public AbstractElement ElementCreate(string tempElementTypeName)
    {
        _creatorActionDictionary.TryGetValue(tempElementTypeName, out var tempAction);
        tempAction();
        return _elementList[_elementList.Count - 1];
    }
    public T ElementCreate<T>() where T : AbstractElement, new()
    {
        T tempElement = new T();
        Type tempType = typeof(T);
        string tempUniqueName = tempElement.ToString()+"_"+ uniqueNameCount;
        uniqueNameCount += 1;
        tempElement.Initialize();
        Debug.Log($"element created {tempUniqueName}");
        _elementDictionary.TryAdd(tempUniqueName, tempElement);
        _elementList.Add(tempElement);
        return tempElement;
    }
    public AbstractElement RandomElementGet()
    {
        return _elementList[UnityEngine.Random.Range(0, _elementList.Count)];
    }
    public T ElementGet<T>(string tempUniqueName) where T : AbstractElement, new()
    {
        Type tempType = typeof(T);
        if (_elementDictionary.TryGetValue(tempUniqueName, out AbstractElement tempElement))
        {
            return tempElement as T;
        }
        else
        {
            return null;
        }
    }  

}
