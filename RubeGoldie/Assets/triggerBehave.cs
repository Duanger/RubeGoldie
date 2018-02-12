using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBehave : MonoBehaviour
{

	public bool isEntered;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Brain")
		{
			isEntered = true;
		}
	}
}
