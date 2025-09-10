class PriorityQueue
{
    List<int> _heap = new List<int>();
    public void Push(int data)
    {
        _heap.Add(data);
        int now = _heap.Count - 1;
        while (now > 0)
        {
            int next = (now - 1) / 2;
            if (_heap[now] < _heap[next]) break;
            Swap(now, next);
            now = next;
        }
    }
    public int Pop()
    {
        int ret = _heap[0];
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];
        _heap.RemoveAt(lastIndex);
        lastIndex--;
        int now = 0;
        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;

            int next = now;
            next = (left <= lastIndex && _heap[next] < _heap[left]) ? left : next;
            next = (right <= lastIndex && _heap[next] < _heap[right]) ? right : next;
            if (next == now) break;
            Swap(now, next);
            now = next;
        }
        return ret;
    }
    public int Count()
    {
        return _heap.Count;
    }

    public void Swap(int a, int b)
    {
        int tmp = _heap[a];
        _heap[a] = _heap[b];
        _heap[b] = tmp;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        PriorityQueue MyQ = new PriorityQueue();
        for (int i = 0; i < 10; i++) MyQ.Push(i);

        while (MyQ.Count() > 0) Console.WriteLine(MyQ.Pop());
        
    }
}