using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneElement : AbstractElement
{
    private List<UnitElement> _unitList = new List<UnitElement>();
    public AbstractLand FirstLand { get ; private set; }
    public AbstractLand Secondland { get ; private set; }

    public override void Initialize()
    {
        base.Initialize();
    }

    public void LandSet(AbstractLand tempFirstLand, AbstractLand tempSecondLand)
    {
        FirstLand = tempFirstLand;
        Secondland = tempSecondLand;
    }

}
