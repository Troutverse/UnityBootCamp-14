class Inventory<T>
{
    private List<T> items = new List<T>();
    public int Count()
    {
        return items.Count;
    }
    public void Add(T item)
    {
        items.Add(item);
    }
    public T Get(int index)
    {
        return items[index];
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Inventory<int> intInventory = new Inventory<int>();
        intInventory.Add(10);
        intInventory.Add(20);
        Console.WriteLine($"Count:Int = {intInventory.Count()}");
        Console.WriteLine($"Item: Int[1] = {intInventory.Get(1)}");
        Inventory<string> stringInventory = new Inventory<string>();
        stringInventory.Add("Sword");
        stringInventory.Add("Potion");
        Console.WriteLine($"Count: String = {stringInventory.Count()}");
        Console.WriteLine($"Item: String[0] = {stringInventory.Get(0)}");
    }
}

