using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChiusuraPorta : MonoBehaviour {
    [SerializeField] private GameObject Oggetto;
    public GameObject PortaInfoChiusa, PortaInfoAperta;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ChiusuraPorta());
    }
    IEnumerator ChiusuraPorta()
    {
        yield return new WaitForSeconds(5);
        PortaInfoAperta.SetActive(false);
        PortaInfoAperta.SetActive(true);
    }
}
