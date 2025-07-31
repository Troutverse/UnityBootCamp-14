using UnityEngine;

public class Linearinter : MonoBehaviour
{ // ���� ���� = Linear interpolate

    // Vector3.Lerp(start, end, t)
    // start -> End ���� t�� ���� ���� �����Ѵ�
    // �ش� �������� ���� ���� õõ�� �̵��ϴ� �ڵ�
    // t�� ���� (0f ~ 1f)
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
