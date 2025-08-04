using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f; // �Ѿ� �̵� �ӵ� 
    public float life_time = 5.0f; // �Ѿ� �ݳ� �ð�
    public GameObject effect_prefab;

    private BulletPool pool;
    private Coroutine life_coroutine;
   

    // �� ����(Ǯ���� �ش� �� ȣ��)
    public void SetPool(BulletPool pool)
    {
        this.pool = pool;
    }

    // Ȱ��ȭ �ܰ�
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulletReturn());
    }

    // ��Ȱ��ȭ �ܰ�
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
        // �ε��� ����� Enemy �±׸� ������ �ִ� ������Ʈ�� ��� �������� ������. �� ���� ������ ���� �ڵ� �ۼ�
        
        // ����Ʈ ����(��ƼŬ)
        if (effect_prefab != null)
        {
            GameObject effect = Instantiate(effect_prefab, transform.position, Quaternion.identity);

            // ������ ����Ʈ ������Ʈ�� 1�� �ڿ� �ı��մϴ�.
            Destroy(effect, 1.0f);
        }
        ReturnPool();
    }
    void ReturnPool() => pool.Return(gameObject);
}
