using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

public LevelManager LevelManager;
//the above code is a class

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	// the above code is calling the levelmanager to do what its supposed to


	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "PC"){
			LevelManager.RespawnPlayer();
		}
	}
}
