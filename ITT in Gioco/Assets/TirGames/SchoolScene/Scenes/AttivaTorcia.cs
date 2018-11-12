﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttivaTorcia : MonoBehaviour {
    public Canvas MobileStick;
    public GameObject Canvas2;
    public int batteria;
    public int batteria2;
    public int batteria3;
    public GameObject luce;
    public GameObject luce2;
    public GameObject Panel;
    public Text batterie;
    public int contabatterie;
    public GameObject quest2;
    public GameObject TextQuest;
    public GameObject ContaBatterie;

    void Start()
    {
        contabatterie = 3;
        batterie.text = contabatterie.ToString();
    }
    public void AggiungiBatteria()
    {
        batteria = 1;
        contabatterie--;
        //contabatterie = 2;
        batterie.text = contabatterie.ToString();
        DisattivaTextBatterie();
    }
    public void AggiungiBatteria2()
    {
        batteria2 = 1;
        contabatterie--;
        //contabatterie = 1;
        batterie.text = contabatterie.ToString();
        DisattivaTextBatterie();
    }
    public void AggiungiBatteria3()
    {
        batteria3 = 1;
        contabatterie--;
        //contabatterie = 0;
        batterie.text = contabatterie.ToString();
        DisattivaTextBatterie();
    }
    public void RimuoviQuest()
    {
        if (contabatterie==0)
        {
            quest2.SetActive(false);
            TextQuest.SetActive(false);
        }
    }
    public void DisattivaTextBatterie()
    {
        if (batteria == 1 && batteria2 == 1 && batteria3 == 1)
            ContaBatterie.SetActive(false);
    }
    public void CheckBatterie()
    {
        if (batteria == 1 && batteria2 == 1 && batteria3 == 1)
        {
            On();
        }
        else
            hidePanel();
    }
    public void On()
    {
        luce.SetActive(true);
        luce2.SetActive(true);
        MobileStick.gameObject.SetActive(true);
    }
    public void Off()
    {
        luce.SetActive(false);
        luce2.SetActive(false);
    }
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
        Canvas2.SetActive(false);
    }
    public void showPanel()
    {
        Panel.gameObject.SetActive(false);
        Canvas2.SetActive(true);
    }
}
