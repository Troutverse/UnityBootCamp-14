using UnityEngine;
using UnityEngine.Events;
public class UnityEventSample : MonoBehaviour
{
    [Tooltip("�̺�Ʈ ����Ʈ �߰� �� ���� ������Ʈ ���")]
    public UnityEvent action;

    private void Update()
    {
        action.Invoke(); // �׼ǿ� ��ϵ� �Լ��� ����
    }
    public void Move()
    {
        gameObject.transform.Translate(0, 1, 0);
    }
}
