using A;
using UnityEngine;

namespace A
{
    class Item
    {
        public int id=0;
    }
}

namespace B
{
    class Item 
    {
        public int id=0;
    }

}
public class BasicScript : MonoBehaviour // https://docs.unity3d.com/kr/2021.1/Manual/class-MonoBehaviour.html
{
    // �̺�Ʈ �� https://docs.unity3d.com/kr/2019.4/Manual/ExecutionOrder.html
    void Start()
    {
        Item item = new Item(); //using item 
        B.Item items = new B.Item(); // �̷��� ���� ���� => namespace ����� 1, 2 ���� using�� ���ٰ� ��
    }

    void Update()
    {
        
    }
}
