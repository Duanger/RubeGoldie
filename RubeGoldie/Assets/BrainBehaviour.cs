using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainBehaviour : MonoBehaviour
{

	public AudioSource AudioEffect;
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (gameObject.tag == "Brain")
		{
			AudioEffect.PlayOneShot(AudioEffect.clip);
		}
		if (other.collider.tag == "Dildo" || other.collider.tag == "Ball")
		{
			AudioEffect.PlayOneShot(AudioEffect.clip);
		}
		

	}
}
