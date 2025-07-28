using UnityEngine;

public class CameraController : MonoBehaviour
{
    // CLASS 안에 변수들을 필드라고 함
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    //Update() 에서 처리할 부분을 다처리한 후에 호출되는 위치, 카메라 작업에서 주로 사용
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
