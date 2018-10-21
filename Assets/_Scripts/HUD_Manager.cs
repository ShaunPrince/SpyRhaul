using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Manager : MonoBehaviour {

	//GUI ELEMENTS
	private Text textHealth;
	private Text textIntel;
	private GameObject imageIntel;
	private List<GameObject> pipsIntel;
	private Text textCooldown;
	private Text textReturns;
	private Text textScore;
	//OBJECTS REFERENCED TO COLLECT DATA
	public PlayerHealth healthManager;
	public IntelManager intelManager;
	public FireballSpawner cooldownManager;
	public IntelCollector returnManager;
	private IntelCollector scoreManager;
	//CONFIGURATIONS
	public int IconOffset = 48;

	// Use this for initialization
	void Start () {
		textHealth = transform.Find("HealthCounter").GetComponent<Text>();	
		textIntel = transform.Find("IntelCounter").GetComponent<Text>();	
		imageIntel = transform.Find("IntelIcon").gameObject;
		if(imageIntel != null){
			textIntel.gameObject.SetActive(false); //turn off the text if we don't need it
			imageIntel.gameObject.SetActive(false);
			pipsIntel = new List<GameObject>();
		}
		textCooldown = transform.Find("CooldownCounter").GetComponent<Text>();
		textReturns = transform.Find("Returns").Find("ReturnsCounter").GetComponent<Text>();
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
		if(imageIntel != null){
			while(pipsIntel.Count > intel){ //remove pips to go down to correct value
				GameObject removed = pipsIntel[pipsIntel.Count-1];
				pipsIntel.Remove(removed);
				GameObject.Destroy(removed);
			}
			while(pipsIntel.Count < intel){ //add pips to fill up to correct value
				Vector3 pos = imageIntel.transform.position;
				if(pipsIntel.Count > 0){
					Vector3 lastPos = pipsIntel[pipsIntel.Count - 1].transform.position;
					pos = new Vector3(lastPos.x + IconOffset, lastPos.y, lastPos.z);
				}
				GameObject added = GameObject.Instantiate(imageIntel, pos, imageIntel.transform.rotation, transform);
				added.SetActive(true);
				pipsIntel.Add(added);
			}
		}else{
			textIntel.text = "Intel: " + intel.ToString(); 
		}
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
