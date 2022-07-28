using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Enemy _status;
    private Animation _animation;
    void Awake()
    {
        _status = GetComponent<Enemy>();
    }

    public void TakeDamage(int damage)
    {
        _status.Health -= damage;
    }

    public void Down()
    {

    }
}
