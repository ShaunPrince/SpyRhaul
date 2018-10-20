using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    private Transform target; //Enemy Target
    public float enemySpeed = 1.5f; //Enemy Speed
    //public  int rotationSpeed = 3; //Turning Speed

    private Rigidbody2D r;

    void Awake()
    {
        r = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; //Target Player
    }

    // Update is called once per frame
    void Update()
    {
        //Move towards Player
        r.velocity = (this.transform.right * enemySpeed);

        //Rotate to Find Player
        Vector3 dir = target.position - r.transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        r.rotation = angle;



    }
}
