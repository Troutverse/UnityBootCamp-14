using UnityEngine;

public class SphericaInter : MonoBehaviour
{ // ���� ���� ���� = Spherically interpolate
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

// 1. �ܼ��� ��ġ �̵� Lerp
// 2. ȸ�� �� ���� ��ȯ Slerp
// 3. �ڿ������� ī�޶��� ������ Slerp

// Slerp ȸ���̳� ������ ������ �ʿ��� ��� 3D ȸ�� (���ʹϾ�), ���Ͱ��� � ��� Ȯ��, ���� ȸ���� �ε巴�� ��� ������ �ٶ���� �� ���