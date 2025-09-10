
internal class Program
{
    static void Main(string[] args)
    {

        //[출력결과]
        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ · · · · · · · · ■
        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        char[][] chars = new char[10][];
        for (int i = 0; i < chars.Length; i++) chars[i] = new char[10];
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = 0; j < chars[i].Length; j++)
            {
                if (i == 0 || j == 0 || i == chars.Length - 1 || j == chars.Length - 1) chars[i][j] = '■';
                else chars[i][j] = '·';
                Console.Write(chars[i][j]);
            }
            Console.WriteLine();
        }

        //========================
        //문제 3) 전치(Transpose) 출력
        //========================

        int[,] a = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int[,] at = new int[3, 3];
        for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) at[j, i] = a[i, j];
            
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++) Console.Write(at[i, j]);
            Console.WriteLine();
        }
    }
}
