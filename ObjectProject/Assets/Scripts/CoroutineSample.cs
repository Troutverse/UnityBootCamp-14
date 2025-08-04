using UnityEngine;
using System.Collections;

public class CoroutineSample : MonoBehaviour
{
    // 적용할 타켓
    public GameObject target;
    
    // 번화 시간
    float duration = 5.0f;

    // 바꾸고 싶은 색
    public Color color;

    Coroutine coroutine;

    // Start 에서 코루틴을 많이 사용한다.
    void Start()
    {
        // coroutine = StartCoroutine(ChangeColor());
        // StopCoroutine(coroutine), StopCoroutine("ChangeColor")
        // StopAllCoroutines(); 모든 코루틴 중지
        if (target != null)
        {
            StartCoroutine(ChangeColor());
            // StartCoroutine(메소드명()) : IEnumerator 형태의 메소드를 코루틴으로 시작
            // 코드 작성 과정에서 메소드가 결정되 안전함
            // 매소드 호출은 컴파일 과정에서 확인 되기에 찾아 실행하는 시간이 문자열보다 적게 든다.
            // StartCoroutine("ChangeColor");
            // "메소드명" : 문자열을 통해 매개 변수가 없는 코루틴을 호출할 수도 있다.
            // 내부적으로 메소드의 이름을 문자열로 전달하고, 런타임에서 찾아서 실행하는 방식(리플렉션)
            // 타입 체크를 따로 하지 않아서 잘못된 이름을 쓰면 오류 발생
        }
    }
    IEnumerator ChangeColor()
    {
        var targetRenderer = target.GetComponent<Renderer>();
        if (targetRenderer == null) 
        {
            yield break;
        }

        float time = 0.0f;

        var start = targetRenderer.material.color;
        var end = color;

        // 반복 작업
        // 코루틴 내에서 반복문을 설계하면, yield에 의해 빠져나갔다가 다시 돌아와서 반복문을 실행하게 된다.
        while (time < duration) // 변화 시간 만큼 작업
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time, duration) / duration;
            // Mathf.PingPong(a, b) 주어진 값을 a와 b 사이에서 반복되는 값을 생성한다.(기본적인 왕복 운동)
            // 약 0에서 1 사이의 변화 값이 계산 ( 정규화 작업을 진행한 이유 : Color는 0부터 1까지의 값이기 때문 )

            targetRenderer.material.color = Color.Lerp(start, end, value);
            Debug.Log(targetRenderer.material.color);
            // 색상에 대한 부드러운 변경

            yield return new WaitForSeconds(1.0f);
        }
    }
}