using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider RearLeftWheel;
    public WheelCollider RearRightWheel;

    public Transform CenterOfMass;
    private Rigidbody CarRigidbody;

    public float motorForce = 700f;
    public float steeringForce = 30f;
    public float brakeForce = 300f;

    private void Start()
    {
        CarRigidbody = GetComponent<Rigidbody>();
        if (CenterOfMass != null)
        {
            CarRigidbody.centerOfMass = CenterOfMass.localPosition;
        }
    }

    void FixedUpdate()
    {
        float motor = Input.GetAxis("Vertical") * motorForce;
        float steering = Input.GetAxis("Horizontal") * steeringForce;
        float brake = 0f;

        RearLeftWheel.motorTorque = motor;
        RearRightWheel.motorTorque = motor;

        FrontLeftWheel.steerAngle = steering;
        FrontRightWheel.steerAngle = steering;

        if (Input.GetKey(KeyCode.Space))
        {
            brake = brakeForce;
        }

        FrontLeftWheel.brakeTorque = brake;
        FrontRightWheel.brakeTorque = brake;
        RearLeftWheel.brakeTorque = brake;
        RearRightWheel.brakeTorque = brake;
    }
}
