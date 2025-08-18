using UnityEngine;
using UnityEngine.Events;

// C#의 Event와 차이점
// 1. 인스펙터에서 확인이 가능
// 2. 추가 기능들

// 사용할 수 있는것
// 1. C# Delegate
// 2. Unity UnityAction
// 3. C# Func<T>, Action<T>

// 언제 어떤 것을 사용해야 하는가 ?
// 1. 고성능 = C# Delegate
// 2. 단순(콜백) = Action OR UnityAction
// 3. UnityInspector = UnityAction
// 4. 이벤트 시그니처가 필요 = 호출되는 지에 정의한 함수의 형태 ex) void EventHandler(object sender, EventArgs e) = C# 의 EventHandler 선언
// => 시그니처 1. 반환 타임(void), 2. 매개변수(object, EventArgs) = Delegate, Func, Action

public class EventSample3 : MonoBehaviour
{
    public UnityEvent OnKButtonEnter;
    public UnityAction OnAction;

    private void Start()
    {
        OnKButtonEnter.AddListener(Sample);
        OnAction += Sample;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            OnKButtonEnter?.Invoke();
            OnAction?.Invoke();
        }
    }
    private void Sample()
    {
        Debug.Log("<color=red>K</color>");
    }
}