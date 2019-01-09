using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestInformatica : MonoBehaviour {
    private int numogg;
    public GameObject Ram, HDD, displayverde, displayrosso, displaybianco, portainfo;

	void Start () {
		
	}
    public void Oggetto1 ()
    {
        numogg = 1;
        Ram.SetActive(false);
    }
    public void Oggetto2 ()
    {
        numogg = 2;
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
            gameObject.GetComponent<AttivaTorcia>;
            AttivaTorcia.PortaInfoChiusa.SetActive(false);

        }
    }
}
