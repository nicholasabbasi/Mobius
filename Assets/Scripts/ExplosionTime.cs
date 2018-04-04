using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTime : MonoBehaviour {
	public ParticleSystem Smaller;
	public ParticleSystem Larger;

	private bool _finished;

	private void Start() {
		Smaller.loop = false;
		Smaller.Stop();

		Larger.loop = false;
		Larger.Stop();
	}

	// Update is called once per frame
	private void Update () {
		if (GameTime.INSTANCE.minutes > 5 && !_finished) {
			_finished = true;
			
			Smaller.Play();
			Larger.Play();
		}
	}
}
