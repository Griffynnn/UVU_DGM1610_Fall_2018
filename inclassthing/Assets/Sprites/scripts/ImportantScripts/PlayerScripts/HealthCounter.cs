using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour {

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
}
