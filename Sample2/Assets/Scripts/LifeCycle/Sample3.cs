using UnityEngine;

// About Object Cashing

// ĳ�� ��� �ǵ�
// 1. �ð� ������ : ���� �ֱ��� ���� ���� �ٽ� ���� ���ɼ��� ����
// 2. ���� ������ : �ֱٿ� ������ �ּҿ� ������ �ּ��� ������ ���� ���ɼ��� ����

public class Sample3 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 pos;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ĳ��(cashing)
    }

    void Update()
    {
       GetComponent<Rigidbody>().AddForce(pos * 5); // ������ ���� ȣ��
    }
}
