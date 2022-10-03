using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 만약 시간이 5초 남으면 
// 타이머 효과음이 발동된다 
public class Sound_Timer : MonoBehaviour
{
    // 오디오 받기 
    public AudioSource audioSource;

    // 시간 받기
    float time;
    float limitTIme = 180.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 시간 카운트하기 
        time = Time.deltaTime;

        if ((limitTIme - time) <= 5.0f )
        {
            print("" + (limitTIme - time));
            audioSource.Play();
        }
    }
}
