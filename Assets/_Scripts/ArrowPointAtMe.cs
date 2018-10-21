using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPointAtMe : MonoBehaviour
{

    private GameObject player;
    private GameObject canvas;
    public GameObject arrowPrefab;
    public Color arrowColor;

    public bool knownToPlayer;

    private GameObject myArrow;

    private Vector3 arrowVect;

    void Awake()
    {
        player = GameObject.Find("SpyRhaul");
        canvas = GameObject.Find("Canvas");
        arrowVect = player.transform.position - this.transform.position;
        myArrow = GameObject.Instantiate<GameObject>(arrowPrefab, canvas.transform);
        myArrow.transform.localPosition = new Vector3(0, 0, 0);
        //UnityEditor.EditorApplication.isPaused = true;
        //knownToPlayer = false;
    }

	// Use this for initialization
	void Start ()
    {
        myArrow.GetComponentInChildren<SpriteRenderer>().color = arrowColor;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.knownToPlayer)
        {
            arrowVect = this.transform.position - player.transform.position;
            //Debug.Log(arrowVect);
            //Debug.Log(Vector3.Angle(Vector3.up, arrowVect));
            //myArrow.transform.position = player.transform.position;
            myArrow.transform.rotation = Quaternion.identity;
            myArrow.transform.Rotate(0, 0, Vector3.SignedAngle(Vector3.up, arrowVect, Vector3.forward));
            if (Vector3.Distance(this.transform.position, player.transform.position) < 4)
            {
                myArrow.gameObject.SetActive(false);
            }
            else
            {
                myArrow.gameObject.SetActive(true);
            }
            //Debug.Log(myArrow.transform.rotation);
        }
        else
        {
            myArrow.gameObject.SetActive(false);
        }

    }



     

}
