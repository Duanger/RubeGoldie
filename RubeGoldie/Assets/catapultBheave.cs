using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapultBheave : MonoBehaviour
{

	public Rigidbody catapultedRigidbody;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "Dildo")
		{
			catapultedRigidbody.useGravity = true;
		}
	}
}
