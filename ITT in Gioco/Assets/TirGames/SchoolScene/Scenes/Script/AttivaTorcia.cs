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
    public GameObject Panel, PanelFoglio;
    public Text batterie;
    public int contabatterie;
    public GameObject quest2;
    public GameObject TextQuest;
    public GameObject ContaBatterie;
    public int quest = 0;
    public int incre = 0;
    public int checktorcia = 0;
    public GameObject PortaInfoChiusa, PortaInfoAperta, ScrivaniaCollider, ScrivaniaNoCollider;
    public int quests;
    public int info;
    public GameObject quest1, quest21, quest3, quest4, TextQuest2, QuestComplete;
    private int OnTorcia = 1;
    void Start()
    {
        quests = 0;
        info = 0;
        contabatterie = 3;
        batterie.text = contabatterie.ToString();
    }
    public void AggiungiBatteria() //aggiunge batteria1 per torcia e decrementa contatore a schermo di batterie mancanti
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
    public void AggiungiBatteria2() //aggiunge batteria2 per torcia e decrementa contatore a schermo di batterie mancanti
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
    public void AggiungiBatteria3() //aggiunge batteria3 per torcia e decrementa contatore a schermo di batterie mancanti
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
    public void RimuoviQuest() //rimuove la seconda quest
    {
        if (contabatterie==0)
        {
            quest2.SetActive(false);
            TextQuest.SetActive(false);
        }
    }
    public void DisattivaTextBatterie() //disattiva il contatore delle batterie se sono state recuperate tutte e 3
    {
        if (batteria == 1 && batteria2 == 1 && batteria3 == 1)
            ContaBatterie.SetActive(false);
    }
    public void CheckBatterie() //fa il check delle batterie per poter accendere o no la torcia
    {
        if (batteria == 1 && batteria2 == 1 && batteria3 == 1 && OnTorcia == 1)
        {
            On();
        }
        else if (OnTorcia == 0)
        {
            Off();
        }
        else
            hidePanel();
    }
    public void On() //attiva luce torcia
    {
        luce.SetActive(true);
        luce2.SetActive(true);
        OnTorcia = 0;
        //MobileStick.gameObject.SetActive(true);
    }
    public void Off() //disattiva luce torcia
    {
        luce.SetActive(false);
        luce2.SetActive(false);
        OnTorcia = 1;
    }
    public void hidePanel() //nasconde un pannello
    {
        Panel.gameObject.SetActive(true);
        Canvas2.SetActive(false);
    }
    public void showPanel() //mostra un pannello
    {
        Panel.gameObject.SetActive(false);
        Canvas2.SetActive(true);
    }
    public void CheckTorcia() //incrementa variabile checktorcia se è stata presa la torcia senza avviare la quest (serve per successivo controllo)
    {
        checktorcia = 1;
    }

    //quest
    
    public void CheckQuest()
    {
        if (quests == 0) //attiva raccogli torcia
        {
            TextQuest2.SetActive(true);
            quest1.SetActive(true);
            if (checktorcia == 1)
            {
                quests = 1;
                quest1.SetActive(false);
                TextQuest2.SetActive(false);
            }
        }
        else if (quests == 1) //attiva raccogli batterie
        {
            TextQuest2.SetActive(true);
            quest21.SetActive(true);
        }
        else if (quests == 2) //attiva dirigiti al laboratorio ed apre porta laboratorio informatica
        {
            quest21.SetActive(false);
            TextQuest2.SetActive(true);
            quest3.SetActive(true);
            quests = 3;
            PortaInfoChiusa.SetActive(false);
            PortaInfoAperta.SetActive(true);
        }
        else if (batteria == 1 && batteria2 == 1 && batteria3 == 1 && quests == 2) //se sono state raccolte le 3 batterie e la torcia senza attivare nessuna quest vengono automaticamente disattivate e richiama metodo ApriPortaInformatica che controllerà se c'è la possibilità di aprire la porta del laboratorio di informatica
        {
            quest1.SetActive(false);
            quest21.SetActive(false);
            quests = 3;
            PortaInfoChiusa.SetActive(false);
            PortaInfoAperta.SetActive(true);
        }
        else if (quests == 3) //disattiva le prima due quest e modifica valore info (informatica) ad 1 e richiama metodo ApriPortaInformatica che controllerà se c'è la possibilità di aprire la porta del laboratorio di informatica
        {
            Debug.Log("entro in else if (quests == 3)");
            quest1.SetActive(false);
            quest21.SetActive(false);
            quest3.SetActive(false);
            IncrementaQuests();
            Debug.Log("Ho eseguito IncrementaQuests()");
        }
        else if (quests == 4)
        {
            quest4.SetActive(true);
        }
        else if (quests == 5) //disattiva tutte le quest e fa vedere la scritta hai completato tutti gli obiettivi, scompare dopo 5 secondi
        {
            ScrivaniaCollider.SetActive(false);
            ScrivaniaNoCollider.SetActive(true);
            ContaBatterie.SetActive(false);
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
    public void IncrementaQuests() //incrementa il valore quests a 4 dopo aver completato il quesito di informatica
    {
        Debug.Log("entro in IncrementaQuests()");
        quests = 4;
        CheckQuest();
        Debug.Log("Ho eseguito IncrementaQuests() e torno a CheckQuest()");
    }
}
