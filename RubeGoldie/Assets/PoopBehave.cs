using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopBehave : MonoBehaviour
{

	public GameObject endText;

	private Rigidbody selfRigid;
	private AudioSource poopy;
	

	void Start()
	{
		selfRigid = GetComponent<Rigidbody>();
		endText.SetActive(false);
		poopy = GetComponent<AudioSource>();
	}
	void FixedUpdate () {
		if (transform.position.x < -135)
		{
			endText.SetActive(true);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "cata" && selfRigid.useGravity == true)
		{
			poopy.PlayOneShot(poopy.clip);
		}
	}
}
