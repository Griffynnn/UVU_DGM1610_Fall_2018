using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBox : MonoBehaviour {

	public GameObject HealthDrop;
	public GameObject AmmoDrop;
	public GameObject CoinDrop;

	public GameObject[] LootCrate = new GameObject[3];

	public string[] Loot;

	// Use this for initialization
	void Start () {

		
			foreach(string item in Loot){
				print("You Got" + item);
		
		}
	}
	
	public void DropLoot(){
		Instantiate(LootCrate[Random.Range(0,2)],transform.position,Quaternion.identity);
	}
}
