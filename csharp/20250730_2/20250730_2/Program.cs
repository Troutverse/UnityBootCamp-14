namespace _20250730_2
{
    internal class Program
    {
        static int Sum(int a, int b)
        {   
            return (b - a + 1) % 2 == 0 ? (a + b) * ((b - a + 1) / 2) : (a + (b - 1)) * ((b - a) / 2) + b;
        }
        static void Main(string[] args)
        {
            Sum(1, 2);
            Console.WriteLine(Sum(1, 6));
        }

    }
}
