using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    // public enum SpecialAttackCooTime
    // {
    //     Idle,
    //     Attack,
    //     Defense,
    //     Die
    // }
    public GameObject AttackObject;
    public Vector2 AttackRange = new Vector2(0.2f, 0.2f);
    public GameObject SpecialAttackPosition;
    public float SpecialAttackRange = 1f;

    private AudioSource _audioPlayer;
    private Animator _animator;
    private Player _player;

    //private float _dodgeTime = 5f;

    //[SerializeField]
    //public bool _isEnemy = false;

    void Awake()
    {
        _audioPlayer = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    public void Attack()
    {
        Debug.Log("공격");

        // 공격하는 애니메이션, 소리 출력
        _animator.SetTrigger(PlayerAnimID.Attack);

        Collider2D EnemyColl = Physics2D.OverlapBox(AttackObject.transform.position, AttackRange, 0f);

        if (EnemyColl != null)
        {
            if (EnemyColl.tag == "Enemy")
            {
                Debug.Log($"EnemyColl = {EnemyColl}");
                EnemyColl.GetComponent<EnemyMovement>().TakeDamage(_player.Strength / 3);
            }
        }
    }

    public void Defense()
    {
        Debug.Log("방어");
        _animator.SetTrigger(PlayerAnimID.Defense);
    }

    public void SpecialAttack()
    {
        Debug.Log("특수 공격");
        _animator.SetTrigger(PlayerAnimID.SpecialAttack);
        
        // 여기서 감지하는 충돌체에 트리거도 포함됨... 
        Collider2D[] EnemiesColl = Physics2D.OverlapBoxAll(SpecialAttackPosition.transform.position, new Vector2(SpecialAttackRange, SpecialAttackRange), 0f);

        foreach (Collider2D EnemyColl in EnemiesColl)
        {
            if (EnemyColl.tag == "Enemy")
            {
                Debug.Log($"{EnemyColl}");
                EnemyColl.GetComponent<EnemyMovement>().TakeDamage(_player.Technology - 3);
            }
        }

    }

    public void Dodge()
    {
        Debug.Log("회피");
        _animator.SetTrigger(PlayerAnimID.Dodge);
    }
}