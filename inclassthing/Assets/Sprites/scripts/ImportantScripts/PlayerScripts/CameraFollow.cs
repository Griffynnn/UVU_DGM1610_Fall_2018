﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject Player;

	public bool isFollowing;

	//Camera Position Offset
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		// Player = FindOBjectOfType<CharacterMove>();

		isFollowing = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(Player.transform.position.x + xOffset, Player.transform.position.y + yOffset, transform.position.z);

		}
		
	}
}
