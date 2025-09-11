internal class Program
{
    static void Main(string[] args)
    {
        Add(1, 1);
    }

    static void Add(int Y, int X)
    {
        int[,] map =
        {
            { 1, 1, 1},
            { 1, 1, 1},
            { 1, 1, 1},
        };

        int[] deltaX = { 0, 1, 0, -1 };
        int[] deltaY = { -1, 0, 1, 0 };

        for (int i = 0; i < deltaX.Length; i++)
        {
            int nx = X + deltaX[i];
            int ny = Y + deltaY[i];

            map[ny, nx] += 1;
        }

        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}