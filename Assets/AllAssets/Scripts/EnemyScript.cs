using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void TakingDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
		{
            Die();
		}

    }
    void Die()
	{
        GetComponent<Collider2D>().;
        Destroy(Enemy);
	}
}
