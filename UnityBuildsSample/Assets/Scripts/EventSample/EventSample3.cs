using UnityEngine;
using UnityEngine.Events;

// C#�� Event�� ������
// 1. �ν����Ϳ��� Ȯ���� ����
// 2. �߰� ��ɵ�

// ����� �� �ִ°�
// 1. C# Delegate
// 2. Unity UnityAction
// 3. C# Func<T>, Action<T>

// ���� � ���� ����ؾ� �ϴ°� ?
// 1. ���� = C# Delegate
// 2. �ܼ�(�ݹ�) = Action OR UnityAction
// 3. UnityInspector = UnityAction
// 4. �̺�Ʈ �ñ״�ó�� �ʿ� = ȣ��Ǵ� ���� ������ �Լ��� ���� ex) void EventHandler(object sender, EventArgs e) = C# �� EventHandler ����
// => �ñ״�ó 1. ��ȯ Ÿ��(void), 2. �Ű�����(object, EventArgs) = Delegate, Func, Action

public class EventSample3 : MonoBehaviour
{
    public UnityEvent OnKButtonEnter;
    public UnityAction OnAction;

    private void Start()
    {
        OnKButtonEnter.AddListener(Sample);
        OnAction += Sample;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            OnKButtonEnter?.Invoke();
            OnAction?.Invoke();
        }
    }
    private void Sample()
    {
        Debug.Log("<color=red>K</color>");
    }
}