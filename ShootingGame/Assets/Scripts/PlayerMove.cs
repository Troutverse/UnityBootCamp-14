using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 5;
    float h, v;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);

        transform.position += dir * Speed * Time.deltaTime;
    }
}