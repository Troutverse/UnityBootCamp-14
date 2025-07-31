using UnityEngine;
// Attribute : [AddComponentMenu("")] ó�� Ŭ������ �Լ�, ���� �տ� �ٴ� [] ���� Attribute(�Ӽ�)
// �����Ϳ� ���� Ȯ���̳� ����� ���� �� ���ۿ��� �����Ǵ� ��ɵ�
// ��� ���� : ����ڰ� �����͸� �� ����������, ���������� ����ϱ� ���ؼ�

// 1. AddCompentMenu("�׷��̸�/����̸�")
// Editor�� Componet�� �޴��� �߰��ϴ� ���
// �׷��� ���� ��� �׷��� ����Ǹ�, �ƴ� ��쿡�� ��ɸ� �����

[AddComponentMenu("Sample/AddComponentMenu")]
public class Menu : MonoBehaviour
{
    //[ContextMenuItem("������� ǥ���� �̸�", "�Լ��� �̸�")]
    //message�� ������� MessageReset ����� �����Ϳ��� ��� ����
    [ContextMenuItem("MessageReset", "MessageReset")]
    public string message = "";
    public void MessageReset()
    {
        message = "";
    }

    [ContextMenu("Calling Warning Message")]
    public void MenuAttribute()
    {
        Debug.Log("Warning");
    }
}