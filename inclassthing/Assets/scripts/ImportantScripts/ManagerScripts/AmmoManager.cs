using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class AmmoManager : MonoBehaviour {

	 	public int Ammo = 5;
		public int ammoToAdd = 1;
		public GameObject Player;

 		public Text AmmoText;
	void Update(){

	}
	public void ChangeAmountAmmo (int amount){

		Ammo = Ammo + amount;
		AmmoText.text = " " + Ammo;
		print(Ammo);
	}



}



