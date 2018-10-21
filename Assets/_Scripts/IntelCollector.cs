using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelCollector : MonoBehaviour {

    private int _score;
	public int Score{
		get{
			return _score;
		}
		set{
			Debug.Log("Write to read-only IntelCollector.Score");
		}
	}

	private int _returnsLeft;
	public int ReturnsLeft{
		get{
			return _returnsLeft;
		}
		set {
			Debug.Log("Write to read-only IntelCollector.ReturnsLeft");
		}
	}

	public int TotalReturns = 3;

	void Start(){
		_returnsLeft = TotalReturns;
	}

	private void score(int intelCount){
		_score += intelCount * ReturnsLeft;
	}

	void OnTriggerEnter2D(Collider2D other){
		IntelManager intelSource = other.GetComponent<IntelManager>();
		if(intelSource != null){
			if(intelSource.intelCount > 0){
				score(intelSource.intelCount);
				//TODO: light new objectives
				_returnsLeft--;
				intelSource.DropIntel();
			}
		}
        other.GetComponent<PlayerHealth>().Health = 100;
        Debug.Log(other.GetComponent<PlayerHealth>().Health);
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < allEnemies.Length; i++){

            Destroy(allEnemies[i]);
        }
	}
}
