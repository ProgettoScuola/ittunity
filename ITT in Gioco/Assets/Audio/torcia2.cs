using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torcia2 : MonoBehaviour {
	public AudioSource torciaspenta;

	void Start () {
		torciaspenta = GetComponent<AudioSource> ();
	}
	

	void Update () {
		if (Input.GetKeyUp(KeyCode.F))
		{
			torciaspenta.Play();
		}
	}
}
