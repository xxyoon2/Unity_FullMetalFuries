using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState {
    Normal,
    Attack,
    Defanse,
    Dodge,
    Die
}

public class Player : MonoBehaviour
{ 
    // 플레이어 스탯
    public int Health = 100;
    public int Strength = 25;
    public int Technology = 25;

    public float MoveSpeed = 1f;
    public float SpecialAttackCooTime = 11f;
    public float DodgeCoolTime = 7f;

    //public PlayerState State = PlayerState.Normal;

    void Start()
    {
        Health = 100;
        Strength = 25;
        Technology = 25;
    }
}
