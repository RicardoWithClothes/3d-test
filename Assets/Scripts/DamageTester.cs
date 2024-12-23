using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            playerAtm.TakeDamage(33);
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            playerAtm.Heal(10);
        }
    }
}
