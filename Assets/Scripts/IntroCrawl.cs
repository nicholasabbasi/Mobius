using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroCrawl : MonoBehaviour {

	public Text Text;

	private string[] _intro;
	private float _previous;
	private int _current = 0;

	private bool fadingIn;
	
	// Use this for initialization
	private void Start () {
		var path = Path.Combine(Application.streamingAssetsPath, "Intro.json");
		_intro = JsonUtility.FromJson<IntroText>(File.ReadAllText(path)).array;
		
		Text.CrossFadeAlpha(0, 0, false);
	}
	
	// Update is called once per frame
	private void Update () {
		var timeFading = Fading();
		
		if (Input.GetMouseButtonDown(0) && timeFading > 2) {
			FadeOut();
			
		}

		if (!fadingIn && timeFading > 1 && timeFading < 2) {
			UpdateText();
			FadeIn();
		}
	}

	public void UpdateText() {
		if (_current >= _intro.Length) {
			Scenes.LoadMainScene();
		}
		
		Text.text = _intro[_current++];
	}
	
	private float fadingStart;

	public void FadeIn() {
		fadingStart = Time.unscaledTime;
		fadingIn = true;
		Text.CrossFadeAlpha(1, 1, true);
	}

	public void FadeOut() {
		fadingStart = Time.unscaledTime;
		fadingIn = false;
		Text.CrossFadeAlpha(0, 1, true);
	}

	public float Fading() {
		return Time.unscaledTime - fadingStart;
	}
}

[Serializable]
public class IntroText {
	public string[] array;
}

[Serializable]
public class IntroSegment {
	public string text;
}
