using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rottura : MonoBehaviour
{

	public AudioSource SuonoRottura;


	void Start()
	{

		SuonoRottura = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Y))
		{
			SuonoRottura.Play();
		}

	}
}