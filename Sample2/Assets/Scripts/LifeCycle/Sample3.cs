using UnityEngine;

// About Object Cashing

// 캐시 사용 의도
// 1. 시간 지역성 : 가장 최근의 사용된 값이 다시 사용될 가능성이 높다
// 2. 공간 지역성 : 최근에 접근한 주소와 인접한 주소의 변수가 사용될 가능성이 높음

public class Sample3 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 pos;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 캐싱(cashing)
    }

    void Update()
    {
       GetComponent<Rigidbody>().AddForce(pos * 5); // 프레임 마다 호출
    }
}
