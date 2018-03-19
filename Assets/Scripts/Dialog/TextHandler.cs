using UnityEngine;

public class TextHandler: Singleton<TextHandler> {

    public static TextHandler INSTANCE;
    
    // Only required for singleton.
    protected override TextHandler Instance {
        get { return INSTANCE; }
        set { INSTANCE = value; }
    }
    
    private GameObject _currentDialogue;

    public void SpawnText(GameObject text) {
        if (_currentDialogue != null) {
            Destroy(_currentDialogue);
        }
        
        _currentDialogue = Instantiate(text);
        Cursor.lockState = CursorLockMode.None;
    }

    public void LeaveChat() {
        Destroy(_currentDialogue);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
