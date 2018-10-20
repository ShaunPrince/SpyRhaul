using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour {

	public float speed = 10;

	private Rigidbody2D rb;

	//needs to be awake so comes before fire
	void Awake(){
		rb = gameObject.GetComponent<Rigidbody2D>();
		Debug.Log(rb.ToString());
	}

	//returns if fired
	public void Fire(){
		rb.AddForce(transform.up * speed);
	}
	

}
