using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vento : MonoBehaviour
{

	public AudioSource SuonoVento;


	void Start()
	{

		SuonoVento = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.L))
		{
			SuonoVento.Play();
		}

	}
}