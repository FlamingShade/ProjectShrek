using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using System;
public class ResourceDirector : AbstractDirector
{
    private Dictionary<string, AbstractInfo> _infoDictionary = new Dictionary<string, AbstractInfo>();

    public override void Initialize()
    {
        base.Initialize();
        ResourceInfoLoad<LandInfo>();
        ResourceInfoLoad<FragmentInfo>();
        ResourceInfoLoad<LocationInfo>();
        ResourceInfoLoad<UnitInfo>();
        ResourceInfoLoad<ItemInfo>();
    }
    public void ResourceInfoLoad<T>() where T : AbstractInfo
    {
        var tempType = typeof(T);
        var tempInfoArray = Resources.LoadAll<T>(tempType.ToString());
        foreach (var tempInfo in tempInfoArray)
        {
            _infoDictionary.TryAdd(tempInfo.name, tempInfo);
        }
    }
    public AbstractInfo ResourceInfoGet(string tempInfoName) 
    {
        Debug.Log($"key {tempInfoName}");
        _infoDictionary.TryGetValue(tempInfoName, out var tempInfo);
        Debug.Log($"get {tempInfo}");
        return tempInfo;
    }
}
