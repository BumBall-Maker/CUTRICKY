using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController_start : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
        // ���� play ��ư�� ������
        // sample scene���� �Ѿ�� 
       
}