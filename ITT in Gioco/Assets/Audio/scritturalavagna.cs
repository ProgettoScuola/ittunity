using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scritturalavagna : MonoBehaviour {

	public AudioSource suonolavagna;
	private bool playing = false;

	// Use this for initialization
	void Start () {
		suonolavagna = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update ()
	{

		{
			{
				if (Input.GetKeyDown (KeyCode.E)) {
					suonolavagna.Play ();
					print ("funge");
				} 
				if (Input.GetKeyUp (KeyCode.A)) {
					suonolavagna.Stop ();
					print ("non funge");
				}
			}
		}

	}
}