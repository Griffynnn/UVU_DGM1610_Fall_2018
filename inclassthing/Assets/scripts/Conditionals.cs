using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
	public string Weather;


	// Use this for initialization
	void Start () {
		if(Weather == "Raining")
		print("Weather is"+ Weather);
		else if(Weather == "Snowing")
			print("Weather is"+ Weather);
		else if(Weather == "Sunny")
			print("Weather is"+ Weather);
		else if(Weather == "Cloudy")
			print("Weather is"+ Weather);
		else {
			print("Weather is"+ Weather);
		}
	}
	//the code above means if weather is true, then print the following, you dont need braces if its one line
	//Else is the False version of if, if is saying if variable is true, else means if variable is false. 
	//you can use an if without an else. 
	//

	// Update is called once per frame
	void Update () {
		
	}
}
