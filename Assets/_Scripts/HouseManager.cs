using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour {

    public GameObject building;
    public GameObject housePrefab;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < building.transform.childCount; i++){

            Instantiate(housePrefab, building.transform.GetChild(i).transform.position, building.transform.GetChild(i).transform.rotation, building.transform.GetChild(i));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
