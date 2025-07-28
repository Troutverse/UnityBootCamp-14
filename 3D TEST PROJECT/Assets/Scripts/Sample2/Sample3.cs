using UnityEngine;

// 유니티에서 제공되는 클래스 사용해보기

// Class Transform
// 유니티 에디터에서 게임 오브젝트를 생성할 때 모든 게임 오브젝트에 기본적으로 부여되는 컴포넌트를 의미한다.
// 해당 오브젝트 위치(Position), 회전(Rotation), 크기(Scale)에 대한 정보를 가지고 있다.
// 컴포넌트의 기능을 호출하는 GetComponent<T>를 사용하지 않고 바로 사용 가능하다.
// 제공해주는 속성 => transform. position(x,y,z는 Float), rotation(Quaternion 형태 x,y,z,w 축), forward, up, right, eulerAngles(현재 오브젝트의 회전 정보를 의미한다, Vector3)
// 제공해주는 문법 => transform. LookAt(Transform target), Rotate(Vector3 eulerAngles, 각도 기준 회전), Translate(Vector3 translation, 주어진 값만큼 이동)

public class Sample3 : MonoBehaviour
{
    //transform을 이용한 오브젝트의 컴포넌트 접근
    public GameObject go;
    

    void Start()
    {
        
        Debug.Log(go.transform.GetComponent<Sample4>().value);
    }

    void Update()
    {
        
    }
}
