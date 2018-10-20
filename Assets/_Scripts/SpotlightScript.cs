using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightScript : MonoBehaviour {

    public float speed = 1.19f;
    public int distance = 10;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(transform.position.x, transform.position.y, 0);
        pointB = new Vector3(transform.position.x + distance, transform.position.y, 0);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
