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
        // CROSS �÷������� �̷��� �Ѵ� ( EX) APPLE, ANROID )
#if UNITY_EDITOR
Application.Quit(); // �̹� ���⼭ �����ٰ� �Ǵ�, ���� ���� �� ��Ŵ
#else
EditorApplication.Exit(0);
EditorApplication.isPlaying = false;
#endif
    }
}
