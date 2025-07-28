using UnityEngine;

// Time Check && Spawn a obstacle which that time
public class ObjectSpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;
    float spawnTime = 2.0f;
    float t = 0.0f;

    void Start()
    { 
        
    }

    void Update()
    {
        t += Time.deltaTime;
        if (t > spawnTime)
        {
            GameObject go = Instantiate(ObjectPrefab);
            t = 0.0f;
            int rand = Random.Range(-14, 14);
            go.transform.position = new Vector3(rand, 5, 0);
        }
    }
}
