using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour {

	public float speed = 2;
	public float range = 3;

	private Rigidbody2D rb;

	//needs to be awake so comes before fire
	void Awake(){
		rb = gameObject.GetComponent<Rigidbody2D>();
	}

	//returns if fired
	public void Fire(){
		rb.velocity = transform.up * speed;
		Debug.Log("Firing");
		Invoke("die", range/speed);
	}

	//kills the object
	private void die(){
		GameObject.Destroy(gameObject);
	}
	

}
