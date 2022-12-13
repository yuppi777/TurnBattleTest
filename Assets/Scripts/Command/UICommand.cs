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
            Debug.Log("�R�}���h���I������Ă��Ȃ�");
        }
        SelectedCommand = null;

    }   
    public void Initialization()//�v���C���[���l�̏�����
    {
        _buttleplayerParametorMaster = _playerParametorMaster;
    }

}
