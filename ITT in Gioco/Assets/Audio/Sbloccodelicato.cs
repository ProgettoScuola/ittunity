using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sbloccodelicato : MonoBehaviour
{

    public AudioSource sbloccodelicato;


    void Start()
    {

        sbloccodelicato = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            sbloccodelicato.Play();
        }

    }
}