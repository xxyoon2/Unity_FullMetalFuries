using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public bool CanAttack { get; private set; }
    public bool CanDefense { get; private set;}
    public bool CanSpecialAttack { get; private set; }
    public bool CanDodge { get; private set;}

    void Update()
    {
        Up = Down = Left = Right = CanAttack = CanDefense = CanSpecialAttack = CanDodge = false;

        Up = Input.GetKey(KeyCode.W);
        Down = Input.GetKey(KeyCode.S);
        Right = Input.GetKey(KeyCode.D);
        Left = Input.GetKey(KeyCode.A);

        CanAttack = Input.GetMouseButtonDown(0);
        CanDefense = Input.GetMouseButton(1);
        CanSpecialAttack = Input.GetKeyDown(KeyCode.F);
        CanDodge = Input.GetKeyDown(KeyCode.Space);
    }
}
