using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehave : MonoBehaviour
{
	public Transform sphere7;
	private Transform CameraTarget1;
	void Start ()
	{
		CameraTarget1 = GameObject.FindGameObjectWithTag("Brain").GetComponent<Transform>();
		if (gameObject.tag == "Camera1")
		{
			gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.tag == "MainCamera")
		{
			transform.position = new Vector3(39,-22,-227);
		}

		if (gameObject.tag == "Camera1")
		{
			transform.position = new Vector3(CameraTarget1.position.x +0.4f, CameraTarget1.position.y + 11.379f,
				CameraTarget1.position.z - 0.6f);
		}
	}
}
