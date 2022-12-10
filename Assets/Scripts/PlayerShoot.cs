using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

	public GameObject bullet;
	public Transform muzzle;

	public float bulletSpeed = 1000f;
	private Animator _animator;
	private static readonly int s_Attack = Animator.StringToHash("Attack");

	private void Start()
	{
		_animator = GetComponent<Animator>();
	}

	// ReSharper disable Unity.PerformanceAnalysis
	private void Update()
	{
		// 左クリック押された時
		if (!Input.GetMouseButtonDown(0)) return;
		
		_animator.SetTrigger(s_Attack);

		// 弾丸の複製
		GameObject bullets = Instantiate(bullet) as GameObject;

		// 弾丸の位置を調整
		bullets.transform.position = muzzle.position;

		// Vector3 bulletDirection;
		// bulletDirection = gameObject.transform.forward * bulletSpeed;
		var bulletDirection = gameObject.transform.forward * bulletSpeed;

		// Rigidbodyに力を加えて発射
		bullets.GetComponent<Rigidbody>().AddForce(bulletDirection);
	}
}