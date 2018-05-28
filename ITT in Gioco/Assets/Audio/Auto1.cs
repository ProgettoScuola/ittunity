using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto1 : MonoBehaviour
{

	public AudioSource SuonoAuto1;


	void Start()
	{

		SuonoAuto1 = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.I))
		{
			SuonoAuto1.Play();
		}

	}
}