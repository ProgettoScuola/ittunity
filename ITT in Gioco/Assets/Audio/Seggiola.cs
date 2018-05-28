using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seggiola : MonoBehaviour
{

	public AudioSource SuonoSeggiola;


	void Start()
	{

		SuonoSeggiola = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.G))
		{
			SuonoSeggiola.Play();
		}

	}
}