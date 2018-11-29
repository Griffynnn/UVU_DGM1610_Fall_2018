using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class AmmoManager : MonoBehaviour {

	 	public int Ammo = 5;
		public int ammoToAdd = 1;
		public GameObject Player;

 		public Text AmmoText;
	void Update(){
		if (Ammo <= 0){
			Ammo = 0;
			Player.GetComponent<PlayerShoot>().enabled = false;
		}
		if (Ammo >= 10){
			Ammo = 10;
		}
	}
	public void AddAmmo (){
	
		if (Ammo >= 10){
			Ammo = 10;
		}
		Ammo += ammoToAdd;
		AmmoText.text = " " + Ammo;
		print(Ammo);
	}



}



