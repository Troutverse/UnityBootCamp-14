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
                EditorApplication.Exit(0); // �̹� ���⼭ �����ٰ� �Ǵ�, ���� ���� �� ��Ŵ
        #else
                Application.Quit();
        #endif
    }
}
