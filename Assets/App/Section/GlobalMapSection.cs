using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMapSection : AbstractSection
{
    public override void Initialize()
    {
        base.Initialize();
        MasterPart.MasterCreate<LocationMaster>();
        MasterPart.MasterCreate<ZoneMaster>();
        MasterPart.MasterCreate<UnitMaster>();
        MasterPart.MasterCreate<LandMaster>();
        ScenePart.SceneNameAdd(SceneDirector.SceneName.GlobalMapScene);
        ScenePart.StartingSceneSet(SceneDirector.SceneName.GlobalMapScene);
    }
    public AbstractLocation LocationGeneration()
    {   
        var tempLocationMaster = this.MasterPart.MasterGet<LocationMaster>();
        var tempLocationElement = tempLocationMaster.ElementCreate<FirstLocation>();
        tempLocationElement.AllZonesGeneration();
        return tempLocationElement;
    }
 
    public override void Activate()
    {
        base.Activate();
        AppStatic.StateDirector.SwitchState<GlobalMapState>();
        //LocationMaster tempLocationMaster = MasterPart.MasterCreate<LocationMaster>();
        //LocationElement tempLocation = tempLocationMaster.ElementCreate<LocationElement>();
        //tempLocation.ContentGenerate();
        //LandMaster tempLandMaster = MasterPart.MasterCreate<LandMaster>();
        Debug.Log("MapInitEnd");
    }
}
