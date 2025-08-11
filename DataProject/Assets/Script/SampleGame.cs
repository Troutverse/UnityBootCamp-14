using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SampleGame : MonoBehaviour
{
    public int Score = 0;
    public int MaxScore = 0;
    public float GameTime = 10.0f;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameTimeText;
    public TextMeshProUGUI MaxScoreText;
    public GameObject GameObjects;
    public GameObject ButtonsCanvas;
    public LayerMask ObjectClick;
    // Time.timeScale = 씬에서의 시간 비율, 기본적으로 해당 값은 1로 설정 되어 있음
    // 2로 바꾸면 시간이 2배, 움직임, 물리 등도 2배 처리
    private void Start()
    {
        ScoreText.text = $"Score : {Score.ToString()}";
        GameTimeText.text = $"Game Time : {Mathf.Ceil(GameTime).ToString()}";
        MaxScore = PlayerPrefs.GetInt("MaxScore", 0);
        MaxScoreText.text = $"Max Score : {PlayerPrefs.GetInt("MaxScore")}";
        ButtonsCanvas.SetActive(false);
        GameObjects.SetActive(true);
    }
    void Update()
    {
        if (GameTime <= 0)
        {
            if (Score >= MaxScore) PlayerPrefs.SetInt("MaxScore", Score);
            ScoreText.text = $"Score : {Score.ToString()}";
            MaxScoreText.text = $"Max Score : {PlayerPrefs.GetInt("MaxScore")}";
            ButtonsCanvas.SetActive(true);
            GameObjects.SetActive(false);
        }
        else 
        {
            GameTime -= Time.deltaTime;
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(MousePos, Vector2.zero, Mathf.Infinity, ObjectClick);
                if (hit.collider != null)
                { 
                    Score++;
                    GameObjects.transform.localScale *= 1.05f;
                }
            }
            GameTimeText.text = $"Game Time : {Mathf.Ceil(GameTime).ToString()}";
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
