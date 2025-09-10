class MyList<T>
{
    public int Count = 0;
    public T[] Tlist = new T[1];
    public int Capacity = 1;

    public void Add(T item)
    {
        if (Count == Capacity)
        {
            Capacity *= 2;
            T[] NewTList = new T[Capacity];
            for (int i = 0; i < Count; i++) NewTList[i] = Tlist[i];
            Tlist = NewTList;
        }
        Tlist[Count++] = item;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < Count - 1; i++) Tlist[i] = Tlist[i + 1];
        Count--;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        MyList<int> Intlist = new MyList<int>();
        for (int i = 0; i < 10; i++) Intlist.Add(i);
        Intlist.RemoveAt(5);
        Intlist.RemoveAt(5);
        Console.WriteLine($"Count : {Intlist.Count}, Capacity = {Intlist.Capacity}, List : [{string.Join(", ", Intlist.Tlist.Take(Intlist.Count))}]");
    }
}