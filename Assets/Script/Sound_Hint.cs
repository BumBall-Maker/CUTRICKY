using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Hint : MonoBehaviour
{
    
    public AudioSource audioSource; //오디오받기
    public GameObject hintGot; //힌트오브젝트받기
    private GameObject hintcontentGot; // 빈그릇

    private bool bull = false;

    // Start is called before the first frame update
    void Start()
    {
        // 힌트 오브젝트를받아서. 그 안에 스크립트에. hintcontent 를 받아오기
        
    }

    // Update is called once per frame
    void Update()
    {
        // hintcontent가 setactive == true라면 
        // 소리를 한번만 내주기
        // bool 로 해주기 
    }
}
