using UnityEngine;
using System.Collections;

public class IEnumeratorSample : MonoBehaviour
{
    class CustomCollection : IEnumerable
    {
        int[] numbers = { 6, 7, 8, 9, 10 };

        //GetEnumerator�� ���� ��ȸ ������ �����͸� IEnumerator ������ ��ü�� ��ȯ�մϴ�.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers[i];
            }
        }
    }

    int[] numbers = { 1, 2, 3, 4, 5 };

    void Start()
    {
        // numbers��� �迭�� ��ȸ�� �� �ִ� IEnumerator ������ �����ͷ� ��ȯ.
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }
        CustomCollection collection = new CustomCollection();

        foreach (int i in collection) 
        {
            Debug.Log(i);
        }

        foreach (var message in GetMessage())
        {
            Debug.Log(message);
        }
    }
    // yield�� C#���� �� ���� �ϳ� �� ���� �ѱ��, �޼ҵ尡 �Ͻ����� �Ǹ� �ļ� ������ ���������� ��ȯ�ϰ� �ȴ�.
    // �ݺ����� �۾�, �������� ������ ó���� ���˴ϴ�.
    // yield�� yield return, break �� ���
    // return�� �޼ҵ尡 ���� ��ȯ�ϸ鼭 �� �������� �޼ҵ� ������ �Ͻ� ���� ��Ų��
    // ȣ���ڰ� ���� ���� �䱸�� ������ ����մϴ�.
    // break�� �޼ҵ忡���� �ݺ��� �����ϴ� �ڵ�
    // return�� ����ϴ� �޼ҵ�� IEnumerable �Ǵ� IEnumerator �������̽��� �����ϰ� �ȴ�.
    // �÷����� �ڵ����� ��ȸ�ϴ� foreach�� ���� ��� �ȴ�.

    // ���� : ���� �ʿ�� �� ������ ����� �̷�� ���(�޸� ȿ���� ����, ū �����͸� ó���� �� ������ ŭ)
    // --> ��� �����͸� �����ϴ°� �ƴ� �ʿ��� �κи� ó���� �� �ְ� �Ǳ� ����

    // IEnumerable : �ݺ� ������ �÷����� ��Ÿ���� �������̽�, �� ����� ������ Ŭ������ �ݺ��� �� �ִ� ��ü�� �ȴ�.
    //               foreach ��� �������� Ž���� ���� �� �� �ְ� �ȴ�. �ش� �������̽� �����ϱ� ���ؼ���
    //               GetEnumerator() �޼ҵ带 �����ϰ�, ����ڰ� �����ؾ� �Ѵ�.

    // IEnumerator : �ݺ��� �����ϴ� �������̽�, �÷��ǿ��� �ϳ��� �׸���� ��ȯ�ϰ�, �� ���¸� �����ϴ� ������ �����մϴ�.
    //               MoveNext()�� ���ؼ� ���� �� ���� Current�� ���ؼ� ���� �� Ȯ��, Reset()�� ���ؼ� ���� ��� ó��
    static IEnumerable GetMessage()
    {
        Debug.Log("����");
        yield return "1";
        // 1 �� �������� �ٽ� �ش� �޼ҵ�� ���ƿ�
        Debug.Log("excape and return");
        yield return "2";
        Debug.Log("excape and return2");
        yield break; // ��ȯ �۾� ����
        // -- Unreachable Code -- (���� �Ұ�)
        // Debug.Log("excape and return3");
        // yield return "4";
    }
}
