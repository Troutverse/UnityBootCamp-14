using UnityEngine;

public class Fire : MonoBehaviour
{
    public BulletPool pool;
    
    public Transform pos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = pool.GetBullet();
            bullet.transform.position = pos.position;
            bullet.transform.rotation = pos.rotation;
        }
    }
}
