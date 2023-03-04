using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MasterPart : AbstractPart
{
    private Dictionary<Type, AbstractMaster> _masterDictionary = new Dictionary<Type, AbstractMaster>();
    public T MasterCreate<T>() where T : AbstractMaster, new()
    {
        T tempMaster = new T();
        Type tempType = typeof(T);
        tempMaster.Initialize();
        _masterDictionary.Add(tempType, tempMaster);
        return tempMaster;
    }
    public T MasterGet<T>() where T : AbstractMaster, new()
    {
        Type tempType = typeof(T);
        if (_masterDictionary.TryGetValue(tempType, out AbstractMaster tempMaster))
        {
            return tempMaster as T;
        }
        else
        {
            return null;
        }
    }

    public override void Initialize()
    {
        base.Initialize();
        //Debug.Log("MasterInit");

    }
}
