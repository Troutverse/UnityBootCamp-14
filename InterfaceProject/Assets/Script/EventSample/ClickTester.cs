using UnityEngine;
using UnityEngine.EventSystems;

// 1. 이벤트 시스템 컴포넌트가 씬에 존재
// 2. UI의 경우 그래픽 레이캐스터 컴포넌트가 추가, Raycast의 Target 체크
// 3. 오브젝트의 경우 Collider 있어야 함
// 4. 메인 카메라에 Physics Raycaster 있어야 함

// 제공되는 기능 기준 일반적인 순서
// 1. Pointer Enter
// 2. Pointer Down
// 3. Begin Drag
// 4. Dragging
// 5. End Drag
// 6. Pointer Up
// 7. Pointer Exit
// 8. Select
// 9. Submit
// 10. Move
// 11. Cancel
public class ClickTester : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    // PointerEventData : 마우스 클릭 시의 클릭 버튼, 클릭 횟수, 포인터 위치 등에 대한 정보를 가지고 있는 클래스
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Touch OR Mouse Pointer Position : " + eventData.position);
        Debug.Log("Click Count : " + eventData.clickCount);
        Debug.Log("Click Time : " + eventData.clickTime);
        Debug.Log("Pointer Movement amount : " + eventData.delta);
        Debug.Log("IsDragging : " + eventData.dragging);

        // eventData.button = 버튼, eventData.phase = 현재 이벤트 단계, eventData.pointId : 터치 OR 마우스 포인터의 ID
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer ON");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Pointer OFF");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer EXIT");
    }
}
