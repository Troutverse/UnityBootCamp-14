using UnityEngine;
// 삼각 함수
// 유니티에서 제공해주는 삼각함수는 주로 회전, 카메라 제어, 곡선, 움직임에 대한 표현으로 사용

// 단위가 라디안 1 라디안 = 약 57도

public class Tfuction : MonoBehaviour
{
    // Sin(Radian) : Y
    // Cos(Radian) : X
    // Tan(Radian) : Y/X => 기울기
    // Time.time : 프레임이 시작한 순간 부터 시간
    // Time.deltatime : 프레임이 시작하고 끝나는 시간
    Vector3 pos;
    public void CircleRotate() // 원형 회전
    {
        float angle = Time.time * 90.0f;
        float radian = angle * Mathf.Deg2Rad;

        var x = Mathf.Cos(radian) * 5.0f;
        var y = Mathf.Sin(radian) * 5.0f;

        transform.position = new Vector3(x, y, 0);
    }

    public void Wave()
    {
        var offset = Mathf.Sin(Time.time * 2.0f) * 0.5f;
        transform.position = pos + Vector3.left * offset;
    }

    public void ButterFly()
    {
        float t = Time.time * 2;
        float x = Mathf.Sin(t) * 2;
        float y = Mathf.Sin(t * 2.0f) * 4;

        transform.position = new Vector3 (x, y, 0);
    }

    void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButton(0)) // Left Mouse Click
        {
            CircleRotate();
        }
        if (Input.GetMouseButton(1)) 
        {
            Wave();
        }
        if(Input.GetMouseButton(2))
        {
            ButterFly();
        }
    }
}
