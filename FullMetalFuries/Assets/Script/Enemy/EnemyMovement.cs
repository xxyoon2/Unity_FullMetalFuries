using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private EnemyStatus _status;
    private Animation _animation;
    void Awake()
    {
        _status = GetComponent<EnemyStatus>();
    }

    public void TakeDamage(int damage)
    {
        _status.Health -= damage;
    }

    public void Down()
    {

    }
}
