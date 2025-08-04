using UnityEngine;
// 1. 프리팹을 직접 등록한다.
// 2. 생성된 오브젝트에 대한 정보를 내부에서 가진다.
// 3. 생성 후에 파괴에 대한 딜레이를 가지고 있다.

// 해당 스크립트를 가진 오브젝트가 실행하면, 생성을 진해하고 일정 시간 뒤 파괴하도록 처리
// 초건) 프리팹이 등록되어 있을 때 해당 작없 수행, 아닐경우 경고 메세지

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
            // 해당 프리팹의 위치와 회전 값이 생성 됨.
            // prefab, transform.position, Quaternion.identity
            // -> 해당 프리팹을 설정하고 위치와 회전 값의 정보대로 오브젝트의 위치와 회전 값을 설정합니다.
            spawned.name = "생성된 오브젝트";

            Destroy(spawned, delay);
        }
        else
        {
            Debug.Log("Prefabs 없음");
        }
    }
}
