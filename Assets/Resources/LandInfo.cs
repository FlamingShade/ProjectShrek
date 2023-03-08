using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LandInfo", menuName = "Gameplay/LandInfo/New LandInfo")]

public class LandInfo : AbstractInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _name;

    /*[SerializeField] private GameObject _prefab;
    [SerializeField] private List<string> _ListPropirtes;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _loot;

    public string id => this._id;
    public string landName => this._landName;
    public GameObject prefab => this._prefab;
    public Sprite spriteIcon => this._sprite;
    public string loot => _loot;
*/

}
