using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {
	public int num1;
	public int num2;
	private int Total;
	// Use this for initialization
	void Start () {
		Total = num1 + num2;
		print(Total);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
