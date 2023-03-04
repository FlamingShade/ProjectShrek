using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ResourceDirector : AbstractDirector
{
    private List<LandInfo> _landInfoList = new List<LandInfo>();
    //private List<UnitInfo> _unitInfoList = new List<UnitInfo>();
    //private List<ItemInfo> _itemInfoList = new List<ItemInfo>();
    public override void Initialize()
    {
        base.Initialize();
        var tempLandInfoArray = Resources.LoadAll<LandInfo>("LandInfo");
        foreach (var tempLand in tempLandInfoArray)
        {
            _landInfoList.Add(tempLand);
        }
    }
}
