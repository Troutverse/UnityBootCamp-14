using UnityEngine;
using System;

public class ActionfuncExample : MonoBehaviour
{
    // Action<T>는 최대 16개의 매개변수를 받을 수 있다.
    // 반환 값은 없다 (void)
    // => 전달이 목적이며, 결과는 받지 않는다.

    public Action<int> myAction;
    public Action<int, string> myAction2;

    public Func<bool> func;
    public Func<int, string> func2; // 맨 끝에 있는 값이 리턴 값 bool, string

    bool Attackable()
    {    
        int rand = UnityEngine.Random.Range(0, 1);
        return false;
    }

    void Start()
    {
        myAction += Rage;
        myAction2 += Heal;
    }
    void Rage(int value)
    {
        Debug.Log($"Rage {value} up");
    }
    void Heal(int value, string character)
    {
        Debug.Log($"Heal {character} about {value}");
    }
}
