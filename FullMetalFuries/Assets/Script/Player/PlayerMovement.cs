using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    public int MoveSpeed = 1;
    public bool isback = false;

    private PlayerInput _input;
    private PlayerSkill _skill;
    
    void Awake()
    {
        
        _input = GetComponent<PlayerInput>();
        _skill = GetComponent<PlayerSkill>();
        
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        SpriteRenderer oRenderer = other.GetComponent<SpriteRenderer>();
        float oTransform = other.transform.position.y;
        
        if (transform.position.y > other.transform.position.y)
        {
            isback = true;
        }

        if (isback)
        {
            _spriteRenderer.sortingOrder = oRenderer.sortingOrder - 2;
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        _spriteRenderer.sortingOrder = 10;
        isback = false;
    }

    void Update()
    {
        if (_input.Up)
        {
            _rigidbody.AddForce(new Vector2(0, MoveSpeed));
        }
        if (_input.Down)
        {
            _rigidbody.AddForce(new Vector2(0, -MoveSpeed));
        }
        if (_input.Right)
        {
            _rigidbody.AddForce(new Vector2(MoveSpeed, 0));
        }
        if (_input.Left)
        {
            _rigidbody.AddForce(new Vector2(-MoveSpeed, 0));
        }
        if (_input.CanAttack)
        {
            _skill.Attack();
        }
        if (_input.CanDefense)
        {
            _skill.Defense();
        }
        if (_input.CanSpecialAttack)
        {
            _skill.SpecialAttack();
        }
        if (_input.CanDodge)
        {
            _skill.Dodge();
        }


        if (_rigidbody.velocity.normalized.x != 0 || _rigidbody.velocity.normalized.y != 0)
        {
            _animator.SetBool("isWalking", true);
            if (_rigidbody.velocity.normalized.x > 0)
            {
                transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            }
            else
            {
                transform.localScale = new Vector3(-1.5f, 1.5f, 1f);
            }
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }
}
