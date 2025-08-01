using UnityEngine;

public class Thr : MonoBehaviour
{
    // ī�޶� �ٶ� ���(�÷��̾�)
    public Transform target;
    // ���콺 ȸ�� �ӵ�
    public float mouseSensitivity = 200.0f;
    // ī�޶��� ȸ�� ���� (��, �Ʒ�)
    public float minY = -30.0f;
    public float maxY = 60.0f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        // Ŀ���� ȭ�� �߾ӿ� �����ϰ� ����ϴ�.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        // �÷��̾� ĳ���Ͱ� ������ �Ŀ� ī�޶� �̵���ŵ�ϴ�.
        // LateUpdate()�� ����ؾ� ī�޶� ������ �ʽ��ϴ�.

        // ���콺 �Է� �ޱ�
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationY += mouseX;

        // ī�޶��� ���� ȸ�� ������ �����մϴ�.
        rotationX = Mathf.Clamp(rotationX, minY, maxY);

        // ī�޶� �ǹ�(���� ��ũ��Ʈ�� ���� ������Ʈ)�� ȸ����ŵ�ϴ�.
        // ���� ȸ���� X��, �¿� ȸ���� Y��
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);

        // ī�޶� �ǹ��� ��ġ�� �÷��̾� ��ġ�� �̵���ŵ�ϴ�.
        transform.position = target.position;
    }
}
