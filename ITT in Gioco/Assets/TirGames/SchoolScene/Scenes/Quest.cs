using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {
    public GameObject quest1, quest2, TextQuest;
	
	public void AttivaQuest1 () {
        TextQuest.SetActive(true);
        //TextQuest.text = TextQuest.ToString();
        quest1.SetActive(true);
    }
    public void AttivaQuest2()
    {
        //TextQuest.text = TextQuest.ToString();
        quest1.SetActive(false);
        quest2.SetActive(true);
    }
}
