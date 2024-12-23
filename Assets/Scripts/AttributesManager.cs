using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health=100;
    public int attack=25;

    public int damageTimer = 5;

    public void TakeDamage(int amount)
    {
        health -= amount;

    }

    public void Heal(int amount)
    {
        health += amount;
    }
}
