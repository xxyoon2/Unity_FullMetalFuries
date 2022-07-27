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
    private PlayerData _data;

    public int PlayerHealth = 100;
    public int PlayerStrength = 25;
    public int Playertechnology = 25;

    public float SpecialAttackCooTime = 11f;
    public float DodgeCoolTime = 7f;

    private float _dodgeTime = 5f;

    //[SerializeField]
    //public bool _isEnemy = false;

    void Awake()
    {
        _audioPlayer = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _data = GetComponent<PlayerData>();
    }

    public void Attack()
    {
        Debug.Log("공격");

        // 공격하는 애니메이션, 소리 출력
        _animator.SetTrigger(PlayerAnimID.Attack);

        Collider2D EnemyColl = Physics2D.OverlapBox(AttackObject.transform.position, AttackRange, 0f);

        if (EnemyColl != null)
        {
            Debug.Log($"EnemyColl = {EnemyColl}");
            if (EnemyColl.tag == "Enemy")
            {
                //EnemyColl.GetComponent<EnemyStatus>().TakeDamage(PlayerStrength / 3);
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
                //EnemyColl.GetComponent<EnemyStatus>().TakeDamage(Playertechnology - 3);
            }
        }

    }

    public void Dodge()
    {
        Debug.Log("회피");
        _animator.SetTrigger(PlayerAnimID.Dodge);
        // float countTime = 0f;

        // while (countTime < _dodgeTime)
        // {
        //     Collider2D EnemyColl = Physics2D.OverlapBox(AttackObject.transform.position, AttackRange, 0f);
        //     Debug.Log("콜라이더 검출하기");
        //     if (EnemyColl != null)
        //     {
        //         if (EnemyColl.tag == "Enemy")
        //         {
        //             EnemyColl.GetComponent<EnemyStatus>().TakeDamage(Playertechnology - 5);
        //             _animator.SetBool("doAttack", true);
        //             Debug.Log("부딪힘");
        //         }

        //         break;
        //     }
        //     Debug.Log("널널~~하다");
        //     countTime += Time.deltaTime;
        // }

        // _animator.SetBool("doAttack", true);
        // _animator.SetTrigger(PlayerAnimID.Collide);
        // _animator.SetBool("doAttack", false);
    }
}