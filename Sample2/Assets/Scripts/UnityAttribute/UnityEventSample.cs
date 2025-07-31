using UnityEngine;
using UnityEngine.Events;
public class UnityEventSample : MonoBehaviour
{
    [Tooltip("이벤트 리스트 추가 및 게임 오브젝트 등록")]
    public UnityEvent action;

    private void Update()
    {
        action.Invoke(); // 액션에 등록된 함수를 실행
    }
    public void Move()
    {
        gameObject.transform.Translate(0, 1, 0);
    }
}
