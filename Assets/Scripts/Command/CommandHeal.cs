using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHeal : ICommand
{
    private PlayerParametorMaster buttlescenePlayerParamator;
    public CommandHeal(PlayerParametorMaster param)
    {

        buttlescenePlayerParamator = param;
    }
    public void Execution()
    {
        buttlescenePlayerParamator.HP += 10;
        Debug.Log("‰ñ•œ");
    }
}
