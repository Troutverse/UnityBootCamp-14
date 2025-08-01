using UnityEngine;
// Mathf Ŭ�������� �������ִ� ��� ��
public class MathConstant : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Mathf.PI);
        Debug.Log(Mathf.Infinity);
        // ������ ���꿡 ���ؼ� ǥ���� �� �ִ� �ִ��� ���� �Ѵ� ����� �ڵ����� ó���ȴ� ��
        // ���������� Infinity�� �ۼ��� ��������� ���Ѵ븦 ǥ���ϱ⵵ ��
        // 1) Pow(0, -2) = 1/0 (Infinity)
        // 2) float ������ ǥ���� �� ���� ū ���� �����ϴ� ���, ���� ����� ���, ���� �÷ο� ������ ��� (���� �ִ밪 == float.MaxValue �̷��� �̾Ƴ��� ����)
        Debug.Log(Mathf.NegativeInfinity);
        // 1) ������ ���� ���� ������ �����÷ο� �Ǵ� ���
        // 2) ���������� NegativeInfinity�� ��õǴ� ��� ex) sqrt(-1), 0/0 �� => NaN(Not a Number)
        
        // NaN
        // 1. �� ���� NaN�� ��� �� ���� ���� �񱳴� �Ұ��� �ϴ� (������ üũ�ϸ� False)
        // float.inNaN(��)�� ���� �ش� ���� NaN������ Ȯ���� ����
        // 2. infinity - infinity = NaN, 0 / 0 ���� ���������� ǥ�� �Ұ����� ��
        // ������ ���� ��Ʈ ��� (����� ���Ҽ� ���� ������ ����ڰ� ���� ������ ������� �����Ѵ�)
        // --> ����Ƽ�� C#���� ����� ���� �������� ������ ���� ����
        // System.Numerics.Complex ����� ���� ��� ����� ���� (����) ����Ƽ ���� ���ؿ� ���� ����� ���ѵ�(ex WebGL)

        Debug.Log(Mathf.Deg2Rad); // Degree to Radian
        Debug.Log(Mathf.Rad2Deg); // Redian(������ ���� = �������� ���� ���̸� ���� ȣ�� ���� �߽ɰ� = 1 ����(57��), �� 60��)
        Debug.Log(Mathf.Epsilon); // float ������ 0�� �ƴ� ���� ���� ��� �� (0�� ����) => �̼��� ���� �ٷ� �� ���, float 0f < Epsilon 

    }
}
