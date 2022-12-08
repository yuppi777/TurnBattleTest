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
    public int AttackPower => _attackPower;
    public int DefensePower => _defensePower;
    public int Money => _money;


    [SerializeField]
    [Header("プレイヤーの体力")]
    ReactiveProperty<int>  _hp;
    public int HP { set { _hp.Value = value; } get { return _hp.Value; } }

    [SerializeField]
    [Header("プレイヤーの攻撃力")]
    private int _attackPower;
    [SerializeField]
    [Header("プレイヤーの防御力")]
    private int _defensePower;
    [SerializeField]
    [Header("プレイヤーの所持金")]
    private int _money;

    public enum JobPost
    {
        Programer,
        Farmers,
        Idol,
    }


    
   
}
