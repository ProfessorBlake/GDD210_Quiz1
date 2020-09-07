using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public Rigidbody RB;
	public float Speed;

	private float move;

	private void Update()
	{
		if(Input.GetKey(KeyCode.Z))
		{
			move = 1f;
		}
		else
		{
			move = 0f;
		}
	}

	private void FixedUpdate()
	{
		RB.MovePosition(RB.position + new Vector3(0f, 0f, move * Speed));
	}
}
