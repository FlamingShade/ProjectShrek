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
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("down");
        //throw new NotImplementedException();
    }
    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        
    }
}
