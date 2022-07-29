using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Enemy _enemy;
    //private Animation _animation;
    void Awake()
    {
        _enemy = GetComponent<Enemy>();
    }

    public void TakeDamage(int damage)
    {
        _enemy.Health -= damage;
        Debug.Log($"Damage - {damage}");
    }

    public void Down()
    {

    }
}
