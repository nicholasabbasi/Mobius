using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour {
	public Text scoreText;
	public int maxScore = 50;
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "Puzzle: " + score;
	}



	public void AddPoint(){
		score++;
		if (score != maxScore)
			scoreText.text = "Score: " + score;
		else {
			scoreText.text = "You won!";
			SceneManager.LoadScene (1);
		}
	}
	// Update is called once per frame
	//void Update () {
		
	//}
}
