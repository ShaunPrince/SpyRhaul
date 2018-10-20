using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    private Rigidbody2D target; //Enemy Target
    public int enemySpeed = 3; //Enemy Speed
    //public  int rotationSpeed = 3; //Turning Speed

    private Rigidbody2D r;

    void Awake()
    {
        r = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>(); //Target Player
    }

    // Update is called once per frame
    void Update()
    {
        //Move towards Player
        r.transform.Translate(new Vector3(enemySpeed * Time.deltaTime, 0, 0));

        //Rotate to Find Player
        Vector3 dir = target.position - r.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        r.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



    }
}
