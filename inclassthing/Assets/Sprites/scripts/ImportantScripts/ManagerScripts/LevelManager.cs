using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour {

private ScoreManager ScoreManager;

public UnityEvent myEvent;

public GameObject CurrentCheckPoint;
public Rigidbody2D Player;
public GameObject Player2;

//Particles
public GameObject DeathParticle;
public GameObject RespawnParticle;

//Respawn Delay
public float RespawnDelay;

//Respawn Delay
public int PointPentaltyOnDeath;

//Store Gravity Value
private float GravityStore;

private bool respawnRunning;


	// Use this for initialization
	void Start () {
		//player = FindObjectOfType<Rigidbody2D> ();
		ScoreManager = GetComponent<ScoreManager>();
	}
	

	public void RespawnPlayer(){
		if(!respawnRunning){
			StartCoroutine("RespawnPlayerCo");
		}
		myEvent.Invoke();
		
	}

	public IEnumerator RespawnPlayerCo(){

		respawnRunning = true;

		//Genderate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//player.enabled = false;
		//Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-PointPentaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match Players Transform Position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show Player
		//Player.enabled = true;
		//Player2.SetActive(true);
		Player.GetComponent<Renderer> ().enabled = true;
		//Spawn Particle
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

		respawnRunning = false;

	}

}
