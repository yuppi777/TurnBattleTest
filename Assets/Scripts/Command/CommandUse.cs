using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandUse : MonoBehaviour
{
   [SerializeField] PlayerParametorMaster _playerParametorMaster;
    [SerializeField] PlayerParametorMaster _buttleplayerParametorMaster;
    [SerializeField] MyEnemy _myEnemy;
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
                command = new CommandAttak(_myEnemy,_playerParametorMaster);
                break;
            case Command.Heal:
                command = new CommandHeal(_playerParametorMaster);
                break;
            default:
                command = new CommandAttak(_myEnemy,_playerParametorMaster);
                break;
               
        }
        command.Execution();
    }

}
