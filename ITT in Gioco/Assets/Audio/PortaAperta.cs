using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Provabella : MonoBehaviour
{

    public AudioSource bella;


    void Start()
    {

        bella = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            bella.Play();
        }

    }
}
