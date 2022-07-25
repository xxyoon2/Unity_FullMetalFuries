using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // public string VerticalMoveAxisName = "Vertical";
    // public string HorizontalMoveAxisName = "Horizontal";
    // public string AttackName = "Attack";
    // public string DefenseName = "Sec";
    // public string SpecialAttackName = "Evade";
    // public string DodgeName = "Power";

    // public float VerticalMoveDirection { get; private set; }
    // public float HorizontalMoveDirection { get; private set; }
    // public bool CanAttack { get; private set; }
    // public bool CanDefense { get; private set;}
    // public bool CanSpecialAttack { get; private set; }
    // public bool CanDodge { get; private set;}

    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    void Update()
    {
        // VerticalMoveDirection = Input.GetAxis(VerticalMoveAxisName);
        // HorizontalMoveDirection = Input.GetAxis(HorizontalMoveAxisName);

        // CanAttack = Input.GetButtonDown(AttackName);
        // CanDefense = Input.GetButton(DefenseName);
        // CanSpecialAttack = Input.GetButtonDown(SpecialAttackName);
        // CanDodge = Input.GetButtonDown(DodgeName);
        Up = Down = Left = Right = false;

        Up = Input.GetKey(KeyCode.W);
        Down = Input.GetKey(KeyCode.S);
        Right = Input.GetKey(KeyCode.D);
        Left = Input.GetKey(KeyCode.A);
    }
}
