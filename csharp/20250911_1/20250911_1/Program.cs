internal class Program
{
    static void Main(string[] args)
    {
        int q = 0, w = 1;
        Swap(ref q, ref w);
        Console.WriteLine(q + " " + w);
    }

    public static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
}
