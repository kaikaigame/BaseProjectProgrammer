using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
	public int enemyHealth = 10;
	public int damageValue = 5;

	public Slider hpSlider;

	private NavMeshAgent _nav;
	private GameObject _target;

	private void Start()
	{
		_nav = GetComponent<NavMeshAgent>();
		_target = GameObject.FindGameObjectWithTag("Player");
	}
	
	private void Update()
	{
		_nav.SetDestination(_target.transform.position);
	}

	private void OnCollisionEnter(Collision col)
	{
		if (!col.gameObject.CompareTag("Bullet")) return;
		
		Destroy(col.gameObject);
		TakeDamage(damageValue);
	}

	private void TakeDamage(int damage)
	{
		enemyHealth -= damage;
		hpSlider.value = (float)enemyHealth / 10;

		if (enemyHealth > 0) return;
		
		enemyHealth = 0;
		ScoreManager.score += 10;

		Destroy(gameObject);
	}
}