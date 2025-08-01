using UnityEngine;
/* https://docs.unity3d.com/kr/2021.1/Manual/class-Mathf.html 
중요 Class Methf
유니티에서 수학관련으로 제공되는 유틸리티 클래스
게임 개발에서 사용될 수 있는 수학 연산에 대한 정적 메소드와 상수를 제공
ex) Methf.함수(); => 정적 메소드 : Static 키워드로 구성된 해당 메소드는 클래스명.메소드명()
 */
public class MathF : MonoBehaviour
{
    float abs = -5, ceil = 4.1f, floor = 4.6f, round = 4.5f, clamp, clamp01, pow = 2, sqrt = 4;

    void Start()
    {
        Debug.Log(Mathf.Abs(abs)); // absolute number
        Debug.Log(Mathf.Ceil(ceil)); // 소수점과 상관없이 값을 올림 처리
        Debug.Log(Mathf.Floor(floor)); // 소수점과 상관없이 값을 내림 처리
        Debug.Log("Round : " + Mathf.Round(round)); // 반올림
        Debug.Log(Mathf.Clamp(7, 0, 4)); // 전달 받은 값 = 7, 최소 = 0, 최대 = 4 결과 => 4 => 값 최소 최대 순으로 값 입력
        Debug.Log(Mathf.Clamp01(5)); // 전달 받은 값 = 5, 최소 = 0, 최대 = 1 결과 => 1 => 벗어나면 최솟값 또는 최대값 1로 처리 = 퍼센트 개념의 값을 처리
        // Clamp VS Clamp01 Clap는 체력 점수 속도 등의 능쳑치 개념에서 범위 제한, Clamp01 은 비율(퍼센트), 보간 값(1), 알파 값(색깔에서의 투명도)
        Debug.Log(Mathf.Pow(pow, -2f)); // 값, 제곱수(지수) => 이렇게 할경우 sqrt보다 느림, 음수 값도 가능함
        Debug.Log(Mathf.Sqrt(sqrt)); // 루트
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
