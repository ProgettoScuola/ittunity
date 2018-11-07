using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaSliderDisplay : MonoBehaviour {
    public GameObject Slider;
    public GameObject Giroscopio;
	void Start () {
        Slider.SetActive(true);
        Giroscopio.SetActive(false);
	}
}
