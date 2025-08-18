using System;
using UnityEngine;
// C# Event
// 클릭, 터치에 따른 반응을 처리하는 하나의 시스템

// 제공자(Publisher)
// 사용자의 행동을 기다리다가 구독자에게 알려주는 역할을 진행합니다

// 구독자(Subscribers)
// 이벤트 제공자에 대한 구독을 통해 사용자의 행동을 전달 받아서 반응하는 역할을 진행

// 구독자의 경우 구독자의 행동 자체를 제공자가 알아야할 필요는 따로 없음
// 제공자의 경우 무분별하게 삭제할 경우 관련 구독자들이 기능을 사용할 수 없음

// Event 사용을 위해선 System 네임스페이스를 사용해야 한다


public class EventSample : MonoBehaviour
{
    public EventHandler OnSpaceEnter;
    // 변수의 이름은 보통 => On + 동사 / 시제로 만든다

    // C#에서 제공해주는 delegate 타입
    // EventHandler의 경우 터치나 클릭 등의 이벤트를 관찰하는 용도
    // 매개번수
    // Object sender <- object 타입의 데이터를 전달받을 수 있으며, 이벤트를 발생시킬 대상을 의미

    // EventArgs e <- 이벤트와 관련된 데이터를 담고 있는 객체를 의미한다
    // 해당 값은 EventArgs 또는 해당 자식 클래스가 들어갈 수 있다

    private void Start()
    {
        OnSpaceEnter += Debug_OnSpaceEnter;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnSpaceEnter != null)
        {
            OnSpaceEnter(this, EventArgs.Empty);
            // EventArgs.Empty : 이벤트 실행에 있어 특별히 추가되는 데이터가 없음
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            // 메소드, 속성(Property), 이벤트 등의 호출 시에 사용
            // 레퍼런스 형태의 타입 또는 nullable 객체를 대상으로 사용
        }
    }
    
    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow>Enter</color>");
    }
}
