class Graph
{
    int[,] adj = new int[6, 6]
    {
        {0, 1, 0, 1, 0, 0},
        {1, 0, 1, 1, 0, 0},
        {0, 1, 0, 0, 0, 0},
        {1, 1, 0, 0, 1, 0},
        {0, 0, 0, 1, 0, 1},
        {0, 0, 0, 0, 1, 0}
    };

    bool[] visited = new bool[6];

    public void BFS(int start)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            Console.WriteLine($"방문 : {node}");
            for (int i = 0; i < 6; i++)
            {
                if (adj[node, i] != 0 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }
    public void DFS(int start)
    {
        Console.WriteLine($"방문 : {start}");
        visited[start] = true;
        for (int i = 0; i < 6; i++)
        {
            if (adj[start, i] != 0 && !visited[i]) DFS(i);
        }
    }

    public void SearchAll()
    {
        for (int i = 0; i < 6; i++)
        {
            if (!visited[i])
            {
                DFS(i);
            }
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph();
        g.SearchAll();
    }
}