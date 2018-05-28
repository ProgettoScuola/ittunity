using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svegliaelettronica : MonoBehaviour
{

    public AudioSource sveglia;


    void Start()
    {

        sveglia = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            sveglia.Play();
        }

    }
}