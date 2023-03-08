using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public abstract class AbstractLand : AbstractElement
{
    public Type Loot {get; private set;}
    public List<string> currentPropertiesList = new List<string>();

    public override void Initialize()
    {
        base.Initialize();
    }
    public void LootSet<T>() where T : AbstractItem
    {
        this.Loot = typeof(T);
    }
    public virtual void PropertiesApply()
    {
        var tempProperty = AppStatic.GameDirector.PropertiesRandomGet();
        currentPropertiesList.Add(tempProperty);
    }
}


