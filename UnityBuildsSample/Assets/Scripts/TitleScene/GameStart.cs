using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private Button GameStartButton;

    private void Start()
    {
        GameStartButton = GetComponent<Button>();
        GameStartButton.onClick.AddListener(GameStartButtonClick);
    }
     
    private void GameStartButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
