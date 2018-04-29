using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public abstract class CHDialog: MonoBehaviour {    
    public string CharacterName;
    
    private DialogTree _tree;

    private FirstPersonController _controller;

    protected void StartDialog(FirstPersonController controller) {
        _tree = new DialogTree(CharacterName);
        _controller = controller;
        UpdateText();
        
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