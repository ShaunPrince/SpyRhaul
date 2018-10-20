using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Manager : MonoBehaviour {

	private Text textHealth;
	private Text textIntel;
	public IntelManager intelManager;
	public PlayerHealth healthManager;

	// Use this for initialization
	void Start () {
		textHealth = transform.Find("HealthCounter").GetComponentInChildren<Text>();	
		textIntel = transform.Find("IntelCounter").GetComponentInChildren<Text>();	
	}
	
	// Update is called once per frame
	void Update () {
		dispIntel(intelManager.intelCount);
		dispHealth(healthManager.Health);
	}

	void dispIntel(int intel){
		textIntel.text = "Intel: " + intel.ToString(); 
	}

	void dispHealth(int health){
		textHealth.text = health.ToString() + "%";
	}
}
