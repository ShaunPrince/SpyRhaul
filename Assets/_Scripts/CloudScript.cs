using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(9, 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
