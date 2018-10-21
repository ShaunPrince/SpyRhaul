using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Manager : MonoBehaviour {

	private Text textHealth;
	private Text textIntel;
	private Text textCooldown;
	private Text textReturns;
	private Text textScore;
	public PlayerHealth healthManager;
	public IntelManager intelManager;
	public FireballSpawner cooldownManager;
	public IntelCollector returnManager;
	private IntelCollector scoreManager;

	// Use this for initialization
	void Start () {
		textHealth = transform.Find("HealthCounter").GetComponent<Text>();	
		textIntel = transform.Find("IntelCounter").GetComponent<Text>();	
		textCooldown = transform.Find("CooldownCounter").GetComponent<Text>();
		textReturns = transform.Find("ReturnsCounter").GetComponent<Text>();
		textScore = transform.Find("ScoreCounter").GetComponent<Text>();
		scoreManager = returnManager;
	}
	
	// Update is called once per frame
	void Update () {
		if(intelManager != null) dispIntel(intelManager.intelCount);
		if(healthManager != null) dispHealth(healthManager.Health);
		if(cooldownManager != null) dispCooldown(cooldownManager.getCooldown());
		if(returnManager != null) dispReturns(returnManager.ReturnsLeft, returnManager.TotalReturns);
		if(scoreManager != null) dispScore(scoreManager.Score);
	}

	void dispHealth(int health){
		textHealth.text = health.ToString() + "%";
	}

	void dispIntel(int intel){
		textIntel.text = "Intel: " + intel.ToString(); 
	}

	void dispCooldown(float cd){
		if(cd > 0){
			textCooldown.text = cd+"s";
		} else {
			textCooldown.text = "";
		}
	}

	void dispReturns(int returns, int outOf){
		textReturns.text = returns.ToString() + "/" + outOf.ToString();
	}

	void dispScore(int score){
		textScore.text = "Score: "+score.ToString();
	}
}
