using UnityEngine;
using UnityEngine.InputSystem;

// Player Input �� �־�� ��� ������

// �ݵ�� �־�� �ϴ� ������Ʈ ����, ������ �ڵ����� ���
// �̰� ������ �����Ϳ��� ���� ������Ʈ�� �ش� ������Ʈ�� ���� �� �� ����
[RequireComponent(typeof(PlayerInput))]
public class InputSystemMove : MonoBehaviour
{

    // Action Map : Sample
    // Action     : Move
    // Type       : Value
    // Compos     : Vector2
    // Binding    : 2D Vector(w,a,s,d)
    private float Speed = 3.0f;
    private Vector2 moveInputValue;
    void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
        Debug.Log("w");
    }
    void Update()
    {
        Vector3 move = new Vector3(moveInputValue.x, 0, moveInputValue.y); // �¿� : X , ���� : Z
        transform.Translate(move * Speed * Time.deltaTime);

    }
}