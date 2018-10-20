﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    Transform target; //Enemy Target
    public int enemySpeed = 3; //Enemy Speed
    //public  int rotationSpeed = 3; //Turning Speed

    Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; //Target Player
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate to Find Player
        Vector3 dir = target.position - myTransform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        myTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Move towards Player
        myTransform.Translate(new Vector3(enemySpeed * Time.deltaTime, 0, 0));

    }
}