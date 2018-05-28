using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telefono2 : MonoBehaviour
{

	public AudioSource SuonoTelefono2;


	void Start()
	{

		SuonoTelefono2 = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.J))
		{
			SuonoTelefono2.Play();
		}

	}
}