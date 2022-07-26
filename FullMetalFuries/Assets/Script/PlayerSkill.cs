using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    private AudioSource _audioPlayer;
    private Animator _animator;

    void Awake()
    {
        _audioPlayer = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        Debug.Log("공격");
        // 1. 클릭을 누를 때마다 공격해야 함(클릭할 때마다 이 함수가 선언되기 때문에 공격하는 것만 구현하면 됨)
        // 2. 플레이어 상태 - 어떤 상태일때던간에 상관없이 공격 가능
        // 3. 적을 때릴 시엔 최대 3콤보까지 공격

        // 공격하는 애니메이션, 소리 출력
        _animator.SetTrigger(PlayerAnimID.Attack);
        //_audioPlayer.PlayOneShot(AttackClip);

        // 휘두르는 방향이 달라짐(이건 추후 구현)
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
    }

    public void Dodge()
    {
        Debug.Log("회피");
        _animator.SetTrigger(PlayerAnimID.Dodge);
    }
}