namespace _20250729_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }
        }
    }
}