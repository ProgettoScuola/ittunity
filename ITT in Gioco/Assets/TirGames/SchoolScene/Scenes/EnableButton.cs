using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableButton : MonoBehaviour {
    public Button ConnectPlay;
    public Button ConnectedPlay;
    public Button ConnectFacebook;
    public Button ConnectedFacebook;
    public Button soundon;
    public Button soundoff;
    public Button effecton;
    public Button effectoff;
    public void showhideButtonPlay()
    {
        ConnectPlay.gameObject.SetActive(false);
        ConnectedPlay.gameObject.SetActive(true);
    }
    public void showhideButtonFacebook()
    {
        ConnectFacebook.gameObject.SetActive(false);
        ConnectedFacebook.gameObject.SetActive(true);
    }
    public void showhideButtonSound()
    {
        soundon.gameObject.SetActive(false);
        soundoff.gameObject.SetActive(true);
    }
    public void showhideButtonEffect()
    {
        effecton.gameObject.SetActive(false);
        effectoff.gameObject.SetActive(true);
    }
}
