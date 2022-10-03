using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
// SceneController ���� ���� current time �������� 
// current time���� ������ �ð� UI�� ���� 

public class Timer_Score : MonoBehaviour
{
    // ������Ʈ�� Ŭ����. �׷��� �����´�. ���� �ȿ� ����ִ°� ������ؼ� 
    SceneController_main hello2;

    // finishtime �̶��, ������ �޾��� �׸��� �������ش� 
    private float finishTime;

    // UI�� ��Ÿ���ְ� �ؾ���
    public Text text_finishtime;

    // �ѹ��� �ϰ� ���ֱ�
    bool bull = false;
    

    // Start is called before the first frame update
    void Start()
    {
        // SceneController ��� ������Ʈ�� ã�Ƽ� ����Ʈ�ѷ���� ������Ʈ�� ����´� 
        hello2 = GameObject.Find("SceneController").GetComponent<SceneController_main>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bull == false && hello2 !=null && text_finishtime !=null)
        {


                // ����ؼ� successtime �̶�� �׸� �ȿ� hello2��� ��ũ��Ʈ���� finishingtime�� ������ͼ� �������ش� 
                finishTime = hello2.finishingtime;
                text_finishtime.text = "���� �ð� : " + finishTime.ToString() + " ��";
            

            bull = true;
        }
    }
}
