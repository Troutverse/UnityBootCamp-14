internal class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        int rows = int.Parse(inputs[0]);
        int cols = int.Parse(inputs[1]);

        int[,] map = new int[rows, cols];
        int[,] visit = new int[rows, cols];

        int[] dy = { -1, 0, 1, 0 };
        int[] dx = { 0, 1, 0, -1 };

        visit[0, 0] = 1;

        for (int i = 0; i < int.Parse(inputs[0]); i++)
        {
            string input = Console.ReadLine();
            for (int j = 0; j < int.Parse(inputs[1]); j++)
            {
                map[i, j] = int.Parse(input[j].ToString());
            }
        }

        var queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        visit[0, 0] = 1;

        while (queue.Count > 0)
        {
            (int y, int x) = queue.Dequeue();


            for (int i = 0; i < dy.Length; i++)
            {
                int nextY = y + dy[i];
                int nextX = x + dx[i];

                if (nextY < 0 || nextX < 0 || nextY >= rows || nextX >= cols) continue;
                if (visit[nextY, nextX] > 0) continue;
                if (map[nextY, nextX] != 1) continue;

                visit[nextY, nextX] = visit[y, x] + 1;
                queue.Enqueue((nextY, nextX));
            }
        }

        Console.WriteLine(visit[int.Parse(inputs[0])-1, int.Parse(inputs[1])-1]);
    }
}