namespace _20250730_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 오버로딩 = 다중 정의
            // 하나의 이름으로 다중으로 정의한다 = 함수 이름 재사용
            int a = 3, b = 6;
            int result = Sum(a, b);
            Console.WriteLine(result);
        }
        static int Sum(int a, int b)
        {
            int result = (b-a+1) % 2 == 0 ? (a + b) * ((b - a + 1) / 2) : (a + (b-1)) * ((b - a) / 2) + b;        
            return result;
        }
        static int Add(int a, int b) 
        {
            return a + b;
        }
        static int Add(int a) // 이렇게 이름은 같지만 매개변수가 다르면 상관없다.
        {
            return a;
        }
        
    }
}