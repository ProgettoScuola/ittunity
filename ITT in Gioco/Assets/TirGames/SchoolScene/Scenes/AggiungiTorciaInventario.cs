﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggiungiTorciaInventario : MonoBehaviour {
    private int i;
    public GameObject TestoTorcia, Torcia, TorciaPlayer, Bottone, Luce, Luce2;
    public void AggiungiTorcia()
    {
        i = 1;
    }
    public void AggiungiInventario()
    {
        TestoTorcia.SetActive(true);
    }
    public void NascondiTorcia()
    {
            Torcia.SetActive(false);
            TorciaPlayer.SetActive(true);
            Bottone.SetActive(false);
            Luce.SetActive(false);
            Luce2.SetActive(false);
    }
}
