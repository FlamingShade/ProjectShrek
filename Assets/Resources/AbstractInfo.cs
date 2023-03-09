using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractInfo : ScriptableObject
{
    [SerializeField] private string _testString;
    public string testString => _testString;
}
