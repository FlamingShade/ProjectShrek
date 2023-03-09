using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentMaster : AbstractMaster
{
    public override void Initialize()
    {
        base.Initialize();
        ElementTemplateAdd<AltarFragment>();
        ElementTemplateAdd<PileOfBonesFragment>();
        ElementTemplateAdd<BoneChamberDoorFragment>();
        ElementTemplateAdd<TorchHandlerFragment>();
        ElementTemplateAdd<BoneChamberFragment>();
    }
}
