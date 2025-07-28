using UnityEngine;

public class VectorTest1 : MonoBehaviour
{
    // 게임 오브젝트의 Transform을 통해 Vector 값 구하기
    public Transform A_CUBE;
    public Transform B_CUBE;

    void Start()
    {
        Vector3 PosA = A_CUBE.position;
        Vector3 PosB = B_CUBE.position;

        // 방향
        Vector3 BTA = PosB - PosA;
        Vector3 ATB = PosA - PosB;

        // 거리
        float distance = Vector3.Distance(PosA, PosB);

        // 유니티의 Mathf 클래스를 기반으로 바꾸면
        Vector3 DIR = PosB - PosA;
        float distance2 = Mathf.Sqrt(DIR.x * DIR.x + DIR.y * DIR.y + DIR.z * DIR.z);
        Debug.Log(distance);
        Debug.Log(distance2);
    }

    void Update()
    {
        
    }
}
