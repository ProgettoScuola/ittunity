using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stampante : MonoBehaviour
{

    public AudioSource stampante;


    void Start()
    {

        stampante = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            stampante.Play();
        }

    }
}