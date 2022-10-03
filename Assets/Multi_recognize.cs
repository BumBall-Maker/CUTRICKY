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
    public GameObject[] multi_prefab; //�̹��� �ν� �� ����� ������ ��ü ����
    private void Awake()
    {
        trackingimg = this.GetComponent<ARTrackedImageManager>(); //�Ŵ��� ���ͼ�
        //�ش� �̺�Ʈ �߻��Ҷ� ȣ�� �Լ� ���... 
        //��ü�� ����� - �̸����� ���� + ����. keydata => collection
        spawnObj = new Dictionary<string, GameObject>(); //�� ��ü �����.

        //���� ���� ������ ��ü�� �� �ְھ�
        foreach (GameObject obj in multi_prefab)
        {
            
            GameObject temp = Instantiate(obj);
            temp.name = obj.name;
            temp.SetActive(false);
            spawnObj.Add(temp.name, temp); //�̸�, �� ��ü ��ü => ��ųʸ� Ÿ�Կ� �ִ´�.
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
        foreach (ARTrackedImage tr_img in args.added)   // ã�� �̹����� ������
        {   //��ü�� Ȱ��ȭ... ���߾ ��ǥ����
            UpdateObj(tr_img);
        }

        foreach (ARTrackedImage tr_img in args.added)  // ã�� �̹����� ���ŵǾ�����
        {   //��ü�� Ȱ��ȭ... ���߾ ��ǥ����
            UpdateObj(tr_img);
        }
/*
        foreach (ARTrackedImage tr_img in args.added)  // ã�� �̹����� ������
        {   //��ü�� ��Ȱ��ȭ
            db_2.text = "������";
            //if (tr_img.name == "img1") spawnObj["cube"].SetActive(false);
            //if (tr_img.name == "img2") spawnObj["sphere"].SetActive(false);
            spawnObj[tr_img.name].SetActive(false);
        }
*/
    }
    //��Ȳ�� ���߾ ��� => �̺�Ʈ ��Ȳ... ��ü�� �����ְ�, �� �����ְ�
    //�Ŵ��� = > �̺�Ʈ �߻��� ȣ���� �Լ� ���
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