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
            //Debug.Log($"우린미친듯이 사랑하고 오브젝트 == {Coll}");
            Debug.Log($"EnemyColl = {EnemyColl}");
            if (EnemyColl.tag == "Enemy")
            {
                EnemyColl.GetComponent<EnemyStatus>().TakeDamage(PlayerStrength / 3);
            }
        }
        else
        {
            Debug.Log("우가");
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
        
        Collider2D[] EnemiesColl = Physics2D.OverlapBoxAll(SpecialAttackPosition.transform.position, new Vector2(SpecialAttackRange, SpecialAttackRange), 0f);

        foreach (Collider2D EnemyColl in EnemiesColl)
        {
            if (EnemyColl.tag == "Enemy")
            {
                Debug.Log($"{EnemyColl}");
                EnemyColl.GetComponent<EnemyStatus>().TakeDamage(Playertechnology - 3);
            }
        }

    }

    public void Dodge()
    {
        Debug.Log("회피");
        _animator.SetTrigger(PlayerAnimID.Dodge);
    }
}