using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class MakeTri : MonoBehaviour
{
    // Tri �ٲ�ĥ �� Ȯ�� ����
    // 1.Tripos�� collider �پ��ִ��� Ȯ�� �� ������ ����
    // 2.Tripos�� ��ġ ���� ����
    // 3.AR ī�޶� �׿� AR_Cam_Col �پ� �ִ��� Ȯ��
    // 4.AR Cam col�� Box collider (Is trigger üũ), Rigidbody �߰�
    // 5.������Ʈ ���� �ȵ� �� Start() �Լ��� Load ��� Ȯ��
    Text d;
    Text a;
    Text b;
    Text c;
    GameObject triobj;
    GameObject tri;

    // Start is called before the first frame update
    void Start()
    {
      /*  // compile ��
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
                // �� ���̰� �ﰢ�� �������� ���߸�
                    if (hitinfos.collider.gameObject.name.Contains("Trimap"))
                {
                    // ��ġ�ϸ�
                    // if (Input.touchCount > 0)
                    // {
                    //   Touch touch = Input.GetTouch(0);
                    // �ﰢ�� ����
                    if (tri == null)
                        {
                             tri = Instantiate(triobj);
                             tri.transform.position = hitinfos.collider.gameObject.transform.GetChild(10).transform.position;// hitinfos.collider.gameObject.transform.position;
                        //tri.transform.rotation = this.transform.rotation;
                        //���� ������ �ı�
                       // Destroy(hitinfos.collider.gameObject);

                        }
                        
                  // }
                }
                    

                }

            
                //GameObject temp = Instantiate(model_obj, temppose.position, temppose.rotation); // ���� ��Ű�� ��ġ ����

            
            //  Vector3 tmp = 
            //  tmp.z += 1;
        }
           
        
    }
}
