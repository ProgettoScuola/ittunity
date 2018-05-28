using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campanella : MonoBehaviour
{

	public AudioSource SuonoCampanella;


	void Start()
	{

		SuonoCampanella = GetComponent<AudioSource>();

	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.U))
		{
			SuonoCampanella.Play();
		}

	}
}