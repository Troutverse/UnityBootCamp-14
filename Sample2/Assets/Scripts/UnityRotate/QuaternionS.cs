using UnityEngine;
// ���ʹϿ� ��� ����
// Quaternion.identity = ȸ�� ����
// .Euler(x,y,z) = ���Ϸ� �� => ���ʹϿ� ��ȯ
// .AngleAxis(angle, axis) Ư�� �� ������ ȸ��
// .LookRotation(forward, upward(defalt : Vector3.up); �ش� ���� ������ �ٶ󺸴� ȸ�� ���¿� ���� return

// forward : ȸ�� ��ų ���� (Vector3)
// upward : ������ �ٶ�� ���� ���� �� �κ��� ���� �⺻ ���� up���� ���� �Ǿ� �־ Ư���� ��� �ƴϸ� �ǵ帱 �� ����

// ȸ�� �� ����
// transform.rotation = Quaternion.Euler(x,y,z) // ���� ������Ʈ�� ȸ�� ���� �����մϴ�.

// ȸ���� ���� ����
// Quaternion.Slerp(from, to, t)  : ���� ���� ����
// Quaternion.lerp(from, to, t)   : ���� ����
// Quaternion.RotateTowards(from, to, maxDegree) : ���� ���� ��ŭ ���������� ȸ���� ó�� �մϴ�.

// transform.LookAt() vs Quaternion.LookRotation()
// �Ѵ� Ư�� ������ �����ϴ� �ڵ�
// 1. LookAt : �߰� ȸ�� �����̳� ��� ��ư�, �������� ���� �������� transform.rotation�� �ڵ����� �������ִ� ���
// ���ο��� Quaternion.LookRotation�� ����ϴ� ���
// => �� �ٶ�� �� ���� �־�
// 2. �ڿ��� : ȸ�� ���� ����ϰ� �������� ������ ���� �ʴ´�.
// => ����� �� �߰����� �۾����� ��� ó���� 
public class QuaternionS : MonoBehaviour
{
    void Start()
    {    
    }
    void Update()
    {       
    }
}
