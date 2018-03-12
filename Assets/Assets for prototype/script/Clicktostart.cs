using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicktostart : MonoBehaviour {
	public void RestartGame() {
		SceneManager.LoadScene (0);//(SceneManager.GetActiveScene ().name);
	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
