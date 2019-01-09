using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {
    public GameObject quest1, quest2, TextQuest, QuestComplete;
    public int quest=0;
	
	public void AttivaQuest1 () {
        if (quest == 2)
        {
            CheckQuest();
            StartCoroutine(Disattiva());
        }
        TextQuest.SetActive(true);
        //TextQuest.text = TextQuest.ToString();
        quest1.SetActive(true);
        quest = 1;
    }
    public void AttivaQuest2()
    {
        //TextQuest.text = TextQuest.ToString();
        quest1.SetActive(false);
        quest2.SetActive(true);
        quest = 2;
    }
    public void CheckQuest()
    {
        if (quest == 2)
        {
            quest1.SetActive(false);
            TextQuest.SetActive(false);
            QuestComplete.SetActive(true);
            StartCoroutine(Disattiva());
        }
        else if (quest == 1)
        {
            quest1.SetActive(false);
            quest2.SetActive(true);
            quest = 2;
        }
        else
        {
            AttivaQuest1();
        }
    }
    IEnumerator Disattiva()
    {
        yield return new WaitForSeconds(5);
        QuestComplete.SetActive(false);
    }
}
