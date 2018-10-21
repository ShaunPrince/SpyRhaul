using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject nests;
    GameObject[] spawnPoints;
    private int nearestSpawnIndex;

    float closestDistance = Mathf.Infinity;
    // Use this for initialization
    private void Awake()
    {
        nearestSpawnIndex = 0;
        spawnPoints = GameObject.FindGameObjectsWithTag("Nests");
    }
    void Start(){

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Vector3 directionToTarget = transform.position - spawnPoints[i].transform.position;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistance)
                {

                    closestDistance = dSqrToTarget;
                    nearestSpawnIndex = i;
                }
        }

    }

        // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Instantiate(enemy, spawnPoints[nearestSpawnIndex].transform.position, spawnPoints[nearestSpawnIndex].transform.rotation);
        }

    }
}
