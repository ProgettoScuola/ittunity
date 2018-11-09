using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaTorcia : MonoBehaviour {

    public int batteria;
    public int batteria2;
    public int batteria3;
    public GameObject luce;
    public GameObject luce2;
    public GameObject Panel;

    public void AggiungiBatteria()
    {
        batteria = 1;
    }
    public void AggiungiBatteria2()
    {
        batteria2 = 1;
    }
    public void AggiungiBatteria3()
    {
        batteria3 = 1;
    }

    public void CheckBatterie()
    {
        if (batteria == 1 && batteria2 == 1 && batteria3 == 1)
        {
            luce.SetActive(true);
            luce2.SetActive(true);
        }
        else
        {
            ShowhidePanel();
        }
    }

    public void ShowhidePanel()
    {
            Panel.gameObject.SetActive(true);
    }
}
