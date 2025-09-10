internal class Program
{
        
    static void Main(string[] args)
    {
        long f1 = 0;
        long f2 = 1;
        long n = 10;
        long tmp;
        for (int i = 0; i < n; i++)
        {
            tmp = (f1 + f2) % 1234567;
            f1 = f2 % 1234567;
            f2 = tmp;
        }
        Console.WriteLine(f1%1234567);
    }
}