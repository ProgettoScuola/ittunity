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
        Debug.Log("Entrato in ChiusuraPorta");
        yield return new WaitForSeconds(5);
        PortaInfoAperta.SetActive(false);
        PortaInfoChiusa.SetActive(true);
        Oggetto.SetActive(false);
        Debug.Log("EseguitoChiusuraPorta");
    }
}
