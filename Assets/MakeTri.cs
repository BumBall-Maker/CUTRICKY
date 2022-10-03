using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class MakeTri : MonoBehaviour
{
    // Tri 바꿔칠 때 확인 사항
    // 1.Tripos의 collider 붙어있는지 확인 및 사이즈 조정
    // 2.Tripos의 위치 세밀 수정
    // 3.AR 카메라 및에 AR_Cam_Col 붙어 있는지 확인
    // 4.AR Cam col에 Box collider (Is trigger 체크), Rigidbody 추가
    // 5.오브젝트 생성 안될 시 Start() 함수의 Load 경로 확인
    Text d;
    Text a;
    Text b;
    Text c;
    GameObject triobj;
    GameObject tri;

    // Start is called before the first frame update
    void Start()
    {
      /*  // compile 용
        d = GameObject.Find("Canvas").transform.GetChild(3).GetComponent<Text>();
        a = GameObject.Find("Canvas").transform.GetChild(2).GetComponent<Text>();
        b = GameObject.Find("Canvas").transform.GetChild(1).GetComponent<Text>();
        c = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Text>();
*/
        triobj = Resources.Load<GameObject>("Triangle/Triobj");
    }

    // Update is called once per frame
    void Update()
    {
       // a.text = "aaa";
       // Trizonecheck.text = "None";
        //  xpos.text = "abc";
        
    }

    private void OnTriggerStay(Collider other)
    {
     
        if (other.gameObject.name.Contains("TriPos"))
        {
                print("col");
                RaycastHit hitinfos;
                Vector3 Raypos = this.transform.position;
                Raypos.z += 0.02f;

                //if( Physics.SphereCast(Raypos,10f,this.transform.forward,out hitinfos))
                if (Physics.Raycast(Raypos, this.transform.forward, out hitinfos) == true)
                {
                print(hitinfos.collider.gameObject.name);
                // 쏜 레이가 삼각형 구조물을 맞추면
                    if (hitinfos.collider.gameObject.name.Contains("Trimap"))
                {
                    // 터치하면
                    // if (Input.touchCount > 0)
                    // {
                    //   Touch touch = Input.GetTouch(0);
                    // 삼각형 생성
                    if (tri == null)
                        {
                             tri = Instantiate(triobj);
                             tri.transform.position = hitinfos.collider.gameObject.transform.GetChild(10).transform.position;// hitinfos.collider.gameObject.transform.position;
                        //tri.transform.rotation = this.transform.rotation;
                        //기존 구조물 파괴
                       // Destroy(hitinfos.collider.gameObject);

                        }
                        
                  // }
                }
                    

                }

            
                //GameObject temp = Instantiate(model_obj, temppose.position, temppose.rotation); // 생성 시키고 위치 세팅

            
            //  Vector3 tmp = 
            //  tmp.z += 1;
        }
           
        
    }
}
