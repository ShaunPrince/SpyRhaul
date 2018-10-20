using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WIP WIP WIP WIP WIP WIP
public class EnemyColliderScript : MonoBehaviour {

    LayerMask EnemyLayerMask;
    Transform myTransform;
    GameObject player;

    void Awake()
    {
        EnemyLayerMask = (1 << 8) | (1 << 9);
        myTransform = transform;
        player = GameObject.FindWithTag("Player");
    }
    // Use this for initialization
    void Start () {
        Physics2D.SetLayerCollisionMask(8, EnemyLayerMask);
        Physics2D.IgnoreCollision(this.GameObject.getComponent<CircleCollider2D>, player.GetComponent<BoxCollider2D>);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
