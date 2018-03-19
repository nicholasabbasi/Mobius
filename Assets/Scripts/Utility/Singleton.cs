using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T: Singleton<T> {

	protected abstract T Instance { get; set; }
	
	void Awake() {
		//Check if instance already exists
		if (Instance == null) {
			//if not, set instance to this
			Instance = (T) this;
			DontDestroyOnLoad(gameObject);
		}
 
		//If instance already exists and it's not this:
		else if (Instance != this) {
			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);
		}
	}
}
