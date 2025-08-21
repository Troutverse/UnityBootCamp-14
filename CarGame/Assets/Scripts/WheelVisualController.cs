using UnityEngine;

public class WheelVisualController : MonoBehaviour
{
    public WheelCollider WheelColliders;

    private Transform WheelTransform;

    private void Start()
    {
        WheelTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        WheelColliders.GetWorldPose(out Vector3 pos, out Quaternion rot);
        WheelTransform.position = pos;
        WheelTransform.rotation = rot;  
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
