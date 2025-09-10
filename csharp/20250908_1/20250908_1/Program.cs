class Program
{
    static List<int> ChangeBinary()
    {
        List<int> result = new List<int>();
        ChangeBinary(result, 0, 9);
        return result;
    }

    static void ChangeBinary(List<int> ret, int lo, int hi)
    {
        int mid = (lo + hi) / 2;
        ret.Add(mid);
        if (lo < mid) ChangeBinary(ret, lo, mid - 1);
        if (mid < hi) ChangeBinary(ret, mid + 1, hi);
    }

    static void Main()
    {
        foreach (var item in ChangeBinary())
        {
            Console.Write(item + " ");
        }
    }
}