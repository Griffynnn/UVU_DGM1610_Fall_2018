﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickup : MonoBehaviour {
	
	public int AmountOfAmmo;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
		return;

		ScoreManager.AddPoints (AmountOfAmmo);

		Destroy (gameObject);
		
	}

}
