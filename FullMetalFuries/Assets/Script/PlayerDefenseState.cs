using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefenseState : StateMachineBehaviour
{
    public GameObject Shield;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<Player>().MoveSpeed = 1f;
        Shield.GetComponent<Shield>().ProtectPlayer(true);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.GetComponent<Player>().MoveSpeed = 10f;
       Shield.GetComponent<Shield>().ProtectPlayer(false);
    }
}
