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
        //Transform oTransform = other.GetComponent<Transform>();
        SpriteRenderer oRenderer = other.GetComponent<SpriteRenderer>();
        float oTransform = other.transform.position.y;
        
        if (transform.position.y > other.transform.position.y)
        {
            isback = true;
        }

        if (isback)
        {
            _spriteRenderer.sortingOrder = oRenderer.sortingOrder - 2;
            Debug.Log($"Stay - Other : {other.name}, {_spriteRenderer.sortingOrder}");
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        _spriteRenderer.sortingOrder = 10;
        isback = false;
        Debug.Log($"Exit - Other : {other.name}, {_spriteRenderer.sortingOrder}");
    }

    void Update()
    {
        //_rigidbody.AddForce(new Vector2(0f, MoveSpeed));
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
            //_animator.SetTrigger("attack");
            _skill.Attack();
            Debug.Log($"클릭");
        }
        if (_input.CanDefense)
        {
            Debug.Log("방어");
        }
        if (_input.CanSpecialAttack)
        {
            Debug.Log("특수 공격");
        }
        if (_input.CanDodge)
        {
            Debug.Log("회피");
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
