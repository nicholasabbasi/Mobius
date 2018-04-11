using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes {

	public static void LoadMainScene() {
		SceneManager.LoadScene(1);
	}

	public static void LoadWinScene() {
		SceneManager.LoadScene(2);
	}

	public static void LoadInitialScene() {
		SceneManager.LoadScene(0);
	}
}
