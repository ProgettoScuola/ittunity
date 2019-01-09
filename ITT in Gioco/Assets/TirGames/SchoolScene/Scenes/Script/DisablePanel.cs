using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisablePanel : MonoBehaviour {
    public GameObject Panel;
    public void showhidePanel()
    {
        Panel.gameObject.SetActive(false);
    }
}
