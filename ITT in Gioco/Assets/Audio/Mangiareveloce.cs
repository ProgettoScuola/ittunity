using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mangiareveloce : MonoBehaviour
{

    public AudioSource Mangiare;


    void Start()
    {

        Mangiare = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            Mangiare.Play();
        }

    }
}