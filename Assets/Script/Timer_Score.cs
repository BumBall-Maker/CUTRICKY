using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
// SceneController 에서 가진 current time 가져오기 
// current time에서 가져온 시간 UI로 띄우기 

public class Timer_Score : MonoBehaviour
{
    // 컴포넌트는 클래쓰. 그래서 가져온다. 여기 안에 들어있는거 써줘야해서 
    SceneController_main hello2;

    // finishtime 이라는, 변수를 받아줄 그릇을 정의해준다 
    private float finishTime;

    // UI에 나타나주게 해야지
    public Text text_finishtime;

    // 한번만 하게 해주기
    bool bull = false;
    

    // Start is called before the first frame update
    void Start()
    {
        // SceneController 라는 오브젝트를 찾아서 씬컨트롤러라는 컴포넌트를 갖고온다 
        hello2 = GameObject.Find("SceneController").GetComponent<SceneController_main>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bull == false && hello2 !=null && text_finishtime !=null)
        {


                // 계속해서 successtime 이라는 그릇 안에 hello2라는 스크립트에서 finishingtime을 가지고와서 대입해준다 
                finishTime = hello2.finishingtime;
                text_finishtime.text = "남은 시간 : " + finishTime.ToString() + " 초";
            

            bull = true;
        }
    }
}
