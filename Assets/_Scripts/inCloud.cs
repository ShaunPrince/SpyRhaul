using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inCloud : MonoBehaviour {

    bool areInCloud;
    public GameObject spotlight;
	// Use this for initialization
    private void Awake()
    {
        areInCloud = false;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Cloud"){

            areInCloud = true;
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), spotlight.GetComponent<Collider2D>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        areInCloud = false;
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), spotlight.GetComponent<Collider2D>(), false);
    }
}
