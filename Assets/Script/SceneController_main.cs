using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController_main : MonoBehaviour
{
    public static SceneController_main instance;
    public bool seed, chalice, tri = false;
    public GameObject seedUI, chaliceUI, triUI;
    private void Awake()
    {
        instance = this;
    }
    public float time; // 임의로 90초로 잡음 
    public int  solve = 0;    // 퍼즐 푼거 갯수 -> 다른데서 받아오기 
    bool gameend = false; // 처음에는 false로 해주고 
    public int finishingtime;

    // Start is called before the first frame update
    void Start()
    {
    }

    void End()
    {
        // 씬 바꾸기 
        SceneManager.LoadScene("Success");
    }

    // Update is called once per frame
    void Update()
    {
        if (chalice == true)
        {
            solve = 1;
            if (chaliceUI != null)
            {
                chaliceUI.SetActive(true);
            }
        }
        if (tri == true)
        {
            solve = 2;
            if (triUI != null)
            {
                triUI.SetActive(true);
            }

        }
        if (seed == true)
        {
            solve = 3;
            if (seedUI != null)
            {
                seedUI.SetActive(true);
            }
        }
        time -= Time.deltaTime;
        // 만약 90초 안에 토큰 3개 모으면 success로 넘어가고
        if ((time >= 0) && (solve ==3) && (gameend == false))
        {
            gameend = true;
            // 그 순간의 시간을 받는다 : current time 으로 
            finishingtime = (int)time;
            Invoke("End", 3);
            // 조건문 안에서 true로 바꿔주면 더이상 false가 아니기때문에 



        }

        // 그렇지 않다면 fail 로 넘어간다 
        else if((time <=  0) && (gameend == false))
        {
            gameend = true;
            SceneManager.LoadScene("Fail");
        }

    }
}