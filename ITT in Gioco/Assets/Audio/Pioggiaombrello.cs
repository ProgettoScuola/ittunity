using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pioggiaombrello : MonoBehaviour
{

    public AudioSource pioggiaombrello;


    void Start()
    {

        pioggiaombrello = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            pioggiaombrello.Play();
        }

    }
}