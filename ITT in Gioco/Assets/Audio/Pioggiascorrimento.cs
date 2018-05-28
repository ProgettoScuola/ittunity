using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pioggiascorrimento : MonoBehaviour
{

    public AudioSource pioggiascorrimento;


    void Start()
    {

        pioggiascorrimento = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            pioggiascorrimento.Play();
        }

    }
}