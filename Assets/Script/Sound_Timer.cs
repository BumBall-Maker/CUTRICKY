using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ���� �ð��� 5�� ������ 
// Ÿ�̸� ȿ������ �ߵ��ȴ� 
public class Sound_Timer : MonoBehaviour
{
    // ����� �ޱ� 
    public AudioSource audioSource;

    // �ð� �ޱ�
    float time;
    float limitTIme = 180.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ð� ī��Ʈ�ϱ� 
        time = Time.deltaTime;

        if ((limitTIme - time) <= 5.0f )
        {
            print("" + (limitTIme - time));
            audioSource.Play();
        }
    }
}
