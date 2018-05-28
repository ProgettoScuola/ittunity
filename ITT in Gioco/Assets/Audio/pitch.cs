using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pitch : MonoBehaviour {

	public AudioSource coinSound;
	public int startingPitch = 1;
	public int timeToDecrease = 2;
	private bool playing = false;

	// Use this for initialization
	void Start () {
		coinSound = GetComponent<AudioSource>();
		coinSound.pitch = startingPitch;
	}

	// Update is called once per frame
	void Update ()
	{

		{
			{
					if (Input.GetKeyDown (KeyCode.A)) {
						coinSound.Play ();
					} 
				if (Input.GetKeyUp (KeyCode.A)) {
					coinSound.Stop ();
				}
			if (coinSound.pitch < 10)
				coinSound.pitch += 0.0002f;
		}
	}

}
}