using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f; // 총알 이동 속도 
    public float life_time = 5.0f; // 총알 반납 시간
    public GameObject effect_prefab;

    private BulletPool pool;
    private Coroutine life_coroutine;
   

    // 출 설정(풀에서 해당 값 호출)
    public void SetPool(BulletPool pool)
    {
        this.pool = pool;
    }

    // 활성화 단계
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulletReturn());
    }

    // 비활성화 단계
    private void OnDisable()
    {
        if (life_coroutine != null) 
        { 
            StopCoroutine(life_coroutine); 
        }
    }
    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    IEnumerator BulletReturn()
    {
        yield return new WaitForSeconds(life_time);
        ReturnPool();
    }

    private void OnTriggerEnter(Collider other)
    {
        // 부딪힌 대상이 Enemy 태그를 가지고 있는 오브젝트일 경우 데미지를 입힌다. 와 같은 데미지 관련 코드 작성
        
        // 이펙트 연출(파티클)
        if (effect_prefab != null)
        {
            GameObject effect = Instantiate(effect_prefab, transform.position, Quaternion.identity);

            // 생성된 이펙트 오브젝트를 1초 뒤에 파괴합니다.
            Destroy(effect, 1.0f);
        }
        ReturnPool();
    }
    void ReturnPool() => pool.Return(gameObject);
}
