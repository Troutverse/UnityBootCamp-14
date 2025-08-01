using UnityEngine;
// ī�޶� �������� ���콺 Ŭ�� ��ġ�� ����ĳ��Ʈ ó��
public class CameraRayCastSample : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Ray ray = new Ray(��ġ, ����);
            // ī�޶󿡼� ����� ��θ� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Your is Yellow");
                hit.collider.GetComponent<Renderer>().material.color = Color.yellow;

                var hitObject = hit.collider.gameObject;
                hitObject.layer = LayerMask.NameToLayer("Yellow"); // ������ -1 ��
            }   
        }
    }
}
