using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pioggiarealistico : MonoBehaviour
{

    public AudioSource pioggiarealistico;


    void Start()
    {

        pioggiarealistico = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            pioggiarealistico.Play();
        }

    }
}