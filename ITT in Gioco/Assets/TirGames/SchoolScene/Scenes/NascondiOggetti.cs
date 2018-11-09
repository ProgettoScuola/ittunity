using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascondiOggetti : MonoBehaviour {
    public GameObject Oggetto;
    public void Nascondi()
    {
        Oggetto.SetActive(false);
    }
}
