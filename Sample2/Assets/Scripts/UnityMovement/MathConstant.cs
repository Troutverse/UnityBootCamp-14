using UnityEngine;
// Mathf 클래스에서 제공해주는 상수 값
public class MathConstant : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Mathf.PI);
        Debug.Log(Mathf.Infinity);
        // 수학적 연산에 의해서 표현할 수 있는 최대의 수를 넘는 경우라면 자동으로 처리된는 값
        // 직접적으로 Infinity를 작성해 명시적으로 무한대를 표현하기도 함
        // 1) Pow(0, -2) = 1/0 (Infinity)
        // 2) float 범위로 표현할 수 없는 큰 수를 제곱하는 경우, 연산 결과일 경우, 오버 플로우 현상일 경우 (수의 최대값 == float.MaxValue 이렇게 뽑아내기 가능)
        Debug.Log(Mathf.NegativeInfinity);
        // 1) 음수에 대한 지수 연산이 오버플로우 되는 경우
        // 2) 직접적으로 NegativeInfinity가 명시되는 경우 ex) sqrt(-1), 0/0 등 => NaN(Not a Number)
        
        // NaN
        // 1. 두 값이 NaN일 경우 그 값에 대한 비교는 불가능 하다 (같은지 체크하면 False)
        // float.inNaN(값)을 통해 해당 값이 NaN인지만 확인이 가능
        // 2. infinity - infinity = NaN, 0 / 0 등의 수학적으로 표현 불가능한 값
        // 음수에 대한 루트 계산 (허수나 복소수 같은 개념은 사용자가 따로 설계한 기능으로 수행한다)
        // --> 유니티나 C#에서 허수에 대한 직접적인 지원을 하지 않음
        // System.Numerics.Complex 기능을 통해 허수 계산이 가능 (단점) 유니티 빌드 기준에 따라 사용이 제한됨(ex WebGL)

        Debug.Log(Mathf.Deg2Rad); // Degree to Radian
        Debug.Log(Mathf.Rad2Deg); // Redian(각도의 단위 = 반지름과 같은 길이를 가진 호가 가진 중심각 = 1 라디안(57도), 약 60도)
        Debug.Log(Mathf.Epsilon); // float 형에서 0이 아닌 가장 작은 양수 값 (0의 극한) => 미세한 값을 다룰 떄 사용, float 0f < Epsilon 

    }
}
