using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class PlayerHpText : MonoBehaviour
{
    [SerializeField] Text PlayerHp;
    [SerializeField] PlayerParametorMaster playerParametorData;
    void Start()
    {
        playerParametorData._HP
            .DistinctUntilChanged()
            .Subscribe(x => PlayerHp.text = ("�̗�")+x.ToString());
    }
    //ReactiveProperty<int>
    // Update is called once per frame
   
}
