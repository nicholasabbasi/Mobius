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
        LeaveChat();
    }

    public void SpawnText(string question, string[] answers, Action<int> handler = null) {
        ClearText();
        Panel.SetActive(true);
        SpawnText(question, -30);

        for (var i = 0; i < answers.Length; i++) {
            SpawnText((i + 1) + ". " + answers[i], -90 + -30 * i, handler, i);
        }
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void SpawnText(string text, int height, Action<int> handler = null, int index = 0) {
        var textObj = Instantiate(Text, Panel.transform, true);

        textObj.rectTransform.offsetMin = new Vector2(20, height - 15);
        textObj.rectTransform.offsetMax = new Vector2(20, height + 15);

        textObj.text = text;

        if (handler != null) {
            textObj.gameObject.AddComponent<Button>();
            textObj.GetComponent<Button>().onClick.AddListener(delegate { handler(index); });
        }
    }

    public void LeaveChat() {
        ClearText();
        Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void ClearText() {
        foreach (Transform child in Panel.transform) {
            Destroy(child.gameObject);
        }
    }
}
