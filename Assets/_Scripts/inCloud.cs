using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inCloud : MonoBehaviour {

    bool areInCloud;
    public GameObject spotlight;
	//TURN THIS INTO THAT GET/SET SHIT and THEN MAKE SEPARATE SCRIPT USING GET/SET SHIT
    private void Awake()
    {
        areInCloud = false;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.tag == "Cloud"){
            Debug.Log("YOU HAVE ENTERED THE CLOUD");
            areInCloud = true;
            Physics2D.IgnoreLayerCollision(9, 11, true);
        }
    }
}
