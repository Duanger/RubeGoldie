using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnelBehave : MonoBehaviour
{
	public GameObject FunnelBottom;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		FunnelBottom.SetActive(false);
	}
}
