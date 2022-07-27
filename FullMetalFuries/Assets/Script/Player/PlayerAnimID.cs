using UnityEngine;

public class PlayerAnimID
{
    public static readonly int Attack = Animator.StringToHash("attack");
    public static readonly int SpecialAttack = Animator.StringToHash("specialAttack");
    public static readonly int Defense = Animator.StringToHash("defense");
    public static readonly int Dodge = Animator.StringToHash("dodge");

    //public static readonly int Collide = Animator.StringToHash("collide");
}
