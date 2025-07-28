using UnityEngine;

// ����Ƽ���� �����Ǵ� Ŭ���� ����غ���

// Class Transform
// ����Ƽ �����Ϳ��� ���� ������Ʈ�� ������ �� ��� ���� ������Ʈ�� �⺻������ �ο��Ǵ� ������Ʈ�� �ǹ��Ѵ�.
// �ش� ������Ʈ ��ġ(Position), ȸ��(Rotation), ũ��(Scale)�� ���� ������ ������ �ִ�.
// ������Ʈ�� ����� ȣ���ϴ� GetComponent<T>�� ������� �ʰ� �ٷ� ��� �����ϴ�.
// �������ִ� �Ӽ� => transform. position(x,y,z�� Float), rotation(Quaternion ���� x,y,z,w ��), forward, up, right, eulerAngles(���� ������Ʈ�� ȸ�� ������ �ǹ��Ѵ�, Vector3)
// �������ִ� ���� => transform. LookAt(Transform target), Rotate(Vector3 eulerAngles, ���� ���� ȸ��), Translate(Vector3 translation, �־��� ����ŭ �̵�)

public class Sample3 : MonoBehaviour
{
    //transform�� �̿��� ������Ʈ�� ������Ʈ ����
    public GameObject go;
    

    void Start()
    {
        
        Debug.Log(go.transform.GetComponent<Sample4>().value);
    }

    void Update()
    {
        
    }
}
