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

    public void AddIntel()
    {
        ++intelCount;
    }

    public void DropIntel()
    {
        intelCount = 0;
    }
}
