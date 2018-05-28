using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sblocco : MonoBehaviour
{

    public AudioSource sblocco;


    void Start()
    {

        sblocco = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            sblocco.Play();
        }

    }
}