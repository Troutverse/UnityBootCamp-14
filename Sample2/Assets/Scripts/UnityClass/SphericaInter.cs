using UnityEngine;

public class SphericaInter : MonoBehaviour
{ // 구면 선형 보간 = Spherically interpolate
    public Transform target;
    public float speed = 1.0f;

    private Vector3 start_position;
    private float t = 0.0f;

    private void Start()
    {
        start_position = transform.position;
    }

    private void Update()
    {
        if (t < 1.0f)
        {
            t += Time.deltaTime * speed;
            transform.position = Vector3.Slerp(start_position, target.position, t);
        }

    }
}

// Lerp VS Slerp

// 1. 단순한 위치 이동 Lerp
// 2. 회전 빛 방향 전환 Slerp
// 3. 자연스러운 카메라의 움직임 Slerp

// Slerp 회전이나 각도의 개념이 필요한 경우 3D 회전 (쿼터니언), 백터간의 곡선 경로 확인, 방향 회전이 부드럽게 대상 방향을 바라봐야 할 경우