using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 8f;

	private Rigidbody _rigid;
	private Vector3 _moveDirection;
	private Animator _animator;
	private static readonly int s_IsRunning = Animator.StringToHash("IsRunning");

	private void Start()
	{
		_rigid = GetComponent<Rigidbody>();
		_animator = GetComponent<Animator>();
	}

	private void FixedUpdate()
	{
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		_moveDirection.Set(h, 0, v);
		_moveDirection = _moveDirection.normalized * (speed * Time.deltaTime);
		_rigid.MovePosition(transform.position + _moveDirection);
		transform.LookAt(transform.position + _moveDirection);

		bool running = h != 0f || v != 0f;
		_animator.SetBool(s_IsRunning, running);
	}
}