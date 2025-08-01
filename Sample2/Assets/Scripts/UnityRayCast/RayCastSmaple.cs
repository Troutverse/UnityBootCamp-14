using UnityEngine;
// RayCast : 시작 위치에서 특정 방향으로 가상 광선을 쏜 것
// 1) 특정 오브젝트를 충돌 범위에서 제외하는 작업 가능
// 2) 특정 오브젝트에 대한 충돌 판정을 확인하는 용도

public class RayCastSmaple : MonoBehaviour
{
    RaycastHit hit; // 충돌 감지용

    const float length = 5.0f;
    
    // LayDraw는 한번 물체에 닿으면 끝인거다 연속아님
    // RaycastHit[] hits;
    // hits = Physics.RaycastAll(transform.position, transform.forward, length, layerMask);
    // 그다음 for 문 사용
    void Update()
    {  
        int ignoreLayer = LayerMask.NameToLayer("Red"); // 충돌 시키고 싶지 않은 레이어
        int layerMask = ~(1 << ignoreLayer); // 비트 반전
        // int ignoreLayer = (1 << LayerMask.NameToLayer("Red")) | (1 << LayerMask.NameToLayer("Red")) 이렇게 만드는 것 가능


        if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask)) // LayerMask는 int라고 적혀있으면서 비트이다
       {
            Debug.Log("Shoot");
            Debug.Log(hit.collider.name);
            hit.collider.gameObject.SetActive(false);
       }
        
        // 오브젝트 위치에서 정면으로 length만큼의 길이에 해당하는 디버깅 광선을 쏘는 코드
        // 주로 레이캐스트 작업에서 레이가 안보이기 때문에 보여주는 용도로 사용
        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
    }
}
