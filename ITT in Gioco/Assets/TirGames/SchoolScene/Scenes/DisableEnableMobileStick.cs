using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableMobileStick : MonoBehaviour {
    public GameObject MobileStick;
    public void hideStick()
    {
        MobileStick.gameObject.SetActive(false);
    }
    public void showStick()
    {
        MobileStick.gameObject.SetActive(true);
    }
}
