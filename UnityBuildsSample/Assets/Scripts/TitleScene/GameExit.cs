using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
    private Button GameExitButton;
    void Start()
    {
        GameExitButton = GetComponent<Button>();
        GameExitButton.onClick.AddListener(GameExitButtonClick);
    }

    private void GameExitButtonClick()
    {
    #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
    #endif
    }
}
