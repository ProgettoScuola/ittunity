using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torcia : MonoBehaviour {

	public AudioSource torcia;

	void Start () {
		torcia = GetComponent<AudioSource> ();
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			torcia.Play();
		}
	} 
}