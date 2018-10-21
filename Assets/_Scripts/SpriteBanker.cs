using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteBanker : MonoBehaviour {

	private GameObject sprite; //the gameobject holding the sprite to bank
	private Rigidbody2D mover; //whose moment we bank off of
	//public float maxRotation = 23;
	public float bankCoefficient = 300;
	public float frameRate = 0.5f;
	public int queueLen = 5;
	private float lastFrame;
	private Queue<float> history;

	// Use this for initialization
	void Start () {
		//rotates first child that has a sprite on it
		sprite = gameObject.GetComponentInChildren<SpriteRenderer>().gameObject;
		mover = gameObject.GetComponent<Rigidbody2D>();	
		lastFrame = Time.time - frameRate*100;
		history = new Queue<float>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - lastFrame > 1/frameRate){
			Vector3 localVelocity = transform.InverseTransformDirection(mover.velocity);	
			float newRot = localVelocity.x * bankCoefficient;
			//don't rotate is were just at a bigger angle
			float rot = newRot;
			foreach(float f in history){
				if(Math.Abs(rot) < Math.Abs(f)){
					rot = f;
				}
			}
			//manage the queue
			history.Enqueue(newRot);
			if(history.Count > queueLen) history.Dequeue();
			//do the bank
			sprite.transform.localRotation = Quaternion.Euler(0, rot, 0); 
		}
	}
}
