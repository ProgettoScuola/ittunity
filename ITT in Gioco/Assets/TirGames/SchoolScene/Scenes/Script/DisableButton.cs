using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour {
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
        ConnectPlay.gameObject.SetActive(true);
        ConnectedPlay.gameObject.SetActive(false);
    }
    public void showhideButtonFacebook()
    {
        ConnectFacebook.gameObject.SetActive(true);
        ConnectedFacebook.gameObject.SetActive(false);
    }
    public void showhideButtonSound()
    {
        soundon.gameObject.SetActive(true);
        soundoff.gameObject.SetActive(false);
    }
    public void showhideButtonEffect()
    {
        effecton.gameObject.SetActive(true);
        effectoff.gameObject.SetActive(false);
    }
}
