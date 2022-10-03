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
    public float time; // ���Ƿ� 90�ʷ� ���� 
    public int  solve = 0;    // ���� Ǭ�� ���� -> �ٸ����� �޾ƿ��� 
    bool gameend = false; // ó������ false�� ���ְ� 
    public int finishingtime;

    // Start is called before the first frame update
    void Start()
    {
    }

    void End()
    {
        // �� �ٲٱ� 
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
        // ���� 90�� �ȿ� ��ū 3�� ������ success�� �Ѿ��
        if ((time >= 0) && (solve ==3) && (gameend == false))
        {
            gameend = true;
            // �� ������ �ð��� �޴´� : current time ���� 
            finishingtime = (int)time;
            Invoke("End", 3);
            // ���ǹ� �ȿ��� true�� �ٲ��ָ� ���̻� false�� �ƴϱ⶧���� 



        }

        // �׷��� �ʴٸ� fail �� �Ѿ�� 
        else if((time <=  0) && (gameend == false))
        {
            gameend = true;
            SceneManager.LoadScene("Fail");
        }

    }
}