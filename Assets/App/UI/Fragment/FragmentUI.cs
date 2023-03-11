using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems; 
using System.Text;
using UnityEngine.TextCore;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class FragmentUI : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private ScriptableObject _fragmentInfo;
    [SerializeField] private AbstractElement _fragmentElement;
    public void OnPointerClick(PointerEventData eventData)
    {
        //var temp = _fragmentInfo.
        //Debug.Log(temp.);
        //throw new NotImplementedException();
    }
    void Start()
    {
        var tempFragmentMaster = AppStatic.SectionDirector.SectionGet<BoneRitualCaveSection>().MasterPart.MasterGet<FragmentMaster>();
        var tempString = _fragmentInfo.name;
        var tempNewString = tempString.Remove(tempString.Length - 4);
        _fragmentElement = tempFragmentMaster.ElementCreate(tempNewString);
        //Debug.Log(tempNewString);
        //Debug.Log(_fragmentElement.DataModule.dataInfo.testString);
    }

    void Update()
    {
        
    }
}
