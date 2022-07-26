using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{ 
    // 플레이어 스탯
    public int PlayerHealth = 100;
    public int PlayerStrength = 25;
    public int technology = 25;

    void Start()
    {
        PlayerHealth = 100;
        PlayerStrength = 25;
        technology = 25;
    }
}
