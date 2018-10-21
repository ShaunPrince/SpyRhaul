using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDetector : MonoBehaviour {

    inCloud amInCloud;
	// Use this for initialization
	void Start () {
        amInCloud = gameObject.GetComponent<inCloud>();
        amInCloud.Cloud = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Cloud"){

            Physics2D.IgnoreLayerCollision(9, 12);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Cloud"){

            Physics2D.IgnoreLayerCollision(9, 12, false);
        }
    }
}
