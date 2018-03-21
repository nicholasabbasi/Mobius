using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime: Singleton<GameTime> {
	
	public static GameTime INSTANCE;
	
	public float Scale = 1;

	public float seconds {
		get { return Time.unscaledTime * Scale; }
	}

	public float minutes {
		get { return seconds / 60; }
	}

	public float hours {
		get { return (seconds / 60 / 60) + 11; }
	}
	
	public int displaySeconds {
		get { return (int) seconds % 60; }
	}

	public int displayMinutes {
		get { return (int) minutes % 60; }
	}

	public int displayHours {
		get { return (int) hours % 12; }
	}

	public String display {
		get {
			return displayHours +
			       ":" +
			       (displayMinutes < 10 ? "0" : "") +
			       displayMinutes;
		}
	}

	// Only required for singleton.
	protected override GameTime Instance {
		get { return INSTANCE; }
		set { INSTANCE = value; }
	}
}
