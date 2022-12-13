using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyEnemy : MonoBehaviour
{
    public string MyName => _myName;
    [SerializeField]
    private string _myName;
    [SerializeField]
    public int EnemyHp;
    [SerializeField]
    private Text EnemyHpText;
    [SerializeField]
    [Header("�U����")]
    public int AttackPower;//�G�̍U����
    [SerializeField]
    [Header("�h���")]
    public int DefensePower;//�G�̖h���



    private void Update()
    {
        if (EnemyHp < 0 )
        {
            Destroy(this.gameObject);
        }
        EnemyHpText.text = "HP"+ EnemyHp.ToString();
    }
   private void EnemyAttack()
    {

    }


}
