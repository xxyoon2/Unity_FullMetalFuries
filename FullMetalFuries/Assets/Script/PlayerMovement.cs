using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;
    //private Animator _animator;
    void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        //_animator = GetComponent<Animator>();
    }

    void Update()
    {
        //_rigidbody.AddForce(new Vector2(0f, MoveSpeed));
        if (_input.Up)
        {
            _rigidbody.AddForce(new Vector2(0f, MoveSpeed));
        }
        if (_input.Down)
        {
            _rigidbody.AddForce(new Vector2(0f, -MoveSpeed));
        }
        if (_input.Right)
        {
            _rigidbody.AddForce(new Vector2(MoveSpeed, 0f));
        }
        if (_input.Left)
        {
            _rigidbody.AddForce(new Vector2(-MoveSpeed, 0f));
        }
    }
}
