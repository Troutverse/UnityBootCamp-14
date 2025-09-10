using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        //========================
        //문제 1) 합계와 평균 구하기
        //========================

        int[] a = { 5, 8, 12, -3, 7 };
        float answer = 0;
        foreach (int i in a) answer += i; 
        Console.WriteLine(answer);
        Console.WriteLine(answer / a.Length);
        Console.WriteLine();

        //========================
        //문제 2) 최대값과 최소값 찾기
        //========================

        int[] b = { 15, 3, 9, 27, -5, 8 };
        int Max = 0, Min = 100;
        foreach (int i in b)
        {
            if (i > Max) Max = i;
            if (i < Min) Min = i;
        }
        Console.WriteLine(Max);
        Console.WriteLine(Min);
        Console.WriteLine();

        //=====================================
        //문제 3) 빈도수 세기(작은 히스토그램)
        //=====================================

        int[] nums = { 1, 0, 2, 2, 1, 0, 0, 2, 1, 1 };
        int[] answers = { 0, 0, 0 };
        foreach (int i in nums) answers[i]++;
        Console.WriteLine($"0:{answers[0]} 1:{answers[1]} 2:{answers[2]}");
        Console.WriteLine();

        //=====================================
        //문제 4) 배열 뒤집기(제자리 반전)
        //=====================================

        int[] c = { 1, 2, 3, 4, 5, 6 };
        int tmps = 0;
        for (int i = 0; i < c.Length/2; i++)
        {
            tmps = c[i];
            c[i] = c[c.Length - 1 - i];
            c[c.Length-1 - i] = tmps;
        }
        for (int i = 0; i < c.Length; i++) Console.Write(c[i] + " ");
        Console.WriteLine("\n");

        //========================
        //문제 5) 배열 오름차순 정렬
        //========================

        int[] d = { 42, 17, 8, 99, 23 };
        for (int i = 0; i < d.Length-1; i++)
        {
            for (int j = i + 1; j < d.Length; j++)
            {
                int tmp = 0;
                if (d[j] <= d[i])
                {
                    tmp = d[i];
                    d[i] = d[j];
                    d[j] = tmp;
                }
            }
        }
        for (int i = 0;i < d.Length; i++) Console.Write(d[i] + " ");

    }
}