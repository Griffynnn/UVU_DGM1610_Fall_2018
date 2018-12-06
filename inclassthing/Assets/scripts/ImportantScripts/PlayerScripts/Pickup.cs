using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour {

	public GameObject GameManager;


	public enum PICKUP{
		Health,
		Ammo,
		Coin,
		Life
	}

	public PICKUP pickupType;

	public void Start(){
		GameManager = GameObject.Find("GameManager");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		switch(pickupType)
		{
			case PICKUP.Health:
				GameManager.GetComponent<HealthCounter>().AddHealth();
				print("you gained a life");
				break;
			case PICKUP.Ammo:
				GameManager.GetComponent<AmmoManager>().ChangeAmountAmmo(1);
				print("you got +1 ammo");
				break;
			case PICKUP.Coin:
				GameManager.GetComponent<ScoreManager>().AddPoints(5);
				print("you got some points!");
				break;
			case PICKUP.Life:
				GameManager.GetComponent<LivesToWin>().CollectLives();
				print("you have Lives");
				break;
		}
		Destroy(gameObject);
	}

}
