using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : StateMachineBehaviour
{
    PlayerSkill pSkill;
    Player player;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<Player>().MoveSpeed = 40f;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Debug.Log("damage += 10");
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.GetComponent<Player>().MoveSpeed = 20f;
    }
}
