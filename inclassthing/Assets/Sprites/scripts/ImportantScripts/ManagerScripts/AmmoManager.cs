using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class AmmoManager : MonoBehaviour {

	 	public int Ammo = 0;
		public int maxAmmo = 5;
		public int ammoToAdd = 1;

 		public Text AmmoText;

	public void AddAmmo (){
		if (Ammo < 0)
			Ammo = 0;
		Ammo += ammoToAdd;
		AmmoText.text = " " + Ammo;
		print(Ammo);
	}

}



