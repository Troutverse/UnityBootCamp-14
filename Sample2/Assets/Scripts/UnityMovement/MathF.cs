using UnityEngine;
/* https://docs.unity3d.com/kr/2021.1/Manual/class-Mathf.html 
�߿� Class Methf
����Ƽ���� ���а������� �����Ǵ� ��ƿ��Ƽ Ŭ����
���� ���߿��� ���� �� �ִ� ���� ���꿡 ���� ���� �޼ҵ�� ����� ����
ex) Methf.�Լ�(); => ���� �޼ҵ� : Static Ű����� ������ �ش� �޼ҵ�� Ŭ������.�޼ҵ��()
 */
public class MathF : MonoBehaviour
{
    float abs = -5, ceil = 4.1f, floor = 4.6f, round = 4.5f, clamp, clamp01, pow = 2, sqrt = 4;

    void Start()
    {
        Debug.Log(Mathf.Abs(abs)); // absolute number
        Debug.Log(Mathf.Ceil(ceil)); // �Ҽ����� ������� ���� �ø� ó��
        Debug.Log(Mathf.Floor(floor)); // �Ҽ����� ������� ���� ���� ó��
        Debug.Log("Round : " + Mathf.Round(round)); // �ݿø�
        Debug.Log(Mathf.Clamp(7, 0, 4)); // ���� ���� �� = 7, �ּ� = 0, �ִ� = 4 ��� => 4 => �� �ּ� �ִ� ������ �� �Է�
        Debug.Log(Mathf.Clamp01(5)); // ���� ���� �� = 5, �ּ� = 0, �ִ� = 1 ��� => 1 => ����� �ּڰ� �Ǵ� �ִ밪 1�� ó�� = �ۼ�Ʈ ������ ���� ó��
        // Clamp VS Clamp01 Clap�� ü�� ���� �ӵ� ���� �ɫrġ ���信�� ���� ����, Clamp01 �� ����(�ۼ�Ʈ), ���� ��(1), ���� ��(���򿡼��� ����)
        Debug.Log(Mathf.Pow(pow, -2f)); // ��, ������(����) => �̷��� �Ұ�� sqrt���� ����, ���� ���� ������
        Debug.Log(Mathf.Sqrt(sqrt)); // ��Ʈ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
