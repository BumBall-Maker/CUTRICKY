using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class RaycastInformation : MonoBehaviour
{
    // raycast ���� �޾ƿ��� ���ؼ� ARRaycastManager�� �������ش�. PlaneManager�� �������� 
    public ARRaycastManager arRaycastManager;
    public ARPlaneManager arPlaneManager;

    // ���߾��� ���� �������ֱ� �����̴� 
    public Vector2 centerPos = new Vector2(0.5f, 0.5f);

    // ������ ���� �� �´� ���� �������ֱ� ���� �����̴� 
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ȭ���� ���߾��� �������־���. ȭ�鿡 ���̴� ViewPort�� 0.5f, 0.5f �� ��. ȭ���� �߾� 1= ȭ���� ����. 
        // 0~1�� �������̴� 
        Vector2 screenCenterPos = Camera.main.ViewportToScreenPoint(centerPos);

        // ���� arRaycastManager�� �ִ� Raycast��� �������� ��ũ���� �߾ӿ��� ����� ��, �����ϴ� Ÿ���� PlanewithPolygon�� ���� �Ϳ� ��Ҵٸ� �� ������ hits�� �ִ´� 
        if (arRaycastManager.Raycast(screenCenterPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            if (hits.Count > 0)
            {
                textUI.text = hits[0].trackable.ToString();
            }
        }

    }
}
