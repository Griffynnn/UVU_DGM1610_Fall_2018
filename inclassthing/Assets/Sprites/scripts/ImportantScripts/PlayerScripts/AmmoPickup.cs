using System.Collections;
using UnityEngine;


public class AmmoPickup : MonoBehaviour {
	
	public int AmountOfAmmo;
	public AmmoManager ammoManager;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null){

		
		return;
	}
		ammoManager.ChangeAmountAmmo(1);

		Destroy (gameObject);
		
	}

}
