using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpecialAttackState : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      animator.GetComponent<Player>().MoveSpeed = 0f;
    }
    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.GetComponent<Player>().MoveSpeed = 20f;
    }
}