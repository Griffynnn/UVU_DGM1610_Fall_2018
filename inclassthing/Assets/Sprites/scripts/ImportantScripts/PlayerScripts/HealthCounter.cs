using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthCounter : MonoBehaviour {

	public GameObject DeathScreen;
	public UnityEvent DeathEvent;
	public GameObject Health1;
	public GameObject Health2;
	public GameObject Health3;

 	public static int Health;

	// Use this for initialization
	void Start () {
		Health = 3;
	}
	
	//Update is called once per frame
	void Update () {
		if (Health > 3){
			Health = 3;
		}
		
	}

	public void SubtractHealth()
	{
		Health--; //health = health - 1

		switch(Health)
		{
			case 3:
				Health1.SetActive(true);
				Health2.SetActive(true);
				Health3.SetActive(true);
				break;
			case 2:
				Health1.SetActive(true);
				Health2.SetActive(true);
				Health3.SetActive(false);
				break;
			case 1:
				Health1.SetActive(true);
				Health2.SetActive(false);
				Health3.SetActive(false);
				break;
			case 0:
				Health1.SetActive(false);
				Health2.SetActive(false);
				Health3.SetActive(false);
				DeathScreen.SetActive(true);
				break;
		}
	}		
	public void AddHealth(){
		Health = Health + 1;

		switch(Health){

			case 3:
				Health1.SetActive(true);
				Health2.SetActive(true);
				Health3.SetActive(true);
				break;

			case 2:
				Health1.SetActive(true);
				Health2.SetActive(true);
				Health3.SetActive(false);
				break;
			case 1:
				Health1.SetActive(true);
				Health2.SetActive(false);
				Health3.SetActive(false);
				break;
			case 0:
				Health1.SetActive(false);
				Health2.SetActive(false);
				Health3.SetActive(false);
				break;
		}
	}
}
