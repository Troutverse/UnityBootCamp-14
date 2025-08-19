using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float Min = 1, Max = 5;

    float CurrentTime;
    public float CreateTime = 1.0f;
    public GameObject EnemyFactory;
    public GameObject SpawnArea;

    private void Update()
    {
        CurrentTime += Time.deltaTime;

        if (CurrentTime >= CreateTime)
        {
            var Enemy = Instantiate(EnemyFactory, SpawnArea.transform.position, Quaternion.identity);
            CurrentTime = 0;
            CreateTime = Random.Range(Min, Max);
        }
    }
}