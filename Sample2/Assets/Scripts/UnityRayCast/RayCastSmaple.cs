using UnityEngine;
// RayCast : ���� ��ġ���� Ư�� �������� ���� ������ �� ��
// 1) Ư�� ������Ʈ�� �浹 �������� �����ϴ� �۾� ����
// 2) Ư�� ������Ʈ�� ���� �浹 ������ Ȯ���ϴ� �뵵

public class RayCastSmaple : MonoBehaviour
{
    RaycastHit hit; // �浹 ������

    const float length = 5.0f;
    
    // LayDraw�� �ѹ� ��ü�� ������ ���ΰŴ� ���Ӿƴ�
    // RaycastHit[] hits;
    // hits = Physics.RaycastAll(transform.position, transform.forward, length, layerMask);
    // �״��� for �� ���
    void Update()
    {  
        int ignoreLayer = LayerMask.NameToLayer("Red"); // �浹 ��Ű�� ���� ���� ���̾�
        int layerMask = ~(1 << ignoreLayer); // ��Ʈ ����
        // int ignoreLayer = (1 << LayerMask.NameToLayer("Red")) | (1 << LayerMask.NameToLayer("Red")) �̷��� ����� �� ����


        if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask)) // LayerMask�� int��� ���������鼭 ��Ʈ�̴�
       {
            Debug.Log("Shoot");
            Debug.Log(hit.collider.name);
            hit.collider.gameObject.SetActive(false);
       }
        
        // ������Ʈ ��ġ���� �������� length��ŭ�� ���̿� �ش��ϴ� ����� ������ ��� �ڵ�
        // �ַ� ����ĳ��Ʈ �۾����� ���̰� �Ⱥ��̱� ������ �����ִ� �뵵�� ���
        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
    }
}
