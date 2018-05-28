using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moto : MonoBehaviour
{

	public AudioSource SuonoMoto;


	void Start()
	{

		SuonoMoto = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.U))
		{
			SuonoMoto.Play();
		}

	}
}