using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    //acces from anywhere
    public static Transform[] points;

    void Awake()
    {
        //load all child of waypoints
        points = new Transform[transform.childCount];//create 14 arrays

        for (int i = 0; i < points.Length; i++)//llop through array and fill them
        {
            points[i] = transform.GetChild(i);

        }
    }


}