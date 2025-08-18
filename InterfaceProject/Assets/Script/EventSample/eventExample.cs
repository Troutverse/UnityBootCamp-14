using System;
using UnityEngine;

// event : 특정 상황이 발생했을 때 알림을 보내는 메커니즘
// 1. 플레이어가 죽었을 때 알림 전달 -> 메소드 호출

public class eventExample : MonoBehaviour
{
    public Action onDeath;
    public event Action onStart;

    private void Start()
    {
        // 액션은 +=을 통해 함수(메소드)를 액션에 등록할 수 있다 (구독)
        // 액션 -=을 통해 함수(메소드)를 액션에서 제거할 수 있습니다(해제)
        // 액션의 기능을 호출하면 등록되어있는 함수가 순차적으로 호출됩니다
        onStart += Ready;
        onStart += Fight;

        onDeath += Damaged;
        onDeath += Dead;

        onStart?.Invoke();
        onDeath?.Invoke();

        // 함수처럼 호출하는 것도 가능
        onStart();
        onDeath();
    }
    private void Fight()
    {
        Debug.Log("<color=yellow>Fight</color>");
    }
    private void Ready()
    {
        Debug.Log("<color=yellow>Ready</color>");
    }
    private void Dead()
    {
        Debug.Log("<color=blue><b>Dead</b></color>");
    }
    private void Damaged()
    {
        Debug.Log("Damage");
    }
}