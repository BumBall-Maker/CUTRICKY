using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//   ȥ�� �����̴� ť��

// ������ waypoint ��� �����δ� => �� ��ũ��Ʈ�� ���� ¥ �� 

public class MovingCube : MonoBehaviour
{
    public float speed = 10;

    private Transform target;
    private int wavepointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        target = WayPoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.02f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavepointIndex >= WayPoints.points.Length - 1 )
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = WayPoints.points[wavepointIndex];

    }
}
