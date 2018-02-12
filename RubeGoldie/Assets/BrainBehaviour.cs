using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainBehaviour : MonoBehaviour
{

	public AudioSource brainSplooge;
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		brainSplooge.PlayOneShot(brainSplooge.clip);
	}
}
