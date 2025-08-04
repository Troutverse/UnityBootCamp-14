using UnityEngine;
// 1. �������� ���� ����Ѵ�.
// 2. ������ ������Ʈ�� ���� ������ ���ο��� ������.
// 3. ���� �Ŀ� �ı��� ���� �����̸� ������ �ִ�.

// �ش� ��ũ��Ʈ�� ���� ������Ʈ�� �����ϸ�, ������ �����ϰ� ���� �ð� �� �ı��ϵ��� ó��
// �ʰ�) �������� ��ϵǾ� ���� �� �ش� �۾� ����, �ƴҰ�� ��� �޼���

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab;
    private GameObject spawned;
    public float delay = 0.3f;
    void Start()
    {
        if (prefab != null)
        {
            spawned = Instantiate(prefab);
            // �ش� �������� ��ġ�� ȸ�� ���� ���� ��.
            // prefab, transform.position, Quaternion.identity
            // -> �ش� �������� �����ϰ� ��ġ�� ȸ�� ���� ������� ������Ʈ�� ��ġ�� ȸ�� ���� �����մϴ�.
            spawned.name = "������ ������Ʈ";

            Destroy(spawned, delay);
        }
        else
        {
            Debug.Log("Prefabs ����");
        }
    }
}
