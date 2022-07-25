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
        Up = Down = Left = Right = false;

        Up = Input.GetKey(KeyCode.W);
        Down = Input.GetKey(KeyCode.S);
        Right = Input.GetKey(KeyCode.D);
        Left = Input.GetKey(KeyCode.A);
    }
}
