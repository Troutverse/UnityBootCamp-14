using System;
using UnityEngine;

// ����Ƽ ��ü�� �ʵ带 Json���� ��ȯ�ϱ� ���ؼ��� ���������� �޸𸮿���
// �����͸� �а� ���� �۾��� �����ؾ���
// ���� Serilalizale �Ӽ��� �߰��� �ش� ������ ���� ����ȭ�� ó������ �ʿ䰡 �ִ�.

// ����ȭ�� �����͸� �����ϰų� �����ϱ� ���� �������� �������� ���·� �������ִ� �۾��� �ǹ��Ѵ�.
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
