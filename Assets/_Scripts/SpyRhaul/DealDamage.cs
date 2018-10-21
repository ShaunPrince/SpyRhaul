using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DealDamage : MonoBehaviour {
    // Use this for initialization
    public int enemyDamage = 30;
    PlayerHealth health;

    private void Awake()
    {
        health = gameObject.GetComponent<PlayerHealth>();
        health.Health = 100;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            health.Health -= enemyDamage;
            Debug.Log(health.Health);
            Destroy(collision.gameObject);
            if(health.Health <= 0){
                //Death Screen
                SceneManager.LoadScene(sceneName: "MainMenu");

            }
        }
    }


}
