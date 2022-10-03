using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestTouch : MonoBehaviour
{
    public Text touchcount;
    public Text xpos, ypos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        touch_tst();
    }
    void touch_tst()
    {
        if(Input.touchCount > 0)
        {
            Touch first_touch =  Input.GetTouch(0);
            touchcount.text = "" + Input.touchCount;
            xpos.text = ""+ first_touch.position.x;
            ypos.text = ""+ first_touch.position.y;
        }
    }
}
