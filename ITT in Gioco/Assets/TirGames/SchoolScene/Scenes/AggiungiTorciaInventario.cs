using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AggiungiTorciaInventario : MonoBehaviour {
    public GameObject TestoTorcia, Torcia, TorciaPlayer, Bottone, Luce, Luce2;
    public GameObject findtorcia;
    public void AggiungiInventario()
    {
        TestoTorcia.SetActive(true);
        findtorcia.SetActive(true);
        StartCoroutine(Disattiva());
    }
    public void NascondiTorcia()
    {
            Torcia.SetActive(false);
            TorciaPlayer.SetActive(true);
            Bottone.SetActive(false);
            Luce.SetActive(false);
            Luce2.SetActive(false);
    }
    IEnumerator Disattiva()
    {
        yield return new WaitForSeconds(5);
        findtorcia.SetActive(false);
    }
}
