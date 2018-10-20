﻿using System.Collections;
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
	}
}
