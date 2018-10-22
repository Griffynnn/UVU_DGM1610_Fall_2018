﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public Rigidbody2D PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () {
		if(PC.transform.localScale.x < 0)
		Speed = -Speed;
//localscale x is going left and right, 0 means if your not going one way your going the other. changing the speed of the object based on the player
//change the direction of the bullet depending on what direction the player is facing
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
		Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
		Destroy (other. gameObject);//the G is lowercase because its not a classtype, this gameObject is a variable so the g is lowercase
		ScoreManager.AddPoints (PointsForKill);
	}

	Instantiate(Projectile, transform.position, transform.rotation);
	Destroy (gameObject);
	
	}
}
