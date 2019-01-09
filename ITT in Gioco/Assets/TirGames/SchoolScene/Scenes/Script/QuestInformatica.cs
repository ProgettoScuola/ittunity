using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestInformatica : MonoBehaviour {
    private int numogg=0;
    public GameObject Ram, HDD, displayverde, displayrosso, displaybianco, PortaInfoChiusa, PortaInfoAperta;

	void Start () {
		
	}
    public void ChiudiPorta ()
    {
        PortaInfoAperta.SetActive(false);
        PortaInfoAperta.SetActive(true);
    }
    public void Oggetto1 ()
    {
        numogg = 1;
        Ram.SetActive(false);
    }
    public void Oggetto2 ()
    {
        numogg = 2;
        HDD.SetActive(false);
    }
    public void Oggetto3 ()
    {
        numogg = 3;
    }
    public void Oggetto4 ()
    {
        numogg = 4;
    }
    public void CheckOggetto ()
    {
        if (numogg == 1)
        {
            displaybianco.SetActive(false);
            displayverde.SetActive(true);
            PortaInfoChiusa.SetActive(false);
            PortaInfoAperta.SetActive(true);
        }
        else
        {
            displaybianco.SetActive(false);
            displayrosso.SetActive(true);
            StartCoroutine(ResetDisplay());
        }
    }
    IEnumerator ResetDisplay()
    {
        yield return new WaitForSeconds(5);
        displayrosso.SetActive(false);
        displaybianco.SetActive(true);
    }
}
