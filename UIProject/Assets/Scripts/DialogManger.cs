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
    // 1. 자기 자신에 대한 인스턴스를 가진다 (전역)
    public static DialogManger Instance { get; private set; } // => 값에 접근가능 AND 수정 불가 = 프로퍼티

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // 해당 인스턴스는 자기 자신입니다.
            DontDestroyOnLoad(gameObject); // scene이 넘어가도 파괴되지 않음, 씬의 영역
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
    // Enqueue : 삽입(큐의 뒤쪽) 데이터 추가
    // Dequeue : 삭제(큐의 앞쪽) 가장 먼저들어온 값 제거
    // Peek() : 현재 가장 먼저 들어와있는 값 확인 가능
    // Count() : 현재 큐에 등록된 요소의 개수
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
        StringBuilder stringBuilder = new StringBuilder(line.Length); // 사용 이유 : C#에서는 String 값은 한번 생성되면 수정이
                                                                      // 불가능 = immutable object => 재할당이랑 다름
                                                                      // 문자열에 경우 + 연산이 진행 되면 새로운 문자열을 생성하는 구조
                                                                      // 이친구는 내부에 있는 버퍼에 의해 문자열을 누적해서 수정 할 수 있다.
        // 작업량이 많으면 이게 유리, GC 빈도가 적다
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
// ~Manager의 설계 방식 Singleton
// 프로그램 전체에서 단 하나의 인스턴스만 존재하도록 보장하는 설계 방식