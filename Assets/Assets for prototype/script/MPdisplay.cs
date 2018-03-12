using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MPdisplay : MonoBehaviour {
	public Text MPText;
	//public int maxMP = 8; 
	//int MP;
	// Use this for initialization
	void Start () {
		//MP = 0;
		//MPText.text = "Score: " + MP;
		MPText.text = "MP: " + testcode.bulletNumber;   
	}


	/*
	public void AddPoint(){
		MP++;
		if (MP != maxMP)
			scoreText.text = "Score: " + MP;
		else {
			MPText.text = "reload!";
			SceneManager.LoadScene (1);
		}
	}
	*/
	// Update is called once per frame
	void Update () {
        MPText.text = "MP: " + testcode.bulletNumber;
    }
}

