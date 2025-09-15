internal class Program
{
    static int[,] parm = new int[50, 50];
    static bool[,] visited = new bool[50,50];
    static int[] dy = { -1, 0, 1, 0 };
    static int[] dx = { 0, -1, 0, 1 };
    static int count = 0;
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {

            string[] input = Console.ReadLine().Split();
            int K = int.Parse(input[2]);
            
            
            
            for (int i = 0; i < K; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                parm[int.Parse(inputs[1]), int.Parse(inputs[0])] = 1;
            }

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (parm[i, j] == 1 && !visited[i,j])
                    {
                        DFS(i, j);
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

            parm = new int[50, 50];
            visited = new bool[50, 50];
            count = 0;
        }
    }
    static void DFS(int i, int j)
    {
        visited[i, j] = true;
        for (int k = 0; k < dy.Length; k++)
        {
            int posi = i + dy[k];
            int posj = j + dx[k];

            if (posi < 0 || posj < 0 || posi >= 50 || posj >= 50) continue;
            if (parm[posi, posj] != 1) continue;
            if (visited[posi, posj] == true) continue;
            DFS(posi, posj);
        }
    }
}