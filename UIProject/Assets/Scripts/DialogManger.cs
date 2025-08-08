using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine.EventSystems;

[Serializable]
public class Dialog
{
    public string Charactor;
    public string Content;

    public Dialog(string charactor, string content)
    {
        Charactor = charactor;
        Content = content;
    }
}

public class DialogManger : MonoBehaviour
{
    #region MonoSingleton
    // 1. �ڱ� �ڽſ� ���� �ν��Ͻ��� ������ (����)
    public static DialogManger Instance { get; private set; } // => ���� ���ٰ��� AND ���� �Ұ� = ������Ƽ

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // �ش� �ν��Ͻ��� �ڱ� �ڽ��Դϴ�.
            DontDestroyOnLoad(gameObject); // scene�� �Ѿ�� �ı����� ����, ���� ����
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    #region Field
    public TextMeshProUGUI Message;
    public TextMeshProUGUI CharactorName;
    public GameObject Penal;
    public float TypingSpeed = 0.05f;

    private Queue<Dialog> DiaQue = new Queue<Dialog>();
    // Enqueue : ����(ť�� ����) ������ �߰�
    // Dequeue : ����(ť�� ����) ���� �������� �� ����
    // Peek() : ���� ���� ���� �����ִ� �� Ȯ�� ����
    // Count() : ���� ť�� ��ϵ� ����� ����
    // DiaQue.Enqueue("A");
    // string data = DiaQue.Dequeue(); = "A"
    private Coroutine Typing;
    private bool IsTyping = false;
    private Dialog Current;
    #endregion

    public void StartLine(IEnumerable<Dialog> lines)
    {
        DiaQue.Clear();

        foreach (var line in lines)
        {
            DiaQue.Enqueue(line);
        }
        Penal.SetActive(true);
        NextLine();
    }
    private void Update()
    {
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsTyping)
            {
                CompleteLine();
            }
            else
            {
                NextLine();
            }
        }
    }
 
    private void CompleteLine()
    {
        if (Typing != null)
        {
            StopCoroutine(Typing);
        }
        Message.text = Current.Content;
        IsTyping = false;
    }
    private void NextLine()
    {
        if (DiaQue.Count == 0)
        {
            DialogueExit();
            return;
        }

        Current = DiaQue.Dequeue();
        CharactorName.text = Current.Charactor;

        if (Typing != null) StopCoroutine(Typing);

        Typing = StartCoroutine(TypingDialogue(Current.Content));

    }

    private void DialogueExit()
    {
        Penal.SetActive(false);
    }

    private IEnumerator TypingDialogue(string line)
    {
        IsTyping = true;
        StringBuilder stringBuilder = new StringBuilder(line.Length); // ��� ���� : C#������ String ���� �ѹ� �����Ǹ� ������
                                                                      // �Ұ��� = immutable object => ���Ҵ��̶� �ٸ�
                                                                      // ���ڿ��� ��� + ������ ���� �Ǹ� ���ο� ���ڿ��� �����ϴ� ����
                                                                      // ��ģ���� ���ο� �ִ� ���ۿ� ���� ���ڿ��� �����ؼ� ���� �� �� �ִ�.
        // �۾����� ������ �̰� ����, GC �󵵰� ����
        Message.text = "";

        foreach (char c in line)
        {
            // Message.text += c;
            stringBuilder.Append(c);
            Message.text = stringBuilder.ToString();
            yield return new WaitForSeconds(TypingSpeed);
        }
        IsTyping = false;
    }
}
// ~Manager�� ���� ��� Singleton
// ���α׷� ��ü���� �� �ϳ��� �ν��Ͻ��� �����ϵ��� �����ϴ� ���� ���