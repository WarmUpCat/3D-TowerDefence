using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    private Transform target;
    private int waypointIndex = 0; //move throu each index to get to END

   void Start()
    {
        // use the array created in Waypoint
        target = Waypoints.points[0]; //the first waypoint

    }

   void Update()
    {
        //get the direction vector to move to and move in the direction 

        
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);  


    }

}
