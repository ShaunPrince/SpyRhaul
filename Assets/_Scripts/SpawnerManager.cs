using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{

    public GameObject enemy;
   //public GameObject nests;
    GameObject[] spawnPoints;
    private int nearestSpawnIndex;
    //IDictionary<Transform, int> dict = new Dictionary<Transform, int>();
    float closestDistance = Mathf.Infinity;

    // Use this for initialization
    private void Awake()
    {
        nearestSpawnIndex = 0;
        spawnPoints = GameObject.FindGameObjectsWithTag("Nests");
    }
    void Start(){

        /*for (int j = 0; j < gameObject.transform.parent.childCount; j++){

            if(gameObject.transform.parent.GetChild(j).tag == "House"){

                dict.Add(gameObject.transform.parent.GetChild(j), 0); //Add House to key
                for (int i = 0; i < spawnPoints.Length; i++)
                {
                    Vector3 directionToTarget = gameObject.transform.parent.transform.GetChild(j).transform.position - spawnPoints[i].transform.position;
                    float dSqrToTarget = directionToTarget.sqrMagnitude;
                    if (dSqrToTarget < closestDistance)
                    {

                        closestDistance = dSqrToTarget;
                        nearestIndex = i;
                    }
                } 
            }

        } */

    }

        // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            //Vector3 directionToTarget = collision.transform.position - spawnPoints[i].transform.position;
            float dSqrToTarget = Vector3.Distance(collision.transform.position, spawnPoints[i].transform.position);
            //float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistance)
            {

                closestDistance = dSqrToTarget;
                nearestSpawnIndex = i;

            }
        }

        if (collision.tag == "Player")
        {
            Debug.Log("There is a PLAYER");
            Instantiate(enemy, spawnPoints[nearestSpawnIndex].transform.position, spawnPoints[nearestSpawnIndex].transform.rotation);
        }

    }
}
