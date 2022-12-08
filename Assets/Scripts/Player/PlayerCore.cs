using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Mover;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤーの動きのスクリプト")]
    private PlayerMover playerMover;

   [SerializeField] private PlayerParamater playerParamater;





    private void Awake()
    {
        
    }
    private void Start()
    {
        playerMover.OnInitialize();
      
        


    }

    private void Update()
    {
        playerMover.PlayerMove(playerParamater.PlayerMoveSpeed);
        //PlayerMover.PlayerJump(PlayerParametor.PlayerJumpPower);
    }

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" )
        {

            OriginalSceneManager.Instance.SceneChange("BattleScene");
           
        }

    }
}
