using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUi : MonoBehaviour
{
    public Button StartBt;
    public Button RuleBt;
    public Button EndBt;

    public GameObject RuleUI;

    private void Start()
    {
        StartBt.onClick.AddListener(GameStart);
        RuleBt.onClick.AddListener(RuleView);
        EndBt.onClick.AddListener(GameExit);
    }

    private void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void RuleView()
    {
       RuleUI.SetActive(true);
    }
    private void GameExit()
    {
        // CROSS 플랫폼에서 이렇게 한다 ( EX) APPLE, ANROID )
        #if UNITY_EDITOR 
                EditorApplication.Exit(0); // 이미 여기서 끝난다고 판단, 밑은 실행 안 시킴
        #else
                Application.Quit();
        #endif
    }
}
