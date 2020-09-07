using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RampBall : MonoBehaviour
{
	public Rigidbody RB;
	public float Power;
	public Text PositionText;

	private float move;

	private void Update()
	{
		move = Input.GetAxis("Horizontal");
	}

	private void FixedUpdate()
	{
		RB.AddForce(new Vector3(move * Power, 0f, 0f));
	}

	private void OnTriggerEnter(Collider other)
	{
		PositionText.text = "CENTER";
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag != "Untagged")
			PositionText.text = collision.gameObject.tag;
	}
}