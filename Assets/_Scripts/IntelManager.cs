using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelManager : MonoBehaviour
{
    public int intelCount;

	// Use this for initialization
	void Start ()
    {
        intelCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Hit Collision unity copy paste");
    //}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "IntelColliderModel")
        {
            AddIntel();

            //change color so player knows this point has been taken already
            col.GetComponentInParent<Renderer>().material.color = Color.green;

            Destroy(col.GetComponentInParent<Rigidbody2D>());
            Destroy(col);

            //Debug.Log("Trigger Hit my version");
        }

    }

    //void OnTriggerEnter2d(Collision2D col)
    //{
    //    Debug.Log("HIT Trigger");
    //    if (col.gameObject.name == "IntelCollider")
    //    {
    //        this.AddIntel();
    //    }
    //}

    //void OnCollisionEnter2d(Collision2D col)
    //{
    //    Debug.Log("Collision Hit");
    //}


    public void AddIntel()
    {
        ++intelCount;
    }

    public void DropIntel()
    {
        intelCount = 0;
    }
}
