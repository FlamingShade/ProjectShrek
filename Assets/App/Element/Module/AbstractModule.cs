using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractModule 
{
    public AbstractElement hostElement;
    public virtual void Initialize()
    {

    }
    public void HostElementSet(AbstractElement tempElement)
    {
        hostElement = tempElement;
    } 
}
