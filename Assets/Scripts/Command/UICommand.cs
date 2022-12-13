using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICommand : MonoBehaviour
{
    private ICommand SelectedCommand;

    [SerializeField]
    PlayerParametorMaster _playerParametorMaster;//普遍的であるプレイヤーのステータス
    [SerializeField] 
    PlayerParametorMaster _buttleplayerParametorMaster;//バトル中のコマンドによって変わるステータス
    [SerializeField]
    MyEnemy _myEnemy;
    private void Start()
    {
        Initialization();
    }
    public void AttackSelected()
    {
        SelectedCommand = new CommandAttak(_myEnemy,_buttleplayerParametorMaster);
    }
    public void HealSeleceted()
    {
        SelectedCommand = new CommandHeal(_buttleplayerParametorMaster);
    }
    public void Execution()
    {
        if (SelectedCommand != null)
        {
            
            SelectedCommand.Execution();
        }
        else
        {
            Debug.Log("コマンドが選択されていない");
        }
        SelectedCommand = null;

    }   
    public void Initialization()//プレイヤー数値の初期化
    {
        _buttleplayerParametorMaster = _playerParametorMaster;
    }

}
