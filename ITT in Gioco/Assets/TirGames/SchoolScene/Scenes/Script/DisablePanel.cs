using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisablePanel : MonoBehaviour {
    public GameObject Panel, Panel2, Panel3;
    public void showhidePanel()
    {
        Panel.gameObject.SetActive(false);
    }
    public void showhidePanel2()
    {
        Panel2.gameObject.SetActive(false);
    }
    public void showhidePanel3()
    {
        Panel3.gameObject.SetActive(false);
    }
}
