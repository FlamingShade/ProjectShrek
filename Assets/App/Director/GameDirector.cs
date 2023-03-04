using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : AbstractDirector
{   
    //PROPERTIES/////////
    private List<string> _basePropertiesList = new List<string>();

    public override void Initialize()
    {
        base.Initialize();
    }
    public void BasePropertiesListSet()
    {
        string[] tempBaseProperties = { "Propertes0", "Propertes1","Propertes2", "Propertes3" };
        _basePropertiesList.AddRange(tempBaseProperties);
    }
    public string PropertiesRandomGet()
    {
        return _basePropertiesList[UnityEngine.Random.Range(0, _basePropertiesList.Count)];
    }
    //PROPERTIES/////////






  

   
   


   
}

