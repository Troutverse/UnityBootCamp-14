using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject BulletFactory;
    public GameObject FirePosition;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = Instantiate(BulletFactory, FirePosition.transform.position, Quaternion.identity);
        }
    }
}
