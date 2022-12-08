using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public string MyName => _myName;
    [SerializeField]
    private string _myName;
}
