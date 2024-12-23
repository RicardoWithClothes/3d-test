using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHit : MonoBehaviour
{
    public AttributesManager attributesManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            attributesManager.TakeDamage(25);
        }
        else if (other.gameObject.tag == "heal")
        {
            attributesManager.Heal(5); 
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            attributesManager.TakeDamage(5);
        }
        else if (other.gameObject.tag == "heal")
        {
            attributesManager.Heal(5);
        }
    }

}
