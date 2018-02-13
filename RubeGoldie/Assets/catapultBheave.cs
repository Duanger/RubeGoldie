using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapultBheave : MonoBehaviour
{

	public Rigidbody catapultedRigidbody;
	public GameObject cam4;
	public GameObject cam5;
	void Start () {
		cam5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "Dildo")
		{
			cam5.SetActive(true);
			cam4.SetActive(false);
			catapultedRigidbody.useGravity = true;
		}
	}
}
