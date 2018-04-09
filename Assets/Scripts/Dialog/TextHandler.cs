using System;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler: Singleton<TextHandler> {

    public static TextHandler INSTANCE;
    
    // Only required for singleton.
    protected override TextHandler Instance {
        get { return INSTANCE; }
        set { INSTANCE = value; }
    }

    public GameObject Panel;
    public Text Text;

    private void Start() {
        Text.transform.SetParent(null);
    }

    public void SpawnText(string text) {
        ClearText();
        Instantiate(Text, Panel.transform).text = text;
        
        Cursor.lockState = CursorLockMode.None;
    }

    public void LeaveChat() {
        ClearText();
        Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void ClearText() {
        foreach (Transform child in Panel.transform) {
            Destroy(child.gameObject);
        }
    }
}
