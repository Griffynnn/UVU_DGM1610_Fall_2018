using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LivesToWin : MonoBehaviour {

	public GameObject WinScreen;
	public UnityEvent WinEvent;

//amount of lives to win objects

	public GameObject Life1;
	public GameObject Life2;
	public GameObject Life3;
	public GameObject Life4;
	public GameObject Life5;
	public GameObject Life6;
	public GameObject Life7;
	public GameObject Life8;
	public GameObject Life9;

	public static int Lives;
	

	// Use this for initialization
	public void CollectLives() {
		Lives = Lives + 1;

	switch(Lives){

		case 9: 
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(true);
			Life6.SetActive(true);
			Life7.SetActive(true);
			Life8.SetActive(true);
			Life9.SetActive(true);
			WinScreen.SetActive(true);
			break;
		case 8:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(true);
			Life6.SetActive(true);
			Life7.SetActive(true);
			Life8.SetActive(true);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 7:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(true);
			Life6.SetActive(true);
			Life7.SetActive(true);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 6:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(true);
			Life6.SetActive(true);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 5:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(true);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 4:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(true);
			Life5.SetActive(false);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 3:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(true);
			Life4.SetActive(false);
			Life5.SetActive(false);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 2:
			Life1.SetActive(true);
			Life2.SetActive(true);
			Life3.SetActive(false);
			Life4.SetActive(false);
			Life5.SetActive(false);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 1:
			Life1.SetActive(true);
			Life2.SetActive(false);
			Life3.SetActive(false);
			Life4.SetActive(false);
			Life5.SetActive(false);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
		case 0:
			Life1.SetActive(false);
			Life2.SetActive(false);
			Life3.SetActive(false);
			Life4.SetActive(false);
			Life5.SetActive(false);
			Life6.SetActive(false);
			Life7.SetActive(false);
			Life8.SetActive(false);
			Life9.SetActive(false);
			WinScreen.SetActive(false);
			break;
			}
		}
}

	


