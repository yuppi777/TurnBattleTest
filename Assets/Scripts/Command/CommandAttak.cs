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
        Debug.Log("UŒ‚");
        int attackpoint;
        attackpoint = parametorMaster.AttackPower - myEnemy.DefensePower;

        if (attackpoint > 0)
        {
            myEnemy.EnemyHp -= attackpoint;
        }
        else
        {
            Debug.Log("ƒvƒŒƒCƒ„[‚ÌUŒ‚—Í‚ª‘Šè‚Ì–hŒä—Í‚ğ‰º‰ñ‚Á‚½");
        }
        
    }
}
