using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scattofotocamera : MonoBehaviour
{

    public AudioSource scatto;


    void Start()
    {

        scatto = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            scatto.Play();
        }

    }
}