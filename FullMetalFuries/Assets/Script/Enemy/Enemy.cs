using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 50;
    public float Speed = 1f;
    public GameObject Target;
    public Transform TargetTransform;
    void Start()
    {
        Health = 50;
        Speed = 0.5f;
        TargetTransform = Target.transform;
    }

    
}
