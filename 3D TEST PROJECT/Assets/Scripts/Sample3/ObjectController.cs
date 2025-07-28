using UnityEngine;
// 장애물은 4에서 시작
// -5 이면 장애물 제거
// 같은 속도로 낙하를 진행
// 낙하물과 플레이어 좌표를 통해 길이를 계산하고, 충돌 판정을 계산해서 처리한다 (Rigidbody, Collider, Trigger X)
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

        // Collider 판정 원리
        // 원에 의한 Collide 판정 logic use
        Vector3 v1 = transform.position;
        Vector3 v2 = player.transform.position;

        Vector3 dir = v1 - v2;
        float d = dir.magnitude; //벡터의 크기 또는 길이를 의미한다. (두 점 사이의 길이를 계산할때 사용한다 => sqrt (x*x + y*y + z*z)
        float obj_r1 = 0.5f;
        float obh_r2 = 1.0f;
        
        if (d < obj_r1 + obh_r2)
        {
            Destroy(gameObject);
        }
    }
}
