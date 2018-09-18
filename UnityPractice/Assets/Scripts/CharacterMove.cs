using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
    //Player Movement Variables
    //Public Uppercase, Private Lowercase
    public int MoveSpeed;
    public float JumpHeight;

    // Player grounded variables
    //Transform Effects Position, Roatation, And Scale
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
		
	}
// Use this for initialization
void Start()
{
    print("Hello World!");

}
void FixedUpdate()
{
    Grounded = Physics2d.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
}

// Update is called once per frame
void Update () {
		
	
//This Code Makes The Character Jump
if(input.GetKeyDown(KeyCode.Space)&& grounded){
        Jump();
    }
    


//This code makes the character move from side to side using the A&D keys
if(Input.GetKey (KeyCode.D)){
    GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
}
if(Input.GetKey (KeyCode.A)){
    GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
}

public void Jump(){
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rididbody2D>().velocity.x, JumpHeight);
    {

    }
}

