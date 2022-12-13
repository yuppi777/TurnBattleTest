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
        Debug.Log("çUåÇ");
        myEnemy.EnemyHp -= parametorMaster.AttackPower;
    }
}
