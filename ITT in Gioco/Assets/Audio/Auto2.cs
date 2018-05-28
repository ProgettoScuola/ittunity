using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto2 : MonoBehaviour
{

	public AudioSource SuonoAuto2;


	void Start()
	{

		SuonoAuto2 = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.U))
		{
			SuonoAuto2.Play();
		}

	}
}
