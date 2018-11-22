using System.Collections;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {
	
	public int AmountOfAmmo;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
		return;

		AmmoManager.AddPoints (AmountOfAmmo);

		Destroy (gameObject);
		
	}

}
