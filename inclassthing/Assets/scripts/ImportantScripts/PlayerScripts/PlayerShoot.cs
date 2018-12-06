using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	//This transform is uppercase because it's a class.
	public Transform FirePoint;
	public GameObject projectile;//means collecting a physical game object
	public AmmoManager ammomanager;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl)&&ammomanager.Ammo > 0)
		{
			Instantiate(projectile, FirePoint.position, FirePoint.rotation);
			print("Shooting");
			ammomanager.ChangeAmountAmmo(-1);
		}
	}
}
