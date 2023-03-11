using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataModule : AbstractModule
{
    private string _resourceInfoString;
    public AbstractInfo dataInfo;
    public override void Initialize()
    {
        base.Initialize();
        _resourceInfoString = hostElement.ToString() + "Info"; 
        dataInfo = AppStatic.ResourceDirector.ResourceInfoGet(_resourceInfoString);
        //Debug.Log($"data info {dataInfo.testString}");
    }
}