using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour {

    public GameObject enemy;
    public Transform[] spawnPoints;
    public Collider2D houseCollider;
    private int nearestSpawnIndex;

    float closestDistance = Mathf.Infinity;
    // Use this for initialization
    private void Awake()
    {
        nearestSpawnIndex = 0;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){

            for (int i = 0; i < spawnPoints.Length; i++){
                Vector3 directionToTarget = this.transform.position - spawnPoints[i].transform.position;
                float dSqrToTarget = directionToTarget.sqrMagnitude;
                if (dSqrToTarget < closestDistance){

                    closestDistance = dSqrToTarget;
                    nearestSpawnIndex = i;
                }
            }

            Instantiate(enemy, spawnPoints[nearestSpawnIndex].position, spawnPoints[nearestSpawnIndex].rotation);
        }

    }
}
