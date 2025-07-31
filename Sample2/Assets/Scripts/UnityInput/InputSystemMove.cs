using UnityEngine;
using UnityEngine.InputSystem;

// Player Input 이 있어야 사용 가능함

// 반드시 있어야 하는 컨포먼트 선언, 없으면 자동으로 등록
// 이게 없으면 에디터에서 게임 오브젝트는 해당 컴포넌트를 제거 할 수 없다
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
        Vector3 move = new Vector3(moveInputValue.x, 0, moveInputValue.y); // 좌우 : X , 상하 : Z
        transform.Translate(move * Speed * Time.deltaTime);

    }
}