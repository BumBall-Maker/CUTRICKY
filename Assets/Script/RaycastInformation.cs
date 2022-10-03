using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class RaycastInformation : MonoBehaviour
{
    // raycast 값을 받아오기 위해서 ARRaycastManager를 지정해준다. PlaneManager도 마찬가시 
    public ARRaycastManager arRaycastManager;
    public ARPlaneManager arPlaneManager;

    // 정중앙의 값을 설정해주기 위함이다 
    public Vector2 centerPos = new Vector2(0.5f, 0.5f);

    // 광선을 쐈을 때 맞는 값을 저장해주기 위한 변수이다 
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 화면의 정중앙을 설정해주었다. 화면에 보이는 ViewPort의 0.5f, 0.5f 의 값. 화면의 중앙 1= 화면의 비율. 
        // 0~1의 범위값이다 
        Vector2 screenCenterPos = Camera.main.ViewportToScreenPoint(centerPos);

        // 만약 arRaycastManager에 있는 Raycast라는 레이져를 스크린의 중앙에서 쏘았을 때, 감지하는 타입인 PlanewithPolygon과 같은 것에 닿았다면 그 정보를 hits에 넣는다 
        if (arRaycastManager.Raycast(screenCenterPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            if (hits.Count > 0)
            {
                textUI.text = hits[0].trackable.ToString();
            }
        }

    }
}
