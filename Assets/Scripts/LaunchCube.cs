using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
	public Rigidbody RB;
	public float Power;

	private void OnMouseDown()
	{
		RB.AddForce(new Vector3(0f, Power, 0f));
	}
}
