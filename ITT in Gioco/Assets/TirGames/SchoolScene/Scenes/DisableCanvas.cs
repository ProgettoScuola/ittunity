using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCanvas : MonoBehaviour {
    public GameObject Canvas;
    public void showhideCanvas()
    {
        Canvas.gameObject.SetActive(false);
    }
}
