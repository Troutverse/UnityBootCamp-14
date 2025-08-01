using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jp = 10.0f;
    public LayerMask Ground;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jp, ForceMode.Impulse);
            // ForceMode.Impulse : 순간적인 힘
            // ForceMOde.Force : 지속적인 힘
        }
    }
    // PlayerMovement.cs
    void FixedUpdate()
    {
        // 키보드 입력
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        // 1. 카메라의 forward, right 벡터를 가져옵니다.
        // 카메라가 바라보는 방향을 기준으로 움직이게 됩니다.
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 cameraRight = Camera.main.transform.right;

        // 2. 중요: 카메라의 forward 벡터는 기울어져 있을 수 있으므로,
        // y축을 무시하고 평평하게 만듭니다. (플레이어가 공중에 뜨는 것을 방지)
        cameraForward.y = 0;
        cameraRight.y = 0;
        cameraForward.Normalize();
        cameraRight.Normalize();

        // 3. 카메라 방향을 기준으로 이동할 방향을 계산합니다.
        Vector3 direction = (cameraForward * z) + (cameraRight * x);

        // 4. 기존 y축 속도를 유지하면서 새로운 이동 속도를 적용합니다.
        Vector3 newVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);

        // 5. Rigidbody에 속도를 적용합니다.
        rb.linearVelocity = newVelocity;
    }
    private bool IsGrounded()
    {
        // 아래 방향으로 1만큼 Ray를 쏴서 레이어 체크
        return Physics.Raycast(transform.position, Vector3.down, 1.0f, Ground);
    }
}
