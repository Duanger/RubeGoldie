using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIText : MonoBehaviour
{

	public Rigidbody startRigid;
	public GameObject camera1;

	// Use this for initialization
	void Start ()
	{
    GameObject.FindGameObjectWithTag("MainCamera").SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startText()
	{
		camera1.SetActive(true);
		GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
		startRigid.useGravity = true;
		gameObject.SetActive(false);
	}

	public void endText()
	{
		SceneManager.LoadScene(0);
	}
}
