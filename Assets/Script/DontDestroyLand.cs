using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// destroy 하지마세요 : 시간 타이머 

public class DontDestroyLand : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
