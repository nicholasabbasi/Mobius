using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public abstract class CHDialog: MonoBehaviour {    
    public string CharacterName;
    
    private DialogTree _tree;

    private FirstPersonController _controller;

    // Use this for initialization
    private void Start () {
        _tree = new DialogTree(CharacterName);
    }

    protected void StartDialog(FirstPersonController controller) {
        UpdateText();
        _controller = controller;

        if (_controller == null) {
            return;
        }
        
        _controller.enabled = false;
    }
    
    private void OnText(int index) {
        _tree.ChooseOption(index);
        UpdateText();
    }

    private void UpdateText() {
        var answers = _tree.Options.Select(it => it.text).ToArray();
		
        TextHandler.INSTANCE.SpawnText(_tree.Current.text, answers, OnText);

        if (_tree.IsFinished) {
            _controller.enabled = true;
            TextHandler.INSTANCE.LeaveChat();
        }
    }
}