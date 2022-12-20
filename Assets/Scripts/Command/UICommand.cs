using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICommand : MonoBehaviour
{
    private ICommand SelectedCommand;

    [SerializeField]
    PlayerParametorMaster _playerParametorMaster;//���ՓI�ł���v���C���[�̃X�e�[�^�X
    [SerializeField] 
    PlayerParametorMaster _buttleplayerParametorMaster;//�o�g�����̃R�}���h�ɂ���ĕς��X�e�[�^�X
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
            Debug.Log("�R�}���h���I������Ă��Ȃ�");
        }
        _myEnemy.EnemyAttack(_buttleplayerParametorMaster);
        SelectedCommand = null;

    }   
    public void Initialization()//���l�̏�����
    {
        //_buttleplayerParametorMaster = _playerParametorMaster;
        _buttleplayerParametorMaster.HP = _playerParametorMaster.HP;
        _buttleplayerParametorMaster.DefencePower = _playerParametorMaster.DefencePower;
        _buttleplayerParametorMaster.AttackPower = _playerParametorMaster.AttackPower;
       
    }
}
