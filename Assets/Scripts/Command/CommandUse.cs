using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandUse : MonoBehaviour
{
   [SerializeField] PlayerParametorMaster _playerParametorMaster;
    public enum Command
    {
        Attack,
        Heal,
    }
    public Command SelectCommand;
    void Start()
    {
        ICommand command;
        switch (SelectCommand)
        {
            case Command.Attack:
                command = new CommandAttak();
                break;
            case Command.Heal:
                command = new CommandHeal(_playerParametorMaster);
                break;
            default:
                command = new CommandAttak();
                break;
               
        }
        command.Execution();
    }

}
