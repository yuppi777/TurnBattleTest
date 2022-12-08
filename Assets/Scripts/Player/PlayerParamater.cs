using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParamater :MonoBehaviour
{
    
    [SerializeField] private float _playerMoveSpeed;
    public float PlayerMoveSpeed => _playerMoveSpeed;
}
