using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBox : MonoBehaviour {

	public GameObject HealthDrop;
	public GameObject AmmoDrop;
	public GameObject CoinDrop;

	public int[] LootCrate = new int[3];

	public string[] Loot;

	// Use this for initialization
	void Start () {

			LootCrate[0] = 0;
			LootCrate[1] = 1;
			LootCrate[2] = 2;
			LootCrate[3] = 3;

			print(LootCrate[2]);


			Loot = new string[3];

			Loot[0] = "Nothing";
			Loot[1] = "a Coin!";
			Loot[2] = "a life!";
			Loot[3] = "Ammo!";

			foreach(string item in Loot){
				print("You Got" + item);
		
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
