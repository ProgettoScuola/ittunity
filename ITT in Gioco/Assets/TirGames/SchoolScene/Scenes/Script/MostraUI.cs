using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraUI : MonoBehaviour {
    [SerializeField] private GameObject Oggetto;

    private void OnTriggerEnter(Collider other)
    {
            Oggetto.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
            Oggetto.SetActive(false);
    }
}
