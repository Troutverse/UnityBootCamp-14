using System;
using UnityEngine;


public enum TYPE // Unity���� ǥ���� �� ���� ����
{
    ��,��,Ǯ
}
[Flags] // �������� �����ϴ� ��� (Flag)
// ���� 2�� ���� ���� ǥ���� >> ���� �̻���, ù��° �ι�°�� �ϸ� ����°�� �װ� ��ģ�� �̷������� ���� �� �̵����� ��������� ������ �� ����, �׷��� ���ǻ� ��Ʈ�������� ��.
public enum TYPE2
{
    �� = 1 << 0, 
    ��Ʈ = 1 << 1, 
    �巡�� = 1 << 2,
    ����
}


public class Variable : MonoBehaviour
{
    public int Integer;
    public float Float;
    public string Sentence;
    public TYPE type;
    public bool isDead;
    public TYPE2 type2;
}
