using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventCycle : MonoBehaviour,

    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler, IPointerClickHandler,

    IBeginDragHandler, IDragHandler, IEndDragHandler,

    IScrollHandler,

    ISelectHandler, IDeselectHandler, // ���ð� ���
    ISubmitHandler, ICancelHandler,

    IUpdateSelectedHandler,  // ���� ���¿����� �� �����ӿ� ���� �۾�
    IMoveHandler             // Ű���峪 ���̽�ƽ ����
{
    // �ʵ�
    private int eventCount = 0;
    private float lastEventTime = 0.0f;

    private void OnEnable()
    {
        eventCount = 0;
        lastEventTime = Time.time;
    }
    // �̺�Ʈ ó���� �Լ�
    // BaseEventData�� �̺�Ʈ �ý��ۿ��� ���Ǵ� �̺�Ʈ �����Ϳ� ���� ���� Ŭ����
    private void Handle(string eventName, BaseEventData eventData)
    {
        eventCount++;
        float now = Time.time;
        float delta = now - lastEventTime; // ������ �̺�Ʈ���� �ð� ������ ���
        lastEventTime = now;

        string pos = "";

        if (eventData is PointerEventData pointertData)     // ������ ��ȯ
        {
            pos = $"pos : {pointertData.position}";
        }

        StringBuilder sb = new StringBuilder();
        sb.Append($"<color=yellow>{eventCount}</color> ");// Ƚ��
        sb.Append($"<b>{eventName}</b> ");// �̺�Ʈ��
        sb.Append($"<color=cyan>{pos}</color> "); // ��ǥ
        sb.Append($"<color=blue>{delta:F3}</color>");// �̺�Ʈ �ð� ����
        // F3 : Fixed-point (�ε� �Ҽ���) = Float , �Ҽ��� ���� 3�ڸ�����
        // N2 : Number�� ���� ���� 1,234.57
        // D5 : Decimal(����)�� ���� ���� 01234
        // P1 : �ۼ�Ʈ�� ���� ��� (�� * 100 ���� %�� ���δ�) {0.34 : P1} ==> 34%
        Debug.Log(sb.ToString());       
    }
    // �ش� �̺�Ʈ�� �߻��� ������ Handle�� ����ȴ�.
    // �����ϴ� ��ɹ��� 1���� ��� �پ ǥ�� ����
    // ���) ���������� ��ȯŸ�� �Լ���(�Ű�����) => ���� ���;
    // ex) public void OnBeginDrag(PointerEventData eventData) => Handle("Begin Drag", eventData);

    public void OnBeginDrag(PointerEventData eventData) => Handle("Begin Drag", eventData);
    public void OnCancel(BaseEventData eventData) => Handle("OnCancel", eventData);
    public void OnDeselect(BaseEventData eventData) => Handle("OnDeselect", eventData);
    public void OnDrag(PointerEventData eventData) => Handle("OnDrag", eventData);
    public void OnEndDrag(PointerEventData eventData) => Handle("OnEndDrag", eventData);
    public void OnMove(AxisEventData eventData) => Handle("OnMove", eventData);
    public void OnPointerClick(PointerEventData eventData) => Handle("OnPointerClick", eventData);
    public void OnPointerDown(PointerEventData eventData) => Handle("OnPointerDown", eventData);
    public void OnPointerEnter(PointerEventData eventData) => Handle("OnPointerEnter", eventData);
    public void OnPointerExit(PointerEventData eventData) => Handle("OnPointerExit", eventData);
    public void OnPointerUp(PointerEventData eventData) => Handle("OnPointerUp", eventData);
    public void OnScroll(PointerEventData eventData) => Handle("OnScroll", eventData);
    public void OnSelect(BaseEventData eventData) => Handle("OnSelect", eventData);
    public void OnSubmit(BaseEventData eventData) => Handle("OnSubmit", eventData);
    public void OnUpdateSelected(BaseEventData eventData) => Handle("OnUpdateSelected", eventData);
}