using UnityEngine;

public class Sample2 : MonoBehaviour
{
    public Sample1 sample1;
    private void Awake()
    {
        sample1 = GameObject.FindWithTag("s1").GetComponent<Sample1>();
        // 1. GameObject.FindWithTag("태그")
        // 씬에서 해당 태그를 가지고 있는 오브젝트를 검색하는 기능
        // => 이값은 gameobject 이다

        // 2. GameObject.GetComponent<t>
        // 게임 오브젝트는 GetComponent<T> 를 통해 T에 컴포넌트의 유형을 작성해주면
        // 해당 게임오브젝트가 컴포넌트로 가지고 있는 값을 가지고 온다.
        // 이기능을 통해 받아오는 값 => T
        Debug.Log(sample1.cc.message);
    }
}
