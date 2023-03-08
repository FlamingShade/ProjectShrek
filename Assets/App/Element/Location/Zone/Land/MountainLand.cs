using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainLand : AbstractLand
{
    public override void Initialize()
    {
        base.Initialize();
        LootSet<TwoHandSwordWeapon>();
    }
}
