using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// solve �� ������ ������ ���� => �̰Ŵ� ���߿� ��ȣ�ۿ� �ϸ� count�� �ؼ� ���ֱ�   
// ���� �׸��� ��Ÿ����


public class Solved_Puzzle : MonoBehaviour
{

    int count;

    public Image FirstSolved;
    public Image SecondSolved;
    public Image ThirdSolved;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // count ������ ���� ���� setactive ���ֱ�
        if (count == 1)
        {
            FirstSolved.gameObject.SetActive(true);
        }
        else if (count == 2)
        {
            FirstSolved.gameObject.SetActive(true);
            SecondSolved.gameObject.SetActive(true);

        }
        else if (count == 3)
        {
            FirstSolved.gameObject.SetActive(true);
            SecondSolved.gameObject.SetActive(true);
            ThirdSolved.gameObject.SetActive(true);

        }


    }
}
