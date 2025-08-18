using UnityEngine;
using UnityEngine.EventSystems;

// 1. �̺�Ʈ �ý��� ������Ʈ�� ���� ����
// 2. UI�� ��� �׷��� ����ĳ���� ������Ʈ�� �߰�, Raycast�� Target üũ
// 3. ������Ʈ�� ��� Collider �־�� ��
// 4. ���� ī�޶� Physics Raycaster �־�� ��

// �����Ǵ� ��� ���� �Ϲ����� ����
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
    // PointerEventData : ���콺 Ŭ�� ���� Ŭ�� ��ư, Ŭ�� Ƚ��, ������ ��ġ � ���� ������ ������ �ִ� Ŭ����
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Touch OR Mouse Pointer Position : " + eventData.position);
        Debug.Log("Click Count : " + eventData.clickCount);
        Debug.Log("Click Time : " + eventData.clickTime);
        Debug.Log("Pointer Movement amount : " + eventData.delta);
        Debug.Log("IsDragging : " + eventData.dragging);

        // eventData.button = ��ư, eventData.phase = ���� �̺�Ʈ �ܰ�, eventData.pointId : ��ġ OR ���콺 �������� ID
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
