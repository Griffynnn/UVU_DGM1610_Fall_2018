using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFelseHomeWork : MonoBehaviour {
	public string Season;

	// Use this for initialization
	void Start () {
		if(Season == "Winter")
			print("Season is"+ Season);
		else if(Season == "Summer")
			print("Season is"+ Season);
		else if(Season == "Spring")
			print("Season is"+ Season);
		else if(Season == "Fall")
			print("Season is"+ Season);
		else {
			print("Season is"+ Season);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
