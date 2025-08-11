using System;
using UnityEngine;

// 유니티 객체의 필드를 Json으로 변환하기 위해서는 내부적으로 메모리에서
// 데이터를 읽고 쓰는 작업이 가능해야함
// 따라서 Serilalizale 속성을 추가해 해당 정보에 대한 직렬화를 처리해줄 필요가 있다.

// 직렬화는 데이터를 저장하거나 전송하기 위해 연속적인 데이터의 형태로 변형해주는 작업을 의미한다.
public class JSONTester : MonoBehaviour
{
    [Serializable]
    public class Data
    {
        public int hp;
        public int atk;
        public int def;
        public string[] items;
        public Position position;
        public string Quest;
        public bool isDead;
    }

    [Serializable]
    public class Position
    {
        public float x;
        public float y;
    }

    public Data my_data;

    void Start()
    {
        var jsonText = Resources.Load<TextAsset>("data");

        if (jsonText != null)
        {
            Debug.Log("Json is Null");
            return;
        }

        my_data = JsonUtility.FromJson<Data>(jsonText.text);
        Debug.Log(my_data.hp);
        Debug.Log(my_data.atk);
        Debug.Log(my_data.Quest);
        Debug.Log(my_data.position);
    }
}
