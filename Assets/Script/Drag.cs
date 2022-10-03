using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 targetpos;
    bool pressdown = false;

    // Start is called before the first frame update
    void Start()
    {
       targetpos = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            pressdown = true;
        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            pressdown = false;
        }
        if (pressdown == true)
        {
            Vector3 touch_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetpos.z);
            Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(touch_pos);
            this.transform.position = mouse_pos;
        }
    }
}
