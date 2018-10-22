using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporale : MonoBehaviour
{

    public AudioSource temporale;


    void Start()
    {

        temporale = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            temporale.Play();
        }

    }
}