using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_script : MonoBehaviour
{

    public float time;
    public Text text_Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        text_Timer.text = Mathf.Round(time) + "s";
        
    }
}
