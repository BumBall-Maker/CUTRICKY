using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_slider_script : MonoBehaviour
{

    Slider slTImer;
    float fSliderBarTime;

    // Start is called before the first frame update
    void Start()
    {
        slTImer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slTImer.value > 0.0f)
        {
            slTImer.value -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time is Zero.");
        }

    }

}
