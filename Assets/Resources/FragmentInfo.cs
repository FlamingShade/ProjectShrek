using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "FragmentInfo", menuName = "Gameplay/FragmentInfo/New FragmentInfo")]

public class FragmentInfo : AbstractInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _fragmentName;
    [SerializeField] private GameObject _fragmentUI;

    public string id => this._id;
    public string fragmentName => this._fragmentName;
}
