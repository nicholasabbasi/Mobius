using UnityEngine;

public class TextHandler: MonoBehaviour {

    public static TextHandler INSTANCE;
    
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
    
    void Awake() {
        //Check if instance already exists
        if (INSTANCE == null) {
            //if not, set instance to this
            INSTANCE = this;
            DontDestroyOnLoad(gameObject);
        }
 
        //If instance already exists and it's not this:
        else if (INSTANCE != this) {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }
    }
    
}
