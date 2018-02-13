using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBehave : MonoBehaviour
{

	public bool isEntered;
	public GameObject camera3;
	public GameObject camera4;
	void Start () {
		if (gameObject.tag == "Camera3")
		{
			gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "Trigger2" && isEntered)
		{
			camera4.SetActive(true);
			camera3.SetActive(false);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Brain")
		{
			isEntered = true;
		}

		if (gameObject.tag == "Trigger2")
		{
			if (other.tag == "Ball")
			{
				isEntered = true;
			}
		}
	}
}
