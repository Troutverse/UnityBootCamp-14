using UnityEngine;
using System;

// Custom EventArgs Class
public class DamageEventArgs : EventArgs
{
    // ������ ���� ���� ���� (������Ƽ�� �۾�, Get ��ɸ� �ַ� Ȱ��ȭ)
    public int Value { get; }
    public string EventName { get; }

    public DamageEventArgs(int value, string eventName)
    {
        Value = value;
        EventName = eventName;
    }
}

public class EventSample4 : MonoBehaviour
{
    public event EventHandler<DamageEventArgs> OnDamage;

    public void TakeDamage(int value, string eventName)
    {
        OnDamage?.Invoke(this, new DamageEventArgs(value, eventName));
        Debug.Log($"{eventName} {value} Damage Get");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(UnityEngine.Random.Range(10, 200), "Anemy Attack");
        }
    }
}
