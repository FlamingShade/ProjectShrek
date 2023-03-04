using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public abstract class AbstractLand : AbstractElement
{
    public Type Loot {get; private set;}
    public List<string> currentPropertiesList = new List<string>();
    //private List<UnitInfo> _availableUnitInfoList = new List<UnitInfo>();
    public override void Initialize()
    {

        PropertiesApply();
        PropertiesApply();    

    }
    public void LootSet<T>() where T : AbstractItem
    {
        this.Loot = typeof(T);
    }

    public void AvailableUnitInfoListFill()
    {
        //где-то в ScrObj должен быть список с юнитами, доступными для данной земли
    }


    public virtual void PropertiesApply()
    {
        var tempProperty = AppStatic.GameDirector.PropertiesRandomGet();
        currentPropertiesList.Add(tempProperty);
    }
}


