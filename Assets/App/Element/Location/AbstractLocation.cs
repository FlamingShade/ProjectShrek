using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractLocation : AbstractElement
{
    private List<AbstractZone> _zoneList = new List<AbstractZone>();
    public void AllZonesGeneration()
    {

    }
    public void ZoneGeneration()
    {
        //var tempGlobalMapSection = AppStatic.sectionDirector.SectionGet<GlobalMapSection>();
        //tempGlobalMapSection.masterPart.MasterGet<ZoneMaster>().ElementCreate<ZoneElement>();
        //for (int it = 0; it < 4; it++)
        //{
        //}
    }
}
