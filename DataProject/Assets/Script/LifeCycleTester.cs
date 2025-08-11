using System.Collections;
using UnityEngine;

// Unity LifeCycle 동작 순서
// Update를 활용해 프레임 별 호출 순서대로 확인

public class LifeCycleTester : MonoBehaviour
{
    private int count_per_frame = 0;
    private void Awake()
    {
        Debug.Log("[Awake] 오브젝트의 생성시 한 번만 실행되는 영역");
    }
    private void OnEnable()
    {
        Debug.Log("[OnEnable] 오브젝트의 활성화시 실행되는 영역");
    }
    private void Start()
    {
        Debug.Log("[Start] 첫 프레임 시작 전에 호출되는 영역");
        StartCoroutine(CustomCoroutine());
    }
    private void FixedUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}] [FixedUpdate] 물리에 대한 업데이트가 진행되는 영역");
    }
    void Update()
    {
        count_per_frame++;
        Debug.Log($"[CPF : {count_per_frame}] [Update] 게임 로직에 대한 호출이 진행되는 영역");
        
        if (count_per_frame == 3)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 1] 오브젝트 비활성화 작업을 진행합니다");
            gameObject.SetActive(false);
        }
        if (count_per_frame == 6)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 2] 오브젝트 활성화 작업을 진행합니다");
            gameObject.SetActive(true);
        }
        if (count_per_frame == 9)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 3] 오브젝트 파괴 작업을 진행합니다");
            Destroy(gameObject);
        }
    }
    private void LateUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}] [LateUpdate] 물리 연산, 로직 이후 후처리");
    }
    // yield에 의해 대기 후 싸이클로 돌아오는 과정이 존재, 보통 Update의 틈새에 맞춰져 실행
    IEnumerator CustomCoroutine()
    {
        Debug.Log($"[CPF : {count_per_frame}] [Coroutine] 코루틴에 대한 시작 : StartCoroutine");
        yield return null;
        Debug.Log("[Coroutine] 1 프레임 후 다시 실행");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("[Seconds] 1 초후 다시 실행");
        yield return new WaitForFixedUpdate();
        Debug.Log("[FixedUpdate] FixedUpdate가 끝나면 다시 실행");
        yield return new WaitForEndOfFrame();
        Debug.Log("[End of Frame] 프레임의 끝이 지나면 다시 실행");
    }
    private void OnDisable()
    {
        Debug.Log("[OnDisable] 오브젝트 비활성화");
    }
    private void OnDestroy()
    {
        Debug.Log("[OnDestroy] 오브젝트 파괴");
        // gameObject.SetActive(true OR false) => 진행 되도 의미가 없는 영역 = 불가능 OR 무의미
        // 자기 자신에 대한 복구 작업은 불가능, 계속 파괴함
        // 새로운 게임 오브젝트를 생성하는 것은 가능
    }
}