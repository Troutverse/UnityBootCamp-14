class MyList<T>
{
    public T[] TList = new T[1];
    public int idx = 0;
    public void Add(T item)
    {
        if (idx == TList.Length)
        {
            T[] LengthUpgradeArray = new T[TList.Length * 2];
            for (int i = 0; i < TList.Length; i++) LengthUpgradeArray[i] = TList[i];
            TList = LengthUpgradeArray;
        }
        TList[idx++] = item;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < idx - 1; i++) TList[i] = TList[i + 1];
        idx--;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        MyList<int> IntList = new MyList<int>();
        for (int i = 0; i < 10; i++) IntList.Add(i);
        IntList.RemoveAt(5); // 5
        IntList.RemoveAt(5); // 6
        Console.WriteLine($"[{string.Join(", ", IntList.TList.Take(IntList.idx))}]");
    }
}