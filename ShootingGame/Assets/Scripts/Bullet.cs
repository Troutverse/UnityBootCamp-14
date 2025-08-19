using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 5.0f;

    void Update()
    { 
        Vector3 dir = Vector3.up;

        transform.position += dir * Speed * Time.deltaTime;
    }
}
