using System;
using UnityEngine;
// C# Event
// Ŭ��, ��ġ�� ���� ������ ó���ϴ� �ϳ��� �ý���

// ������(Publisher)
// ������� �ൿ�� ��ٸ��ٰ� �����ڿ��� �˷��ִ� ������ �����մϴ�

// ������(Subscribers)
// �̺�Ʈ �����ڿ� ���� ������ ���� ������� �ൿ�� ���� �޾Ƽ� �����ϴ� ������ ����

// �������� ��� �������� �ൿ ��ü�� �����ڰ� �˾ƾ��� �ʿ�� ���� ����
// �������� ��� ���к��ϰ� ������ ��� ���� �����ڵ��� ����� ����� �� ����

// Event ����� ���ؼ� System ���ӽ����̽��� ����ؾ� �Ѵ�


public class EventSample : MonoBehaviour
{
    public EventHandler OnSpaceEnter;
    // ������ �̸��� ���� => On + ���� / ������ �����

    // C#���� �������ִ� delegate Ÿ��
    // EventHandler�� ��� ��ġ�� Ŭ�� ���� �̺�Ʈ�� �����ϴ� �뵵
    // �Ű�����
    // Object sender <- object Ÿ���� �����͸� ���޹��� �� ������, �̺�Ʈ�� �߻���ų ����� �ǹ�

    // EventArgs e <- �̺�Ʈ�� ���õ� �����͸� ��� �ִ� ��ü�� �ǹ��Ѵ�
    // �ش� ���� EventArgs �Ǵ� �ش� �ڽ� Ŭ������ �� �� �ִ�

    private void Start()
    {
        OnSpaceEnter += Debug_OnSpaceEnter;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnSpaceEnter != null)
        {
            OnSpaceEnter(this, EventArgs.Empty);
            // EventArgs.Empty : �̺�Ʈ ���࿡ �־� Ư���� �߰��Ǵ� �����Ͱ� ����
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            // �޼ҵ�, �Ӽ�(Property), �̺�Ʈ ���� ȣ�� �ÿ� ���
            // ���۷��� ������ Ÿ�� �Ǵ� nullable ��ü�� ������� ���
        }
    }
    
    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow>Enter</color>");
    }
}
