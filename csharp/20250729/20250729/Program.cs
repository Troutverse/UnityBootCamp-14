string s = "1 2 3 4";
int[] answer = s.Split(' ').Select(int.Parse).ToArray();
int MAX = 0;
int MIN = 10000000;

foreach  (int i in answer)
{
    if (i > MAX)
    {
        MAX = i;
    }
    if (i < MIN)
    {
        MIN = i;
    }
}

Console.Write(MIN + " " + MAX);