using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopBehave : MonoBehaviour
{

	public GameObject endText;

	void Start()
	{
		endText.SetActive(false);
	}
	void FixedUpdate () {
		if (transform.position.x < -135)
		{
			endText.SetActive(true);
		}
	}
}
