using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Solve_Success : MonoBehaviour
{

    // count�� 1�� �Ǹ� �Ҹ��� �ѹ� ����

    public int count; // ���� ���߿� �޾ƿ´� 
    public AudioSource audioSource; // �Ҹ� 
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
