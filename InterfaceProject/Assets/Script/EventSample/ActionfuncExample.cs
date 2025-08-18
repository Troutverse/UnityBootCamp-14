using UnityEngine;
using System;

public class ActionfuncExample : MonoBehaviour
{
    // Action<T>�� �ִ� 16���� �Ű������� ���� �� �ִ�.
    // ��ȯ ���� ���� (void)
    // => ������ �����̸�, ����� ���� �ʴ´�.

    public Action<int> myAction;
    public Action<int, string> myAction2;

    public Func<bool> func;
    public Func<int, string> func2; // �� ���� �ִ� ���� ���� �� bool, string

    bool Attackable()
    {    
        int rand = UnityEngine.Random.Range(0, 1);
        return false;
    }

    void Start()
    {
        myAction += Rage;
        myAction2 += Heal;
    }
    void Rage(int value)
    {
        Debug.Log($"Rage {value} up");
    }
    void Heal(int value, string character)
    {
        Debug.Log($"Heal {character} about {value}");
    }
}
