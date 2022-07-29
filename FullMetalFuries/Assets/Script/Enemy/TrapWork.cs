using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapWork : MonoBehaviour
{
    //public GameObject Thorn;
//private PlayerMovement _player;
    private Animator _animation;


    void Awake()
    {
        _animation = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _animation.SetTrigger("attack");
            other.GetComponent<PlayerMovement>().TakeDamage(10);
        }
    }
}
