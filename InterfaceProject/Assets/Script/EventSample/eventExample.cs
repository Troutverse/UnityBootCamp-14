using System;
using UnityEngine;

// event : Ư�� ��Ȳ�� �߻����� �� �˸��� ������ ��Ŀ����
// 1. �÷��̾ �׾��� �� �˸� ���� -> �޼ҵ� ȣ��

public class eventExample : MonoBehaviour
{
    public Action onDeath;
    public event Action onStart;

    private void Start()
    {
        // �׼��� +=�� ���� �Լ�(�޼ҵ�)�� �׼ǿ� ����� �� �ִ� (����)
        // �׼� -=�� ���� �Լ�(�޼ҵ�)�� �׼ǿ��� ������ �� �ֽ��ϴ�(����)
        // �׼��� ����� ȣ���ϸ� ��ϵǾ��ִ� �Լ��� ���������� ȣ��˴ϴ�
        onStart += Ready;
        onStart += Fight;

        onDeath += Damaged;
        onDeath += Dead;

        onStart?.Invoke();
        onDeath?.Invoke();

        // �Լ�ó�� ȣ���ϴ� �͵� ����
        onStart();
        onDeath();
    }
    private void Fight()
    {
        Debug.Log("<color=yellow>Fight</color>");
    }
    private void Ready()
    {
        Debug.Log("<color=yellow>Ready</color>");
    }
    private void Dead()
    {
        Debug.Log("<color=blue><b>Dead</b></color>");
    }
    private void Damaged()
    {
        Debug.Log("Damage");
    }
}