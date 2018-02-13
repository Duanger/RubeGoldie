using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehave : MonoBehaviour
{
	public Transform sphere7;

	private triggerBehave trigger2;
	private Transform CameraTarget1;
	public Transform CameraTarget2;
	public GameObject camera3;
	public GameObject camera4;
	
	private Quaternion rotation = Quaternion.identity;
	void Start ()
	{
		CameraTarget1 = GameObject.FindGameObjectWithTag("Brain").GetComponent<Transform>();
		trigger2 = GameObject.FindGameObjectWithTag("Trigger2").GetComponent<triggerBehave>();
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

		if (gameObject.tag == "Camera4")
		{
			transform.position = new Vector3(CameraTarget2.position.x+33.7f,CameraTarget2.position.y+4.1f,CameraTarget2.position.z +1.5f);
		}
	}
}
