using System;
using UnityEngine;


public enum TYPE // Unity에서 표현할 수 없는 형식
{
    불,물,풀
}
[Flags] // 여러개를 선택하는 기능 (Flag)
// 값을 2의 제곱 수로 표현함 >> 뭔가 이상함, 첫번째 두번째꺼 하면 세번째는 그걸 합친거 이런식으로 나옴 왜 이따구로 만들었는지 아직은 노 이해, 그래서 편의상 비트연산으로 함.
public enum TYPE2
{
    독 = 1 << 0, 
    고스트 = 1 << 1, 
    드래곤 = 1 << 2,
    얼음
}


public class Variable : MonoBehaviour
{
    public int Integer;
    public float Float;
    public string Sentence;
    public TYPE type;
    public bool isDead;
    public TYPE2 type2;
}
