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
    // 이벤트 들 https://docs.unity3d.com/kr/2019.4/Manual/ExecutionOrder.html
    void Start()
    {
        Item item = new Item(); //using item 
        B.Item items = new B.Item(); // 이렇게 참조 가능 => namespace 사용방법 1, 2 보통 using을 쓴다고 함
    }

    void Update()
    {
        
    }
}
