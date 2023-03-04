using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMaster : AbstractMaster
{
    public override void Initialize()
    {
        base.Initialize();

        ElementTemplateAdd<ForestLand>();
        ElementTemplateAdd<MountainLand>();

        var tempLand0 = ElementCreate<ForestLand>();
        var tempLand1 = ElementCreate<ForestLand>();
        var tempLand2 = ElementCreate<MountainLand>();
        var tempLand3 = ElementCreate<ForestLand>();

        ElementCreate(0);
        ElementCreate(1);
        ElementCreate("ForestLand");
        ElementCreate("MountainLand");
    }

}
