using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandAttak : ICommand
{
    private MyEnemy myEnemy;
    private PlayerParametorMaster parametorMaster;
    public CommandAttak(MyEnemy myenem,PlayerParametorMaster param)
    {

        myEnemy = myenem;
        parametorMaster = param;
    }
    public void Execution()
    {
        Debug.Log("�U��");
        int attackpoint;
        attackpoint = parametorMaster.AttackPower - myEnemy.DefensePower;

        if (attackpoint > 0)
        {
            myEnemy.EnemyHp -= attackpoint;
        }
        else
        {
            Debug.Log("�v���C���[�̍U���͂�����̖h��͂��������");
        }
        
    }
}
