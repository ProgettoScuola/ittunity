using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject Pausemenu;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
}
