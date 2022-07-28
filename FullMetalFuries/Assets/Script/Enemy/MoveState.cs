using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : StateMachineBehaviour
{
    Transform EnemyTransform;
    Enemy Enemy;
    public float MoveTime = 4f;
    private float countTime = 0f;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EnemyTransform = animator.GetComponent<Transform>();
        Enemy = animator.GetComponent<Enemy>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Vector2.Distance(Enemy.TargetTransform.position, EnemyTransform.position) > 0.5f)
        {
            if (Vector2.Distance(Enemy.TargetTransform.position, EnemyTransform.position) < 1.5f)
            {
                animator.SetTrigger("Attack");
            }
            EnemyTransform.position = Vector2.MoveTowards(EnemyTransform.position, Enemy.TargetTransform.position, Time.deltaTime * Enemy.Speed);
        }
        countTime += Time.deltaTime;

        if (countTime >= MoveTime)
        {
            animator.SetBool("isFollow", false);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        countTime = 0f;
    }
}
