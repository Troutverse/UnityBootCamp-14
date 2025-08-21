using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform Target;
    public float DistanceFromTarget = 10.0f;
    public float LookAtYOffset = 2f;
    public float RotationSpeed = 5.0f; 
    public float VerticalRotationMax = 89f; 
    public float VerticalRotationMin = -89f;

    private float MouseX = 0f;
    private float MouseY = 0f;

    void LateUpdate()
    {
        MouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        MouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;

        MouseY = Mathf.Clamp(MouseY, VerticalRotationMin, VerticalRotationMax);

        Quaternion Rotation = Quaternion.Euler(MouseY, MouseX, 0);

        Vector3 DesiredPosition = Target.position - (Rotation * Vector3.forward * DistanceFromTarget);

        transform.position = DesiredPosition;

        Vector3 LookAtPoint = Target.position + new Vector3(0, LookAtYOffset, 0);
        transform.LookAt(LookAtPoint);
    }
}