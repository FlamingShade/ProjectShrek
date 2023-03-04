using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class AbstractElement
{
    private Dictionary<Type, AbstractModule> _moduleDictionary = new Dictionary<Type, AbstractModule>();
    public ImageModule ImageModule { get; private set; }
    public DataModule DataModule { get; private set; }
    public virtual void Initialize()
    {
        ImageModule = ModuleCreate<ImageModule>();
        DataModule = ModuleCreate<DataModule>();
    }
    public T ModuleCreate<T>() where T : AbstractModule, new()
    {
        T tempModule = new T();
        Type tempType = typeof(T);
        tempModule.HostElementSet(this);
        tempModule.Initialize();
        _moduleDictionary.TryAdd(tempType, tempModule);
        return tempModule;
    }
    public T ModuleGet<T>(AbstractElement tempElement) where T : AbstractModule, new()
    {
        Type tempType = typeof(T);
        if (_moduleDictionary.TryGetValue(tempType, out AbstractModule tempModule))
        {
            return tempModule as T;
        }
        else
        {
            return null;
        }
    }  

}
