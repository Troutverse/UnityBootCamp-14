using UnityEngine;
using System.Collections;

public class CoroutineSample : MonoBehaviour
{
    // ������ Ÿ��
    public GameObject target;
    
    // ��ȭ �ð�
    float duration = 5.0f;

    // �ٲٰ� ���� ��
    public Color color;

    Coroutine coroutine;

    // Start ���� �ڷ�ƾ�� ���� ����Ѵ�.
    void Start()
    {
        // coroutine = StartCoroutine(ChangeColor());
        // StopCoroutine(coroutine), StopCoroutine("ChangeColor")
        // StopAllCoroutines(); ��� �ڷ�ƾ ����
        if (target != null)
        {
            StartCoroutine(ChangeColor());
            // StartCoroutine(�޼ҵ��()) : IEnumerator ������ �޼ҵ带 �ڷ�ƾ���� ����
            // �ڵ� �ۼ� �������� �޼ҵ尡 ������ ������
            // �żҵ� ȣ���� ������ �������� Ȯ�� �Ǳ⿡ ã�� �����ϴ� �ð��� ���ڿ����� ���� ���.
            // StartCoroutine("ChangeColor");
            // "�޼ҵ��" : ���ڿ��� ���� �Ű� ������ ���� �ڷ�ƾ�� ȣ���� ���� �ִ�.
            // ���������� �޼ҵ��� �̸��� ���ڿ��� �����ϰ�, ��Ÿ�ӿ��� ã�Ƽ� �����ϴ� ���(���÷���)
            // Ÿ�� üũ�� ���� ���� �ʾƼ� �߸��� �̸��� ���� ���� �߻�
        }
    }
    IEnumerator ChangeColor()
    {
        var targetRenderer = target.GetComponent<Renderer>();
        if (targetRenderer == null) 
        {
            yield break;
        }

        float time = 0.0f;

        var start = targetRenderer.material.color;
        var end = color;

        // �ݺ� �۾�
        // �ڷ�ƾ ������ �ݺ����� �����ϸ�, yield�� ���� ���������ٰ� �ٽ� ���ƿͼ� �ݺ����� �����ϰ� �ȴ�.
        while (time < duration) // ��ȭ �ð� ��ŭ �۾�
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time, duration) / duration;
            // Mathf.PingPong(a, b) �־��� ���� a�� b ���̿��� �ݺ��Ǵ� ���� �����Ѵ�.(�⺻���� �պ� �)
            // �� 0���� 1 ������ ��ȭ ���� ��� ( ����ȭ �۾��� ������ ���� : Color�� 0���� 1������ ���̱� ���� )

            targetRenderer.material.color = Color.Lerp(start, end, value);
            Debug.Log(targetRenderer.material.color);
            // ���� ���� �ε巯�� ����

            yield return new WaitForSeconds(1.0f);
        }
    }
}