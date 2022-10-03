using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스크립트 나눠야 함
public class Test : MonoBehaviour
{
    Drag drg;
    GameObject waterfall;
    GameObject lamp;
    GameObject trimap;
    GameObject[] waterfallall = new GameObject[8];
    GameObject[] lam = new GameObject[40];
    GameObject[] tmap = new GameObject[10];
    GameObject tree;
    Collider thiscol;
    Material changeMat;
    Light triligt;
    // Start is called before the first frame update
    void Start()
    {
         tree = GameObject.Find("Map(Clone)").transform.GetChild(1).gameObject;
        waterfall = GameObject.FindGameObjectWithTag("Warterfall");
        trimap = GameObject.Find("Trimap");
        lamp = GameObject.Find("Lam");
        changeMat = Resources.Load<Material>("TriMat");
        thiscol = GetComponent<Collider>();
        drg = GetComponent<Drag>();
        for(int i = 0; i < 8; i++)
        {
            waterfallall[i] = waterfall.transform.GetChild(i).gameObject;
        }

        for(int i = 0; i < 40; i++)
        {
            lam[i] = lamp.transform.GetChild(i).gameObject;
        }
        if (this.gameObject.name.Contains("Triobj"))
        {
            for (int i = 0; i < 10; i++)
            {
                tmap[i] = trimap.transform.GetChild(i).gameObject;
            }
        }

        if (this.gameObject.name.Contains("Triobj"))
        {
            triligt = this.gameObject.GetComponent<Light>();
        } 
    }
    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator WarterfallDelay()
    {
        for (int i = 0; i < 8; i++)
        {
            //StopCoroutine(Delay());
            if (waterfallall[i] != null)
            {
                waterfallall[i].SetActive(true);
                yield return new WaitForSeconds(1f);
            }
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.name.Contains("SeedCol") && this.gameObject.name.Contains("Seed"))
        {

            SceneController_main.instance.seed = true;
            tree.SetActive(true);
            //조건 태양, 물
            drg.enabled = false;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            // 나무 자라기X`X
        }
        if (other.gameObject.name.Contains("ChaliceCol")&& this.gameObject.name.Contains("Chalice"))
        {
            SceneController_main.instance.chalice = true;
            drg.enabled = false;
            thiscol.enabled = false;
            this.transform.position = other.gameObject.transform.position;
            // Effect 물나오는 거 애니메이션
            StartCoroutine(WarterfallDelay());
            Destroy(other.gameObject);

        }
        if (other.gameObject.name.Contains("TriCol") && this.gameObject.name.Contains("Triobj"))
        {
            drg.enabled = false;
            thiscol.enabled = false;
            // 색상바꾸는 코드 상호작용 시 사용
            this.transform.position = other.gameObject.transform.position;
            Renderer[] ren = new Renderer[18];
        for (int i = 0; i <18; i++)
        {
            ren[i]= this.gameObject.transform.GetChild(i).GetComponent<Renderer>();
            ren[i].material = changeMat;
        }
        Renderer[] ren1 = new Renderer[40];
        for (int i = 0; i < 40; i++)
        {
            ren1[i] = lamp.gameObject.transform.GetChild(i).GetComponent<Renderer>();
            ren1[i].material = changeMat;
        }
            Renderer[] ren2 = new Renderer[10];
            for (int i = 0; i < 10; i++)
            {
                ren2[i] = trimap.gameObject.transform.GetChild(i).GetComponent<Renderer>();
                ren2[i].material = changeMat;
            }
            changeMat.EnableKeyword("_EMISSION");
            triligt.enabled = true;
            Destroy(other.gameObject);
            SceneController_main.instance.tri = true;
        }
    }
}
