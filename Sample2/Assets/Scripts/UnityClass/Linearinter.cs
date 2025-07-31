using UnityEngine;

public class Linearinter : MonoBehaviour
{ // 선형 보간 = Linear interpolate

    // Vector3.Lerp(start, end, t)
    // start -> End 까지 t에 따라 선형 보간한다
    // 해당 방향으로 일정 간격 천천히 이동하는 코드
    // t의 범위 (0f ~ 1f)
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
            transform.position = Vector3.Lerp(start_position, target.position, t);
        }
        if (t >= 1.0f)
        {
            t = 0.0f;
            transform.position = start_position;
        }
        
    }
}
