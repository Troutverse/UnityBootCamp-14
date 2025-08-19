using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyType
    {
        Down, Chase
    }

    Vector3 dir;
    public float Speed = 5.0f;
    public EnemyType type;

    public GameObject ExplosionFactory;

    private void Start()
    {
        PatternSetting();
    }

    void Update()
    {
        transform.position += dir * Speed * Time.deltaTime;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(ExplosionFactory, transform.position, Quaternion.identity);
        
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    void PatternSetting()
    {
        int rand = Random.Range(0, 10);
        if (rand < 3)
        {
            type = EnemyType.Chase;
            GameObject target = GameObject.FindGameObjectWithTag("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            type = EnemyType.Down;
            dir = Vector3.down;
        }
    }
}