using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : StateMachineBehaviour
{
    PlayerSkill pSkill;
    Player player;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //animator.SetBool("canDodgeAttack", false);
        Debug.Log("졸려1");
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Debug.Log("졸려2");
       
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       //animator.SetBool("canDodgeAttack", true);
       Debug.Log("졸려3");
    }
}
