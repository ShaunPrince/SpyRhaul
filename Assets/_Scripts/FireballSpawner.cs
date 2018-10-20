using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour {

	private Transform spawnPoint;
	public GameObject prototype;
	public float cooldownTime = 2;
	private float lastFire; //time of last fire

	// Use this for initialization
	void Start () {
		spawnPoint = transform.Find("FireryMaw");
	}
	
	// Update is called once per frame
	void Update () {
		if(getCooldown() <= 0 && Input.GetButtonDown("fireball")){
			GameObject ball = GameObject.Instantiate(prototype, spawnPoint.position, spawnPoint.rotation);
			FireballMovement fbMove = ball.GetComponent<FireballMovement>();
			fbMove.Fire();
			lastFire = Time.time;
		}
	}

	//if off cooldown, returns a negative number
	//if cooling down, returns how log is left
	public float getCooldown(){
		return  lastFire + cooldownTime - Time.time;
	}
}
