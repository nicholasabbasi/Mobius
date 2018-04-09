using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

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

	public DialogTree(string name) {
		var path = Path.Combine(_dialogFolderPath, name + ".json");
		
		// Load from JSON file in StreamingAssets/Dialog/$name.json
		if (File.Exists(path)) {
			_data = JsonUtility.FromJson<DialogTreeData>(File.ReadAllText(path)).dialog;
		}
		else {
			Debug.LogError("Could not load dialog data for: " + name);
		}
	
		// Build up hashmap in beginning to allow for quick jumps.
		for (var i = 0; i < _data.Length; i++) {
			var dialog = _data[i];
			if (dialog.tag == null) {
				continue;
			}
			
			_tagMap.Add(dialog.tag, i);
		}

		_current = 0;
	}

	public Dialog ChooseOption(int optionIndex) {
		var option = Current.options[optionIndex];

		if (option.tag == null) {
			_current++;
		}
		else {
			_current = _tagMap[option.tag];
		}

		return Current;
	}
}

[Serializable]
public class DialogTreeData {
	public readonly Dialog[] dialog;
}

[Serializable]
public struct Dialog {
	public readonly string text;
	public readonly string tag;
	public readonly DialogLink[] options;
}

[Serializable]
public struct DialogLink {
	public readonly string text;
	
	// If it doesn't exist, then progress to next dialog.
	public readonly string tag;
}
