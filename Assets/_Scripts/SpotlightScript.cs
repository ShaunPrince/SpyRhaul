using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightScript : MonoBehaviour {
    public float speed = .5f;
    void Start()
    {

    }

    void Update()
    {
        //PingPong between 0 and 1
        transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
