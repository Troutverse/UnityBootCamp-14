using UnityEngine;
// ��ֹ��� 4���� ����
// -5 �̸� ��ֹ� ����
// ���� �ӵ��� ���ϸ� ����
// ���Ϲ��� �÷��̾� ��ǥ�� ���� ���̸� ����ϰ�, �浹 ������ ����ؼ� ó���Ѵ� (Rigidbody, Collider, Trigger X)
public class ObjectController : MonoBehaviour
{
    public GameObject player;
    public float score;
    void Start()
    {
        player = GameObject.Find("mini simple skeleton demo");
        
    }

    
    void Update()
    {
        
        transform.Translate(0, -1.0f*Time.deltaTime, 0);
        if (transform.position.y < -7)
        {
           Destroy(gameObject); // Object destroy
        }

        // Collider ���� ����
        // ���� ���� Collide ���� logic use
        Vector3 v1 = transform.position;
        Vector3 v2 = player.transform.position;

        Vector3 dir = v1 - v2;
        float d = dir.magnitude; //������ ũ�� �Ǵ� ���̸� �ǹ��Ѵ�. (�� �� ������ ���̸� ����Ҷ� ����Ѵ� => sqrt (x*x + y*y + z*z)
        float obj_r1 = 0.5f;
        float obh_r2 = 1.0f;
        
        if (d < obj_r1 + obh_r2)
        {
            Destroy(gameObject);
        }
    }
}
