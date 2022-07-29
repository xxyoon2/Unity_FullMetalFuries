using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject PlayerShield;
    public int Health = 100;

    void Start()
    {
        Health = 100;    
    }

    public void ProtectPlayer(bool canDefense)
    {
        Debug.Log("아 뭐하냐");
        if (canDefense)
        {
            Debug.Log("방패 일한다");
            PlayerShield.SetActive(true);
        }
        else
        {
            Debug.Log("방패 논다");
            PlayerShield.SetActive(false);
        }
    }
}
