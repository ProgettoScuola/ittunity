using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaChiusa : MonoBehaviour
{

	public AudioSource SuonoPortaC;


	void Start()
	{

		SuonoPortaC = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.H))
		{
			SuonoPortaC.Play();
		}

	}
}