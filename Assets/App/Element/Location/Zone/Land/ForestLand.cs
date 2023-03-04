using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestLand : AbstractLand
{
   
   public override void Initialize()
   {
        base.Initialize();
        LootSet<SwordWeapon>();

   }


   
}
