using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour {

    // Use this for initialization
    private void Awake()
    {
        for (int i = 0; i < gameObject.GetComponents<Collider2D>().Length; i++)
        {
            gameObject.GetComponents<Collider2D>()[i].isTrigger = true;
        }
    }

    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
