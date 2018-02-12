using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIText : MonoBehaviour
{

	public Rigidbody startRigid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startText()
	{
		startRigid.useGravity = true;
		gameObject.SetActive(false);
	}

	public void endText()
	{
		SceneManager.LoadScene(0);
	}
}
