using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour {

	public UnityEvent healthEvent;
	public UnityEvent ammoEvent;
	public UnityEvent coinEvent;

	public enum PICKUP{
		Health,
		Ammo,
		Coin
	}

	public PICKUP pickupType;

	private void OnTriggerEnter2D(Collider2D other)
	{
		switch(pickupType)
		{
			case PICKUP.Health:
				healthEvent.Invoke();
				print("you gained a life");
				break;
			case PICKUP.Ammo:
				ammoEvent.Invoke();
				print("you got +1 ammo");
				break;
			case PICKUP.Coin:
				coinEvent.Invoke();
				print("you got some points!");
				break;
		}
	}

}
