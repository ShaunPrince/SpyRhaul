using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelManager : MonoBehaviour
{
    public int intelCount;
    public int initialKnownIntelCount;

    public List<GameObject> unfoundIntelsList;

    private int selectedIndex;

	// Use this for initialization
	void Start ()
    {
        GameObject[] unfoundIntels = GameObject.FindGameObjectsWithTag("Intel");
        unfoundIntelsList = new List<GameObject>(unfoundIntels);

        for(int i = 0; i < initialKnownIntelCount; ++i)
        {
            Debug.Log(unfoundIntelsList.Capacity);
            selectedIndex = Random.Range(0, unfoundIntelsList.Capacity);
            Debug.Log(unfoundIntelsList[selectedIndex]);
            unfoundIntelsList[selectedIndex].GetComponent<ArrowPointAtMe>().knownToPlayer = true;
            unfoundIntelsList.RemoveAt(selectedIndex);
            unfoundIntelsList.TrimExcess(); 
        }
        

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
            unfoundIntelsList.Remove(col.gameObject);
           // Debug.Log(col.gameObject.name);
            col.gameObject.GetComponentInParent<ArrowPointAtMe>().knownToPlayer = false;

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
