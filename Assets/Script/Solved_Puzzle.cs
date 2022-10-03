using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// solve 된 퍼즐의 갯수에 따라서 => 이거는 나중에 상호작용 하면 count로 해서 쳐주기   
// 전구 그림이 나타난다


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
        // count 갯수에 따라서 전구 setactive 해주기
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
