using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour {
    public Text TimeText;
    public float time = 600f;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        TimeText.text = "Time Left: " + time;


        if (time <= 0)
        {
            time = 600f;
            SceneManager.LoadScene(1);

        }
	}
}
