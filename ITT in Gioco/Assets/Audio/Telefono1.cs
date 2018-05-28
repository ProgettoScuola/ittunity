using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telefono1 : MonoBehaviour
{

	public AudioSource SuonoTelefono1;


	void Start()
	{

		SuonoTelefono1 = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.K))
		{
			SuonoTelefono1.Play();
		}

	}
}
