using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttivaTorcia : MonoBehaviour {
    public Canvas MobileStick;
    public GameObject Canvas2;
    public int batteria=0;
    public int batteria2=0;
    public int batteria3=0;
    public GameObject luce;
    public GameObject luce2;
    public GameObject Panel;
    public Text batterie;
    public int contabatterie;
    public GameObject quest2;
    public GameObject TextQuest;
    public GameObject ContaBatterie;
    public int quest = 0;
    public int incre = 0;
    public int checktorcia = 0;
    public GameObject PortaInfoChiusa, PortaInfoAperta;
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
        if (batteria2==1 && batteria3==1)
        {
            quests = 2;
        }
    }
    public void AggiungiBatteria2()
    {
        batteria2 = 1;
        contabatterie--;
        //contabatterie = 1;
        batterie.text = contabatterie.ToString();
        DisattivaTextBatterie();
        if (batteria == 1 && batteria3 == 1)
        {
            quests = 2;
        }
    }
    public void AggiungiBatteria3()
    {
        batteria3 = 1;
        contabatterie--;
        //contabatterie = 0;
        batterie.text = contabatterie.ToString();
        DisattivaTextBatterie();
        if (batteria == 1 && batteria2 == 1)
        {
            quests = 2;
        }
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
    public void Incremento()
    {
        incre = 1;
    }
    public void CheckTorcia()
    {
        checktorcia = 1;
    }
    public void ApriPortaInformatica()
    {
        if (info == 1 || quests == 2)
        {
            quests = 3;
            PortaInfoChiusa.SetActive(false);
            PortaInfoAperta.SetActive(true);
            //CheckQuest();
        }
    }

    public GameObject quest1, quest21, quest3, TextQuest2, QuestComplete;
    public int quests = 0;
    public int info = 0;
    //quest
    public void IncrementaQuests()
    {
        quests = 4;
        CheckQuest();
    }
    public void CheckQuest()
    {
        if (quests == 0 && incre == 1)
        {
        TextQuest2.SetActive(false);
        quest1.SetActive(false);
            if (checktorcia == 1)
            {
                quests = 1;
            }
        }
        else if (quests == 0)
        {
            TextQuest2.SetActive(true);
            quest1.SetActive(true);
            if (checktorcia == 1)
            {
                quests = 1;
            }
        }
        else if (quests == 1)
        {
            quest1.SetActive(false);
            TextQuest2.SetActive(true);
            quest21.SetActive(true);
        }
        else if (quests == 2)
        {
            quest21.SetActive(false);
            TextQuest2.SetActive(true);
            quest3.SetActive(true);
            ApriPortaInformatica();
        }
        else if (quests == 3)
        {
            quest1.SetActive(false);
            quest21.SetActive(false);
            info = 1;
            ApriPortaInformatica();
        }
        else if (batteria == 1 && batteria2 == 1 && batteria3 == 1 && incre == 1)
        {
            quest1.SetActive(false);
            quest21.SetActive(false);
            info = 1;
            ApriPortaInformatica();
        }
        else if (quests == 4)
        {
            quest1.SetActive(false);
            quest21.SetActive(false);
            quest3.SetActive(false);
            TextQuest2.SetActive(false);
            QuestComplete.SetActive(true);
            StartCoroutine(Disattiva());
        }
    }
    IEnumerator Disattiva()
    {
        yield return new WaitForSeconds(5);
        QuestComplete.SetActive(false);
    }
}
