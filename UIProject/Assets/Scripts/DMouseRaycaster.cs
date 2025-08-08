using UnityEngine;
using System.Collections;

public class DMouseRaycaster : MonoBehaviour
{
    private Camera cam;
    public float distance = 10.0f;
    public LayerMask layerMask;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay( Input.mousePosition );

            if (Physics.Raycast(ray, out RaycastHit hit, distance, layerMask))
            {
                var trigger = hit.collider.GetComponent<DTrigger>();
                if (trigger != null)
                {
                    trigger.OnDTriggerEnter();
                }
            }
        }
    }
}
