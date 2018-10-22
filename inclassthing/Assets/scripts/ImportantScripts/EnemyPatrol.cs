using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	//MovementVariables
	public float MoveSpeed;
	public bool MoveRight;



	//Wall Check
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

//Transform is a class type that takes into consideration the character position, rotation, etc. so that the character 
//when it hits a wall will turn around and walk the other way. 

	//Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;
	//This Edge Check code will check to see if enemy is at edge or not at edge, which is why its using a bool 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

//use if statements when you need to make a decision
// || is a logical operator, it means OR so its saying we've hit a wall OR we are at edge, change to opposite direction
// ! is false, so moveright and !moveright is move right true and moveright false
		//turn around at wall or edge code
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}

		if (MoveRight){
			transform.localScale = new Vector3(-5f,5f,5f);//this is scale transforms on x y and z so enemy doesnt shrink
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else {
			transform.localScale = new Vector3(5f,5f,5f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		}
	}

