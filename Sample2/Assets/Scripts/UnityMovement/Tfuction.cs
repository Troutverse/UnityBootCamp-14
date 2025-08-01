using UnityEngine;
// �ﰢ �Լ�
// ����Ƽ���� �������ִ� �ﰢ�Լ��� �ַ� ȸ��, ī�޶� ����, �, �����ӿ� ���� ǥ������ ���

// ������ ���� 1 ���� = �� 57��

public class Tfuction : MonoBehaviour
{
    // Sin(Radian) : Y
    // Cos(Radian) : X
    // Tan(Radian) : Y/X => ����
    // Time.time : �������� ������ ���� ���� �ð�
    // Time.deltatime : �������� �����ϰ� ������ �ð�
    Vector3 pos;
    public void CircleRotate() // ���� ȸ��
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
