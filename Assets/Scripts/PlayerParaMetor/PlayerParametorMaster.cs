using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

[CreateAssetMenu(menuName = "ScriptableObject/CreateAsset")]
public class PlayerParametorMaster : ScriptableObject
{
    public PlayerParametorMaster.JobPost Post;
    public IReactiveProperty<int> _HP => _hp;
    public IReactiveProperty<int> _AttackPower => _attackPower;
    public IReactiveProperty<int> _DefensePower => _defensePower;
    public int Money => _money;


    [SerializeField]
    [Header("�v���C���[�̗̑�")]
    ReactiveProperty<int>  _hp;
    public int HP { set { _hp.Value = value; } get { return _hp.Value; } }

    [SerializeField]
    [Header("�v���C���[�̍U����")]
    ReactiveProperty<int> _attackPower;
    public int AttackPower {set { _attackPower.Value = value; } get { return _attackPower.Value; } }

    [SerializeField]
    [Header("�v���C���[�̖h���")]
    ReactiveProperty<int>  _defensePower;
    public int DefencePower { set { _defensePower.Value = value; }get { return _defensePower.Value; } }

    [SerializeField]
    [Header("�v���C���[�̏�����")]
    private int _money;

    public enum JobPost
    {
        Programer,
        Farmers,
        Idol,
    }


    
   
}
