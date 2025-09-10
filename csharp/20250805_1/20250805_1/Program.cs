using System;

struct Knight
{
    public int hp;
}

class Mage
{
    public int hp;
}

enum Test
{
    A,
    B
}

class Program
{
    static void Main(string[] args)
    {
        Knight k1 = new Knight();
        k1.hp = 100;
        Knight k2 = k1;
        k2.hp = 200;

        Mage m1 = new Mage { hp = 100 };
        Mage m2 = m1;
        m2.hp = 300;

        Console.WriteLine($"k1.hp: {k1.hp}"); //100
        Console.WriteLine($"k2.hp: {k2.hp}"); //200

        Console.WriteLine($"m1.hp: {m1.hp}"); //300 
        Console.WriteLine($"m2.hp: {m2.hp}"); //300


        void AddTen(int x)
        {
            x += 10;
        }

        int a = 5;
        AddTen(a);
        Console.WriteLine(a);
        // ^ 위에 있는건 값 전달 (값 복사)
        // 1. 인트 a 라는 변수 만들어서 5라는 값 대입
        // 2. AddTen 함수 호출하며 a에 있는 "값 : 5" 를 !!!복사해서!!! 전달
        // 3. AddTen 함수는 !!!복사한 값 5!!!! 를 x 라고 호칭함
        // 4. x 라고 칭하는 5값에 10을 더함
        // 5. 15라는 값이 완성되지만 함수가 종료되며 !!!복사한 값!!! 은 사라짐
        // 6. 1. 에 있는 인트 a는 아무도 건들지 않았으니 그냥 5값 그대로 출력됨

        void AddTen2(ref int x2)
        {
            x2 += 10;
        }

        int a2 = 5;
        AddTen2(ref a2);
        Console.WriteLine(a2);
        // ^ 위에 있는건 참조 전달 (주소 공유)
        // 1. 인트 a 라는 변수 만들어서 5라는 값 대입
        // 2. AddTen2 함수 호출하며 !!!!!a 변수 그자체를!!!!!! 전달
        // 3. AddTen2 함수는 !!!변수 a 그자체!!!! 를 x 라고 호칭함
        // 4. x 라고 칭하는 a에 10을 더함
        // 5. a 의 5와 10 이라는 값이 더해져서 15 완성,
        // 6. !!!!!!a 에 15의 값을 대입!!!!!
        // 7. 1. 에 있는 인트 a를 AddTen2 이 건드렸으니 15 값이 출력됨

        // 값 형식
        // enum 열거형 = 값형식 
    }
}

// | 구분           | 뜻                                   | 예시 비유                                      |
// | ---------      | ------------------------------------ | ---------------------------------------------  |
// | 값 전달 * *  | 값을 "복사해서" 줌 → 원본은 안 바뀜 | “사본을 줌” (복사한 종이 한 장 줌)           |
// | 참조 전달**  | 주소(참조)를 줌 → 원본도 같이 바뀜  | “원본을 줌” (원본 문서를 줘서 거기다 낙서함) |