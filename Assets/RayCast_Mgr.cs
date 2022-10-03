using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class RayCast_Mgr : MonoBehaviour
{
    public static RayCast_Mgr Instance;

    private void Awake() 
    {
        Instance = this;
    }
    ARRaycastManager arManager;
    public Text state1, state2;
    public GameObject model_obj;
    GameObject map; //테스트용 마커 //기준선(보고있는)
    GameObject makeObj; // 프리펩으로 만든 객체의 정보를 받음
    GameObject mapObj;
    public Camera cam;
    public bool make_Land = false;
    //초기화를 안했으니까 지금은 null
    //정보를 받으면 null은 아닐듯
    // Start is called before the first frame update
    void Start()
    {
        arManager = this.GetComponent<ARRaycastManager>();
        map = Resources.Load<GameObject>("Map");
        //map.SetActive(false);
        //detect_land();
    }

    // Update is called once per frame
    void Update()
    {
        land_make();
        //touch_tst();
    }

    void land_make()
    {
        if (make_Land == false)
        {
            if (Input.touchCount > 0)
            {
                Touch first_touch = Input.GetTouch(0);
                List<ARRaycastHit> hitinfos = new List<ARRaycastHit>();
                if (arManager.Raycast(first_touch.position, hitinfos, TrackableType.Planes) == true)
                {
                    Pose temppose = hitinfos[0].pose;
                    temppose.position.y += 0.7f;
                    //temppose.rotation.y += 180f;

                    //GameObject temp = Instantiate(model_obj, temppose.position, temppose.rotation); // 생성 시키고 위치 세팅
                    if (mapObj == null)
                    {
                        mapObj = Instantiate(map, temppose.position, temppose.rotation);
                        make_Land = true;
                    }
                }
            }
        }
    }





}
