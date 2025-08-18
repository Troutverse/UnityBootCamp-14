using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventCycle : MonoBehaviour,

    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler, IPointerClickHandler,

    IBeginDragHandler, IDragHandler, IEndDragHandler,

    IScrollHandler,

    ISelectHandler, IDeselectHandler, // 선택과 취소
    ISubmitHandler, ICancelHandler,

    IUpdateSelectedHandler,  // 선택 상태에서의 매 프레임에 대한 작업
    IMoveHandler             // 키보드나 조이스틱 관련
{
    // 필드
    private int eventCount = 0;
    private float lastEventTime = 0.0f;

    private void OnEnable()
    {
        eventCount = 0;
        lastEventTime = Time.time;
    }
    // 이벤트 처리용 함수
    // BaseEventData는 이벤트 시스템에서 사용되는 이벤트 데이터에 대한 기초 클래스
    private void Handle(string eventName, BaseEventData eventData)
    {
        eventCount++;
        float now = Time.time;
        float delta = now - lastEventTime; // 직전의 이벤트와의 시간 간격을 계산
        lastEventTime = now;

        string pos = "";

        if (eventData is PointerEventData pointertData)     // 데이터 변환
        {
            pos = $"pos : {pointertData.position}";
        }

        StringBuilder sb = new StringBuilder();
        sb.Append($"<color=yellow>{eventCount}</color> ");// 횟수
        sb.Append($"<b>{eventName}</b> ");// 이벤트명
        sb.Append($"<color=cyan>{pos}</color> "); // 좌표
        sb.Append($"<color=blue>{delta:F3}</color>");// 이벤트 시간 간격
        // F3 : Fixed-point (부동 소수점) = Float , 소수점 이하 3자리까지
        // N2 : Number에 대한 구분 1,234.57
        // D5 : Decimal(정수)에 대한 구분 01234
        // P1 : 퍼센트에 대한 사용 (값 * 100 이후 %를 붙인다) {0.34 : P1} ==> 34%
        Debug.Log(sb.ToString());       
    }
    // 해당 이벤트가 발생할 때마다 Handle이 실행된다.
    // 실행하는 명령문이 1개일 경우 줄어서 표현 가능
    // 방법) 접근제한자 반환타입 함수명(매개변수) => 실행 기능;
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