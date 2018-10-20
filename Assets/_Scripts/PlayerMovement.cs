using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed;
    public float backwardSpeed;
    public float turnSpeed;

    public float constantForwardSpeed;

    private Vector3 totalFrameMovement;
    private float totalRotation;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //zero out from last frame
        totalFrameMovement = Vector3.zero;
        totalRotation = 0;

        //check for / handle player input

        //Travel Forward faster
        if (Input.GetKey(KeyCode.W))
        {
            totalFrameMovement += (this.transform.up * forwardSpeed * Time.deltaTime);
        }

        //Slow down
        if(Input.GetKey(KeyCode.S))
        {
            totalFrameMovement += (-this.transform.up * backwardSpeed * Time.deltaTime);
        }

        //rotation turn right
        if(Input.GetKey(KeyCode.D))
        {
            totalRotation -= (turnSpeed * Time.deltaTime);
        }

        //rotation turn left
        if(Input.GetKey(KeyCode.A))
        {
            totalRotation += (turnSpeed * Time.deltaTime);
        }

        //constant forward movement
        totalFrameMovement += this.transform.up * constantForwardSpeed * Time.deltaTime;

        //Debug.Log(totalFrameMovement* 10000);


        this.transform.Translate(totalFrameMovement , Space.World);
        this.transform.Rotate(0, 0, totalRotation,Space.Self);
        Debug.Log(transform.up);

	}
}
