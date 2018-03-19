﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DisplayTime : MonoBehaviour {

	private Text _text;

	// Use this for initialization
	private void Start () {
		_text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	private void Update () {
		_text.text = GameTime.INSTANCE.display;
	}
}
