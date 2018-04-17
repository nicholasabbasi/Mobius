using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogTree {
	private readonly string _dialogFolderPath = Path.Combine(Application.streamingAssetsPath, "Dialog");

	private readonly Dialog[] _data;
	private int _current;
	
	// Handles fast lookup of tag -> index
	private readonly Dictionary<string, int> _tagMap = new Dictionary<string, int>();
	
	// Handles lookup of flag -> set or not.
	private readonly HashSet<string> _flags = new HashSet<string>();
	
	// The Current Dialog onscreen.
	public Dialog Current {
		get { return _data[_current]; }
	}

	public DialogLink[] Options {
		get { return Current.options.Where(it => it.showFlag == null || _flags.Contains(it.showFlag)).ToArray(); }
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
		var option = Options[optionIndex];

		if (option.link == "end") {
			IsFinished = true;
			return Current;
		}

		if (option.link == "death") {
			IsFinished = true;
			Scenes.LoadMainScene();
			return Current;
		}

		if (option.link == null) {
			_current = (_current + 1) % _data.Length;
		}
		else {
			_current = _tagMap[option.link];
		}
		
		// We have loaded the new option.
		// Now set the flags up.
		if (Current.setFlag != null) {
			_flags.Add(Current.setFlag);
		}
		
		Debug.Log("Loading " + Current.options[0].text);

		return Current;
	}
}

// Disable the warnings about the JSON objects not being named properly
// since the naming scheme for JSON objects and C# code is different.

// ReSharper disable UnassignedField.Global
// ReSharper disable InconsistentNaming
[Serializable]
public class DialogTreeData {
	public Dialog[] dialog;
}

[Serializable]
public struct Dialog {
	public string text;
	public string tag;
	
	// Set this flag when this dialog is shown.
	public string setFlag;
	
	public DialogLink[] options;
}

[Serializable]
public struct DialogLink {
	public string text;
	
	// Only show this option if the flag has been set.
	public string showFlag;
	// If it doesn't exist, then progress to next dialog.
	public string link;
}
