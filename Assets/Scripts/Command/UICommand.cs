using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICommand : MonoBehaviour
{
    private ICommand SelectedCommand;

    [SerializeField]
    PlayerParametorMaster _playerParametorMaster;

    public void AttackSelected()
    {
        SelectedCommand = new CommandAttak();
    }
    public void HealSeleceted()
    {
        SelectedCommand = new CommandHeal(_playerParametorMaster);
    }
    public void Execution()
    {
        if (SelectedCommand != null)
        {
           
            SelectedCommand.Execution();
        }
        else
        {
            Debug.Log("�R�}���h���I������Ă��Ȃ�");
        }
        SelectedCommand = null;

    }   
}
