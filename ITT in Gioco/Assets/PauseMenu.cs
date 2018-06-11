using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject Pausemenu;

    public void Pause()
    {
        Pausemenu.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Pausemenu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
}
