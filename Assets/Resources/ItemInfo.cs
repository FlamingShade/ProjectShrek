using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemInfo", menuName = "Gameplay/ItemInfo/New ItemInfo")]

public class ItemInfo : AbstractInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _name;
}