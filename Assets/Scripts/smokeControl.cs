using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeControl : MonoBehaviour {

    public float engineRevs;
    public float hSliderValue1 = 50.0f;
    public float hSliderValue2 = 50.0f;
    ParticleSystem exhaust;


    void Start()
    {
        exhaust = GetComponent<ParticleSystem>();
    }


    void Update()
    {
        var emission = exhaust.emission;
        emission.rateOverTime = hSliderValue1;
        emission.rateOverDistance = hSliderValue2;
    }
    private void OnGUI()
    {
        //hSliderValue1 = GUI.HorizontalSlider(new Rect(25, 45, 100, 30), hSliderValue1, 5.0f, 200.0f);
        //hSliderValue2 = GUI.HorizontalSlider(new Rect(25, 70, 100, 30), hSliderValue2, 5.0f, 200.0f);
    }
}
