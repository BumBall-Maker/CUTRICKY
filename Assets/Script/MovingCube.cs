using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//   혼자 움직이는 큐브

// 만들어둔 waypoint 대로 움직인다 => 이 스크립트는 따로 짜 둠 

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
