using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHeal : ICommand
{
    private PlayerParametorMaster playerParametorMaster;
    public CommandHeal(PlayerParametorMaster param) {

        playerParametorMaster = param;
    }
    public void Execution()
    {
        playerParametorMaster.HP += 10;
        Debug.Log("‰ñ•œ");
    }
}
