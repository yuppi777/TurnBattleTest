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
   
    private void Awake()
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
            if (_myEnemy.EnemyHp>0)
            {
                if (_buttleplayerParametorMaster.HP<_playerParametorMaster.HP)
                {
                    _playerParametorMaster.HP = _buttleplayerParametorMaster.HP;
                }
            }
        }
        else
        {
            Debug.Log("コマンドが選択されていない");
        }
        _myEnemy.EnemyAttack(_buttleplayerParametorMaster);
        SelectedCommand = null;

    }   
    public void Initialization()//数値の初期化
    {
        //_buttleplayerParametorMaster = _playerParametorMaster;
        _buttleplayerParametorMaster.HP = _playerParametorMaster.HP;
        _buttleplayerParametorMaster.DefencePower = _playerParametorMaster.DefencePower;
        _buttleplayerParametorMaster.AttackPower = _playerParametorMaster.AttackPower;
       
    }
}
