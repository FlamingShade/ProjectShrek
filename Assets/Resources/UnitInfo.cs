using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitInfo", menuName = "Gameplay/UnitInfo/New UnitInfo")]
public class UnitInfo : AbstractInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _name;
}
