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
            // ForceMode.Impulse : �������� ��
            // ForceMOde.Force : �������� ��
        }
    }
    // PlayerMovement.cs
    void FixedUpdate()
    {
        // Ű���� �Է�
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        // 1. ī�޶��� forward, right ���͸� �����ɴϴ�.
        // ī�޶� �ٶ󺸴� ������ �������� �����̰� �˴ϴ�.
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 cameraRight = Camera.main.transform.right;

        // 2. �߿�: ī�޶��� forward ���ʹ� ������ ���� �� �����Ƿ�,
        // y���� �����ϰ� �����ϰ� ����ϴ�. (�÷��̾ ���߿� �ߴ� ���� ����)
        cameraForward.y = 0;
        cameraRight.y = 0;
        cameraForward.Normalize();
        cameraRight.Normalize();

        // 3. ī�޶� ������ �������� �̵��� ������ ����մϴ�.
        Vector3 direction = (cameraForward * z) + (cameraRight * x);

        // 4. ���� y�� �ӵ��� �����ϸ鼭 ���ο� �̵� �ӵ��� �����մϴ�.
        Vector3 newVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);

        // 5. Rigidbody�� �ӵ��� �����մϴ�.
        rb.linearVelocity = newVelocity;
    }
    private bool IsGrounded()
    {
        // �Ʒ� �������� 1��ŭ Ray�� ���� ���̾� üũ
        return Physics.Raycast(transform.position, Vector3.down, 1.0f, Ground);
    }
}
