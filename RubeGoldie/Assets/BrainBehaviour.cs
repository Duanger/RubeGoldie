using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainBehaviour : MonoBehaviour
{

	public AudioSource AudioEffect;

	public Rigidbody[] gravityObjects;
	public GameObject trigger;
	private triggerBehave trigBe;
	void Start ()
	{
		trigBe = trigger.GetComponent<triggerBehave>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (gameObject.tag == "Brain")
		{
			AudioEffect.PlayOneShot(AudioEffect.clip);
			if (trigBe.isEntered && other.collider.tag == "Ball")
			{
				GameObject.FindWithTag("Camera2").SetActive(true);
				GameObject.FindWithTag("Camera1").SetActive(false);
				for (int i = 0; i < gravityObjects.Length; i++)
				{
					gravityObjects[i].useGravity = true;
				}
			}
		}
		if (other.collider.tag == "Dildo" || other.collider.tag == "Ball")
		{
			trigger = null;
			AudioEffect.PlayOneShot(AudioEffect.clip);
		}
		

	}
}
