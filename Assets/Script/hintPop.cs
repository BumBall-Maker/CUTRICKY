using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ���� ������ư�� ������
// solve�� 1�̸� ��Ʈ1��
// solve�� 2�� ��Ʈ 2��
// solve 3�̸� ��Ʈ 3�� 
// 3�ʵ��� ��Ÿ���� 

public class hintPop : MonoBehaviour
{

    public Image hint1;
    public Image hint2;
    public Image hint3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Delay()
    {
        if(hint1.GetComponent<Image>().enabled == true)
        {
            hint1.GetComponent<Image>().enabled = false;
        }
        if (hint2.GetComponent<Image>().enabled == true)
        {
            hint2.GetComponent<Image>().enabled = false;
        }
        if (hint3.GetComponent<Image>().enabled == true)
        {
            hint3.GetComponent<Image>().enabled = false;
        }
    }
    public void hintPopUp()
    {
        if (SceneController_main.instance.solve== 0)
        {
            hint2.GetComponent<Image>().enabled = true;
            Invoke("Delay", 2);
        }
        else if (SceneController_main.instance.solve == 1)
        {
            hint3.GetComponent<Image>().enabled = true;
            Invoke("Delay", 2);

        }
        else if (SceneController_main.instance.solve == 2)
        {
            hint1.GetComponent<Image>().enabled = true;
            Invoke("Delay", 2);

        }

        // hint1.GetComponent<Image>().enabled = true;
        // Destroy(hint1, 3.0f);

    }
}
