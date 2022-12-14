using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class PlayerHpText : MonoBehaviour
{
    [SerializeField] Text PlayerHp;
    [SerializeField] PlayerParametorMaster buttlesceneplayerparamator;
    void Start()
    {
        buttlesceneplayerparamator._HP
            .DistinctUntilChanged()
            .Subscribe(x => PlayerHp.text = ("‘Ì—Í")+x.ToString());
    }
    //ReactiveProperty<int>
    // Update is called once per frame
   
}
