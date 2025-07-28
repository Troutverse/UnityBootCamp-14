using UnityEngine;

public class CameraController : MonoBehaviour
{
    // CLASS �ȿ� �������� �ʵ��� ��
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    //Update() ���� ó���� �κ��� ��ó���� �Ŀ� ȣ��Ǵ� ��ġ, ī�޶� �۾����� �ַ� ���
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
