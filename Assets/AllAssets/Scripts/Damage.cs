using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
	public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
	public int attackDamage;
	void Start()
    {
        
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            Attack();
		} 
    }

    void Attack()
	{
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); ;
	   foreach(Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyScript>().TakingDamage(attackDamage);
		}
	}

	void OnDrawGizmosSelected()
	{
		if (attackPoint == null)
			return;
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}
