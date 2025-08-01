using UnityEngine;

public class Thr : MonoBehaviour
{
    // 카메라가 바라볼 대상(플레이어)
    public Transform target;
    // 마우스 회전 속도
    public float mouseSensitivity = 200.0f;
    // 카메라의 회전 제한 (위, 아래)
    public float minY = -30.0f;
    public float maxY = 60.0f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        // 커서를 화면 중앙에 고정하고 숨깁니다.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        // 플레이어 캐릭터가 움직인 후에 카메라를 이동시킵니다.
        // LateUpdate()를 사용해야 카메라가 떨리지 않습니다.

        // 마우스 입력 받기
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationY += mouseX;

        // 카메라의 상하 회전 범위를 제한합니다.
        rotationX = Mathf.Clamp(rotationX, minY, maxY);

        // 카메라 피벗(현재 스크립트가 붙은 오브젝트)을 회전시킵니다.
        // 상하 회전은 X축, 좌우 회전은 Y축
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);

        // 카메라 피벗의 위치를 플레이어 위치로 이동시킵니다.
        transform.position = target.position;
    }
}
