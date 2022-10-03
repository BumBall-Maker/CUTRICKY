using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;


public class Multi_recognize : MonoBehaviour
{
    public GameObject recog; //debug
    Transform seedTf;
    ARTrackedImageManager trackingimg;

    //collection - array - list - stack - queue - dictionary
    // index        []      []      foreach(in)     key - value
    // +Generic     <>Type        =>  cf) c++ Template
    Dictionary<string, GameObject> spawnObj;
    public GameObject[] multi_prefab; //이미지 인식 시 사용할 프리팹 객체 정보
    private void Awake()
    {
        trackingimg = this.GetComponent<ARTrackedImageManager>(); //매니저 얻어와서
        //해당 이벤트 발생할때 호출 함수 등록... 
        //객체를 만들고 - 이름으로 접근 + 정보. keydata => collection
        spawnObj = new Dictionary<string, GameObject>(); //빈 객체 만든다.

        //내가 만든 프리팹 객체를 다 넣겠어
        foreach (GameObject obj in multi_prefab)
        {
            
            GameObject temp = Instantiate(obj);
            temp.name = obj.name;
            temp.SetActive(false);
            spawnObj.Add(temp.name, temp); //이름, 그 객체 자체 => 딕셔너리 타입에 넣는다.
        }

    }
    private void OnEnable()
    {
        trackingimg.trackedImagesChanged += OnTrackedImage;
    }

    private void OnDisable()
    {
        trackingimg.trackedImagesChanged += OnTrackedImage;
    }

    void OnTrackedImage(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage tr_img in args.added)   // 찾는 이미지가 있을때
        {   //객체를 활성화... 맞추어서 좌표변경
            UpdateObj(tr_img);
        }

        foreach (ARTrackedImage tr_img in args.added)  // 찾는 이미지가 갱신되었을때
        {   //객체를 활성화... 맞추어서 좌표변경
            UpdateObj(tr_img);
        }
/*
        foreach (ARTrackedImage tr_img in args.added)  // 찾는 이미지가 없을때
        {   //객체를 비활성화
            db_2.text = "삭제됨";
            //if (tr_img.name == "img1") spawnObj["cube"].SetActive(false);
            //if (tr_img.name == "img2") spawnObj["sphere"].SetActive(false);
            spawnObj[tr_img.name].SetActive(false);
        }
*/
    }
    //상황에 맞추어서 사용 => 이벤트 상황... 객체를 보여주고, 안 보여주고
    //매니저 = > 이벤트 발생시 호출할 함수 등록
    void TurnOff()
    {
        recog.SetActive(false);
    }
    // Start is called before the first frame update
    void UpdateObj(ARTrackedImage img)
    {
        recog.SetActive(true);
        Invoke("TurnOff", 3);
        string loadname = img.referenceImage.name;
        spawnObj[loadname].SetActive(true);
        if (RayCast_Mgr.Instance.make_Land == true)
        {
          spawnObj[loadname].transform.position = seedTf.transform.position;
        }
     //   }
       // else
      //  {
           // spawnObj[loadname].transform.position = ChilTf.position;
       // }
        //spawnObj[loadname].transform.position = img.transform.position;
        // spawnObj[loadname].transform.rotation = img.transform.rotation;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (RayCast_Mgr.Instance.make_Land == true)
        {
           seedTf.position = GameObject.Find("Map(Clone)").transform.GetChild(0).transform.position;
        }

    }
}