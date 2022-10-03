using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Solve_Success : MonoBehaviour
{

    // count가 1이 되면 소리를 한번 낸다

    public int count; // 값은 나중에 받아온다 
    public AudioSource audioSource; // 소리 
    private bool bull = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((count == 1) && (bull == true)) 
        {
            audioSource.Play();
            bull = false;
        }
        if ((count == 2) && (bull == false)) 
        {
            audioSource.Play();
            bull = true;
        }
        if ((count == 3) && (bull == true)) 
        {
            audioSource.Play();
            bull = false;
        }

    }
}
