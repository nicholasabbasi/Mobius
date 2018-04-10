using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogTree {
	private readonly string _dialogFolderPath = Path.Combine(Application.streamingAssetsPath, "Dialog");

	private readonly Dialog[] _data;
	private int _current;
	
	// Handles fast lookup of tag -> index
	private readonly Dictionary<string, int> _tagMap = new Dictionary<string, int>();
	
	// The Current Dialog onscreen.
	public Dialog Current {
		get { return _data[_current]; }
	}
	
	public bool IsFinished = false;

	public DialogTree(string name) {
		var path = Path.Combine(_dialogFolderPath, name + ".json");
		
		// Load from JSON file in StreamingAssets/Dialog/$name.json
		if (File.Exists(path)) {
			var fileData = File.ReadAllText(path);
			
			_data = JsonUtility.FromJson<DialogTreeData>(fileData).dialog;
			
			// Build up hashmap in beginning to allow for quick jumps.
			for (var i = 0; i < _data.Length; i++) {
				var dialog = _data[i];
				if (dialog.tag == null) {
					continue;
				}
			
				_tagMap.Add(dialog.tag, i);
			}
		}
		else {
			Debug.LogError("Could not load dialog data for: " + name + " at path " + path);
		}

		_current = 0;
	}

	public Dialog ChooseOption(int optionIndex) {
		var option = Current.options[optionIndex];

		if (option.link == "end") {
			IsFinished = true;
			return Current;
		}

		if (option.link == "death") {
			IsFinished = true;
			SceneManager.LoadScene(0);
			return Current;
		}

		if (option.link == null) {
			_current = (_current + 1) % _data.Length;
		}
		else {
			_current = _tagMap[option.link];
		}
		
		Debug.Log("Loading " + Current.options[0].text);

		return Current;
	}
}

[Serializable]
public class DialogTreeData {
	public Dialog[] dialog;
}

[Serializable]
public struct Dialog {
	public string text;
	public string tag;
	public DialogLink[] options;
}

[Serializable]
public struct DialogLink {
	public string text;
	
	// If it doesn't exist, then progress to next dialog.
	public string link;
}
