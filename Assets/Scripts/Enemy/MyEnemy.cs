using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public string MyName => _myName;
    [SerializeField]
    private string _myName;
    [SerializeField]private int EnemyHp;

    private void Update()
    {
        if (EnemyHp < 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
