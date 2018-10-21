using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float backwardSpeed;
    public float turnSpeed;

    public float constantForwardSpeed;

    private float yAxisChange;
    private float xAxisChange;
    private Rigidbody2D body;

    // Use this for initialization
    void Start ()
    {
        body = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Get Inputs
        yAxisChange = Input.GetAxisRaw("Vertical");
        xAxisChange = Input.GetAxisRaw("Horizontal");

        //Debug.Log(yAxisChange);
        //Debug.log(xAxisChange);

        //move up constantly, slower if yAxisChange is negative
        body.velocity = ((this.transform.up * (constantForwardSpeed + (backwardSpeed * yAxisChange))));

        //Turn
        body.rotation += turnSpeed * -xAxisChange;
        
	}
}
