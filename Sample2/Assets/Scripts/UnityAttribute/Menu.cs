using UnityEngine;
// Attribute : [AddComponentMenu("")] 처럼 클래스나 함수, 변수 앞에 붙는 [] 들은 Attribute(속성)
// 에디터에 대한 확장이나 사용자 정의 툴 제작에서 제공되는 기능들
// 사용 목적 : 사용자가 에디터를 더 직관적으로, 편의적으로 사용하기 위해서

// 1. AddCompentMenu("그룹이름/기능이름")
// Editor의 Componet에 메뉴를 추가하는 기능
// 그룹을 적을 경우 그룹이 저장되며, 아닐 경우에는 기능만 저장됨

[AddComponentMenu("Sample/AddComponentMenu")]
public class Menu : MonoBehaviour
{
    //[ContextMenuItem("기능으로 표현할 이름", "함수의 이름")]
    //message를 대상으로 MessageReset 기능을 에디터에서 사용 가능
    [ContextMenuItem("MessageReset", "MessageReset")]
    public string message = "";
    public void MessageReset()
    {
        message = "";
    }

    [ContextMenu("Calling Warning Message")]
    public void MenuAttribute()
    {
        Debug.Log("Warning");
    }
}