using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow_Ball : MonoBehaviour
{
    public int health = 10;

    public GameObject deathEffect;

    public void TakenDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
