using UnityEngine;

public class VectorTest1 : MonoBehaviour
{
    // ���� ������Ʈ�� Transform�� ���� Vector �� ���ϱ�
    public Transform A_CUBE;
    public Transform B_CUBE;

    void Start()
    {
        Vector3 PosA = A_CUBE.position;
        Vector3 PosB = B_CUBE.position;

        // ����
        Vector3 BTA = PosB - PosA;
        Vector3 ATB = PosA - PosB;

        // �Ÿ�
        float distance = Vector3.Distance(PosA, PosB);

        // ����Ƽ�� Mathf Ŭ������ ������� �ٲٸ�
        Vector3 DIR = PosB - PosA;
        float distance2 = Mathf.Sqrt(DIR.x * DIR.x + DIR.y * DIR.y + DIR.z * DIR.z);
        Debug.Log(distance);
        Debug.Log(distance2);
    }

    void Update()
    {
        
    }
}
