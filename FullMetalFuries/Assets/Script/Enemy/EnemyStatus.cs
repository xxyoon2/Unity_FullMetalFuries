using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    public int Health = 50;

    void Start()
    {
        Health = 50;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
