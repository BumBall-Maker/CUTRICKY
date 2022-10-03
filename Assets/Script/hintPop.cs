using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 만약 전구버튼을 누르면
// solve가 1이면 힌트1이
// solve가 2면 힌트 2가
// solve 3이면 힌트 3이 
// 3초동안 나타난다 

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
