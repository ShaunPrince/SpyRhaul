using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WIP WIP WIP WIP WIP WIP
public class EnemyColliderScript : MonoBehaviour {

    LayerMask EnemyLayerMask;
    Transform myTransform;

    void Awake()
    {
        EnemyLayerMask = (1 << 8) | (1 << 9);
        myTransform = transform;
    }
    // Use this for initialization
    void Start () {
        Physics2D.SetLayerCollisionMask(8, EnemyLayerMask);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
