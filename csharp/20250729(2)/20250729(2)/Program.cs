namespace _20250729_2_
{
    internal class Program
    {  

        // out : 다중 반환할때 사용
        static void ss(out int i) // ref를 사용할 경우는 초기화를 해야 하지만 Out 은 필요없음
                                  //                    ref vs out
                                  // 주소 전달 방식       0      0
                                  // 함수 안에서 읽기     0       X
                                  // 호출전 초기화        0      X   
                                  // 함수 내에서 값 쓰기   X      0
        {
            i = 1;
        }
        static void Swap(ref int a, ref int b)
        {
            a = a ^ b; b = b ^ a; a = a ^ b;
        }
        static void Main(string[] args)
        {
            int a = 99, b = 1;
            Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }
        // 함수가 실행될때 각각의 함수는 스택 메모리에 등재 서로 간섭 X, 함수가 종료 되면 메모리에서 해체
    }
}
