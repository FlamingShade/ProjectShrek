using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LocationInfo", menuName = "Gameplay/LocationInfo/New LocationInfo")]
public class LocationInfo : AbstractInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _name;
}