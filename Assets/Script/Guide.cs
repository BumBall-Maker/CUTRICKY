using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// samplescene 이 시작되면 
// 3초 동안 가이드 ui를 띄웠다가 끈다 
public class Guide : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 가이드 ui를 3초 뒤에 꺼준다 
        Destroy(gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
